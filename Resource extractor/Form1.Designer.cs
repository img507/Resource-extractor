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
            this.txtResxPath = new System.Windows.Forms.TextBox();
            this.lblResxPath = new System.Windows.Forms.Label();
            this.btnBrowseResx = new System.Windows.Forms.Button();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.lblOutputPath = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnExtract = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResxPath
            // 
            this.txtResxPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResxPath.Location = new System.Drawing.Point(15, 31);
            this.txtResxPath.Name = "txtResxPath";
            this.txtResxPath.Size = new System.Drawing.Size(476, 20);
            this.txtResxPath.TabIndex = 1;
            // 
            // lblResxPath
            // 
            this.lblResxPath.AutoSize = true;
            this.lblResxPath.Location = new System.Drawing.Point(12, 15);
            this.lblResxPath.Name = "lblResxPath";
            this.lblResxPath.Size = new System.Drawing.Size(102, 13);
            this.lblResxPath.TabIndex = 0;
            this.lblResxPath.Text = "Путь к файлу .resx:";
            // 
            // btnBrowseResx
            // 
            this.btnBrowseResx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseResx.Location = new System.Drawing.Point(497, 29);
            this.btnBrowseResx.Name = "btnBrowseResx";
            this.btnBrowseResx.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseResx.TabIndex = 2;
            this.btnBrowseResx.Text = "Обзор...";
            this.btnBrowseResx.UseVisualStyleBackColor = true;
            this.btnBrowseResx.Click += new System.EventHandler(this.btnBrowseResx_Click);
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseOutput.Location = new System.Drawing.Point(497, 78);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 5;
            this.btnBrowseOutput.Text = "Обзор...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.btnBrowseOutput_Click);
            // 
            // lblOutputPath
            // 
            this.lblOutputPath.AutoSize = true;
            this.lblOutputPath.Location = new System.Drawing.Point(12, 64);
            this.lblOutputPath.Name = "lblOutputPath";
            this.lblOutputPath.Size = new System.Drawing.Size(104, 13);
            this.lblOutputPath.TabIndex = 3;
            this.lblOutputPath.Text = "Папка сохранения:";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutputPath.Location = new System.Drawing.Point(15, 80);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(476, 20);
            this.txtOutputPath.TabIndex = 4;
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtract.Location = new System.Drawing.Point(15, 117);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(557, 42);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "ИЗВЛЕЧЬ РЕСУРСЫ";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.Black;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbLog.ForeColor = System.Drawing.Color.Lime;
            this.rtbLog.Location = new System.Drawing.Point(15, 189);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(557, 285);
            this.rtbLog.TabIndex = 8;
            this.rtbLog.Text = "";
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 173);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(94, 13);
            this.lblLog.TabIndex = 7;
            this.lblLog.Text = "Лог выполнения:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 486);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.lblOutputPath);
            this.Controls.Add(this.btnBrowseResx);
            this.Controls.Add(this.txtResxPath);
            this.Controls.Add(this.lblResxPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResX Extractor Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

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