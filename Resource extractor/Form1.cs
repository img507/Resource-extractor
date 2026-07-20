using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Resource_extractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowseResx_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "ResX Files (*.resx)|*.resx|All files (*.*)|*.*";
                ofd.Title = "Выберите файл ресурсов .resx";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtResxPath.Text = ofd.FileName;

                    string directoryName = Path.GetDirectoryName(ofd.FileName) ?? string.Empty;
                    string proposedPath = Path.Combine(directoryName, "Extracted_" + Path.GetFileNameWithoutExtension(ofd.FileName));

                    txtOutputPath.Text = proposedPath;
                }
            }
        }

        private void btnBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Выберите папку для сохранения ресурсов";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtOutputPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            string resxPath = txtResxPath.Text;
            string outputDir = txtOutputPath.Text;

            rtbLog.Clear();

            if (!File.Exists(resxPath))
            {
                Log("ОШИБКА: Файл .resx не найден!", Color.Red);
                return;
            }
            if (string.IsNullOrWhiteSpace(outputDir))
            {
                Log("ОШИБКА: Не указана папка для сохранения!", Color.Red);
                return;
            }

            if (Directory.Exists(outputDir) && Directory.GetFileSystemEntries(outputDir).Length > 0)
            {
                Log($"ПРОПУСК: Папка уже содержит файлы: {Path.GetFileName(outputDir)}", Color.DarkOrange);
                Log("Ресурсы не будут извлечены повторно.", Color.DarkOrange);
                System.Diagnostics.Process.Start("explorer.exe", outputDir);
                return;
            }

            try
            {
                btnExtract.Enabled = false;
                Directory.CreateDirectory(outputDir);
                Log($"Старт извлечения из: {Path.GetFileName(resxPath)}", Color.Blue);

                ExtractAll(resxPath, outputDir);

                Log("---------------------------", Color.Black);
                Log("ГОТОВО! Операция завершена.", Color.Green);

                System.Diagnostics.Process.Start("explorer.exe", outputDir);
            }
            catch (Exception ex)
            {
                Log($"КРИТИЧЕСКАЯ ОШИБКА: {ex.Message}", Color.Red);
            }
            finally
            {
                btnExtract.Enabled = true;
            }
        }

        private void ExtractAll(string filePath, string dir)
        {
            StringBuilder stringResources = new StringBuilder();
            int countImages = 0;
            int countIcons = 0;
            int countStrings = 0;
            int countOther = 0;

            using (ResXResourceReader reader = new ResXResourceReader(filePath))
            {
                foreach (DictionaryEntry entry in reader)
                {
                    string? key = entry.Key?.ToString();
                    object? value = entry.Value;

                    if (key == null || value == null) continue;

                    string safeName = CleanFileName(key);

                    if (value is string textValue)
                    {
                        stringResources.AppendLine($"Name: {key}");
                        stringResources.AppendLine($"Value: {textValue}");
                        stringResources.AppendLine("-----------------------");
                        countStrings++;
                    }
                    else if (value is Image img)
                    {
                        string savePath = Path.Combine(dir, safeName + ".png");
                        try
                        {
                            img.Save(savePath, ImageFormat.Png);
                            Log($"[IMG] Сохранено: {safeName}.png", Color.DimGray);
                            countImages++;
                        }
                        catch (Exception ex)
                        {
                            Log($"[IMG Error] Не удалось сохранить {key}: {ex.Message}", Color.DarkOrange);
                        }
                    }
                    else if (value is Icon icon)
                    {
                        string savePath = Path.Combine(dir, safeName + ".ico");
                        try
                        {
                            using (FileStream fs = new FileStream(savePath, FileMode.Create))
                            {
                                icon.Save(fs);
                            }
                            Log($"[ICON] Сохранено: {safeName}.ico", Color.DimGray);
                            countIcons++;
                        }
                        catch (Exception ex)
                        {
                            Log($"[ICON Error] {key}: {ex.Message}", Color.DarkOrange);
                        }
                    }
                    else if (value is byte[] bytes)
                    {
                        string savePath = Path.Combine(dir, safeName + ".bin");
                        File.WriteAllBytes(savePath, bytes);
                        Log($"[BIN] Сохранено: {safeName}.bin", Color.Teal);
                        countOther++;
                    }
                    else if (value is Stream stream)
                    {
                        string savePath = Path.Combine(dir, safeName + ".wav");

                        if (stream.CanSeek) stream.Position = 0;

                        using (FileStream fs = File.Create(savePath))
                        {
                            stream.CopyTo(fs);
                        }
                        Log($"[AUDIO] Сохранен поток: {safeName}.wav", Color.Teal);
                        countOther++;
                    }
                    else
                    {
                        Log($"[UNKNOWN] Пропущен тип: {value.GetType().Name} (Ключ: {key})", Color.Purple);
                    }
                }
            }

            if (stringResources.Length > 0)
            {
                string txtPath = Path.Combine(dir, "_AllStrings.txt");
                File.WriteAllText(txtPath, stringResources.ToString());
                Log($"[TEXT] Все строки сохранены в: _AllStrings.txt ({countStrings} шт.)", Color.DarkGreen);
            }

            Log($"\nСтатистика:\nКартинки: {countImages}\nИконки: {countIcons}\nТекст: {countStrings}\nДругое: {countOther}", Color.Black);
        }

        private string CleanFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }

        private void Log(string msg, Color color)
        {
            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.SelectionLength = 0;

            rtbLog.SelectionColor = color;
            rtbLog.AppendText(msg + "\n");

            rtbLog.SelectionColor = Color.Black;
            rtbLog.ScrollToCaret();
        }
    }
}