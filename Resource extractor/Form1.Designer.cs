namespace Resource_extractor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtResxPath = new TextBox();
            lblResxPath = new Label();
            btnBrowseResx = new Button();
            btnBrowseOutput = new Button();
            lblOutputPath = new Label();
            txtOutputPath = new TextBox();
            btnExtract = new Button();
            rtbLog = new RichTextBox();
            lblLog = new Label();
            SuspendLayout();
            // 
            // txtResxPath
            // 
            txtResxPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtResxPath.Location = new Point(18, 36);
            txtResxPath.Margin = new Padding(4, 3, 4, 3);
            txtResxPath.Name = "txtResxPath";
            txtResxPath.Size = new Size(555, 23);
            txtResxPath.TabIndex = 1;
            // 
            // lblResxPath
            // 
            lblResxPath.AutoSize = true;
            lblResxPath.Location = new Point(14, 17);
            lblResxPath.Margin = new Padding(4, 0, 4, 0);
            lblResxPath.Name = "lblResxPath";
            lblResxPath.Size = new Size(110, 15);
            lblResxPath.TabIndex = 0;
            lblResxPath.Text = "Путь к файлу .resx:";
            // 
            // btnBrowseResx
            // 
            btnBrowseResx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseResx.Location = new Point(580, 33);
            btnBrowseResx.Margin = new Padding(4, 3, 4, 3);
            btnBrowseResx.Name = "btnBrowseResx";
            btnBrowseResx.Size = new Size(88, 27);
            btnBrowseResx.TabIndex = 2;
            btnBrowseResx.Text = "Обзор...";
            btnBrowseResx.UseVisualStyleBackColor = true;
            btnBrowseResx.Click += btnBrowseResx_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowseOutput.Location = new Point(580, 90);
            btnBrowseOutput.Margin = new Padding(4, 3, 4, 3);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(88, 27);
            btnBrowseOutput.TabIndex = 5;
            btnBrowseOutput.Text = "Обзор...";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // lblOutputPath
            // 
            lblOutputPath.AutoSize = true;
            lblOutputPath.Location = new Point(14, 74);
            lblOutputPath.Margin = new Padding(4, 0, 4, 0);
            lblOutputPath.Name = "lblOutputPath";
            lblOutputPath.Size = new Size(112, 15);
            lblOutputPath.TabIndex = 3;
            lblOutputPath.Text = "Папка сохранения:";
            // 
            // txtOutputPath
            // 
            txtOutputPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOutputPath.Location = new Point(18, 92);
            txtOutputPath.Margin = new Padding(4, 3, 4, 3);
            txtOutputPath.Name = "txtOutputPath";
            txtOutputPath.Size = new Size(555, 23);
            txtOutputPath.TabIndex = 4;
            // 
            // btnExtract
            // 
            btnExtract.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnExtract.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnExtract.Location = new Point(18, 135);
            btnExtract.Margin = new Padding(4, 3, 4, 3);
            btnExtract.Name = "btnExtract";
            btnExtract.Size = new Size(650, 48);
            btnExtract.TabIndex = 6;
            btnExtract.Text = "ИЗВЛЕЧЬ РЕСУРСЫ";
            btnExtract.UseVisualStyleBackColor = true;
            btnExtract.Click += btnExtract_Click;
            // 
            // rtbLog
            // 
            rtbLog.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbLog.BackColor = Color.White;
            rtbLog.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rtbLog.ForeColor = Color.Black;
            rtbLog.Location = new Point(18, 218);
            rtbLog.Margin = new Padding(4, 3, 4, 3);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.Size = new Size(649, 328);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // lblLog
            // 
            lblLog.AutoSize = true;
            lblLog.Location = new Point(14, 200);
            lblLog.Margin = new Padding(4, 0, 4, 0);
            lblLog.Name = "lblLog";
            lblLog.Size = new Size(102, 15);
            lblLog.TabIndex = 7;
            lblLog.Text = "Лог выполнения:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 561);
            Controls.Add(rtbLog);
            Controls.Add(lblLog);
            Controls.Add(btnExtract);
            Controls.Add(btnBrowseOutput);
            Controls.Add(txtOutputPath);
            Controls.Add(lblOutputPath);
            Controls.Add(btnBrowseResx);
            Controls.Add(txtResxPath);
            Controls.Add(lblResxPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(464, 456);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResX Extractor Tool";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        // Объявление переменных (контролов), которые мы используем в коде
        private System.Windows.Forms.TextBox txtResxPath;
        private System.Windows.Forms.Label lblResxPath;
        private System.Windows.Forms.Button btnBrowseResx;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.Label lblOutputPath;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Label lblLog;
    }
}