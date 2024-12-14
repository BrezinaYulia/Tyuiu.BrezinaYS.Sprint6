namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new Label();
            buttonOK_BYS = new Button();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(102, 9);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(387, 100);
            labelInfo.TabIndex = 0;
            labelInfo.Text = "Разработчик: Брезина Ю.С.\r\nгруппа ИИПб-24-2\r\n\r\nПрограмма разработана в рамках изучения языка C#\r\nВнутреннее имя: Tyuiu.BrezinaYS.Sprint6.Task7.V7";
            // 
            // buttonOK_BYS
            // 
            buttonOK_BYS.Location = new Point(373, 176);
            buttonOK_BYS.Name = "buttonOK_BYS";
            buttonOK_BYS.Size = new Size(94, 29);
            buttonOK_BYS.TabIndex = 1;
            buttonOK_BYS.Text = "OK";
            buttonOK_BYS.UseVisualStyleBackColor = true;
            buttonOK_BYS.Click += buttonOK_BYS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 227);
            Controls.Add(buttonOK_BYS);
            Controls.Add(labelInfo);
            MaximizeBox = false;
            Name = "FormAbout";
            Text = "О программе ";
            Load += FormAbout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo;
        private Button buttonOK_BYS;
    }
}