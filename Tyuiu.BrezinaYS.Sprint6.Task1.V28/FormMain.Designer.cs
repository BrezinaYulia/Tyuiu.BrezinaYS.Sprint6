namespace Tyuiu.BrezinaYS.Sprint6.Task1.V28
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxStartStep_BYS = new TextBox();
            textBoxStopStep_BYS = new TextBox();
            groupBox1 = new GroupBox();
            textBoxStop_BYS = new TextBox();
            textBoxSt_BYS = new TextBox();
            groupBoxYsl_BYS = new GroupBox();
            textBoxTask_BYS = new TextBox();
            groupBoxPrint_BYS = new GroupBox();
            textBox1 = new TextBox();
            textBoxRes_BYS = new TextBox();
            buttonDone_BYS = new Button();
            buttonHelp_BYS = new Button();
            groupBox1.SuspendLayout();
            groupBoxYsl_BYS.SuspendLayout();
            groupBoxPrint_BYS.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxStartStep_BYS
            // 
            textBoxStartStep_BYS.Location = new Point(6, 47);
            textBoxStartStep_BYS.Name = "textBoxStartStep_BYS";
            textBoxStartStep_BYS.Size = new Size(125, 25);
            textBoxStartStep_BYS.TabIndex = 0;
            textBoxStartStep_BYS.TextChanged += textBoxStartStep_BYS_TextChanged;
            // 
            // textBoxStopStep_BYS
            // 
            textBoxStopStep_BYS.Location = new Point(137, 47);
            textBoxStopStep_BYS.Name = "textBoxStopStep_BYS";
            textBoxStopStep_BYS.Size = new Size(125, 25);
            textBoxStopStep_BYS.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStop_BYS);
            groupBox1.Controls.Add(textBoxSt_BYS);
            groupBox1.Controls.Add(textBoxStartStep_BYS);
            groupBox1.Controls.Add(textBoxStopStep_BYS);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 216);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 80);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBoxStop_BYS
            // 
            textBoxStop_BYS.BackColor = SystemColors.Control;
            textBoxStop_BYS.BorderStyle = BorderStyle.None;
            textBoxStop_BYS.Location = new Point(137, 26);
            textBoxStop_BYS.Name = "textBoxStop_BYS";
            textBoxStop_BYS.ReadOnly = true;
            textBoxStop_BYS.Size = new Size(125, 18);
            textBoxStop_BYS.TabIndex = 3;
            textBoxStop_BYS.Text = "Конец шага:";
            // 
            // textBoxSt_BYS
            // 
            textBoxSt_BYS.BackColor = SystemColors.Control;
            textBoxSt_BYS.BorderStyle = BorderStyle.None;
            textBoxSt_BYS.Location = new Point(6, 23);
            textBoxSt_BYS.Name = "textBoxSt_BYS";
            textBoxSt_BYS.ReadOnly = true;
            textBoxSt_BYS.Size = new Size(125, 18);
            textBoxSt_BYS.TabIndex = 2;
            textBoxSt_BYS.Text = "Старт шага:";
            textBoxSt_BYS.TextChanged += textBoxSt_BYS_TextChanged;
            // 
            // groupBoxYsl_BYS
            // 
            groupBoxYsl_BYS.Controls.Add(textBoxTask_BYS);
            groupBoxYsl_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxYsl_BYS.Location = new Point(12, 12);
            groupBoxYsl_BYS.Name = "groupBoxYsl_BYS";
            groupBoxYsl_BYS.Size = new Size(427, 198);
            groupBoxYsl_BYS.TabIndex = 4;
            groupBoxYsl_BYS.TabStop = false;
            groupBoxYsl_BYS.Text = "Условие";
            // 
            // textBoxTask_BYS
            // 
            textBoxTask_BYS.BackColor = SystemColors.Control;
            textBoxTask_BYS.BorderStyle = BorderStyle.None;
            textBoxTask_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BYS.Location = new Point(6, 24);
            textBoxTask_BYS.Multiline = true;
            textBoxTask_BYS.Name = "textBoxTask_BYS";
            textBoxTask_BYS.Size = new Size(411, 81);
            textBoxTask_BYS.TabIndex = 0;
            textBoxTask_BYS.Text = "Протабулировать функцию cos(x) + (4x)/2 - sin(x) * 3x на заданном диапазоне.\r\nРезультаты вывести в виде таблицы.";
            // 
            // groupBoxPrint_BYS
            // 
            groupBoxPrint_BYS.Controls.Add(textBox1);
            groupBoxPrint_BYS.Controls.Add(textBoxRes_BYS);
            groupBoxPrint_BYS.Cursor = Cursors.IBeam;
            groupBoxPrint_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxPrint_BYS.Location = new Point(456, 12);
            groupBoxPrint_BYS.Name = "groupBoxPrint_BYS";
            groupBoxPrint_BYS.Size = new Size(250, 294);
            groupBoxPrint_BYS.TabIndex = 5;
            groupBoxPrint_BYS.TabStop = false;
            groupBoxPrint_BYS.Text = "Вывод данных";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 19);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 18);
            textBox1.TabIndex = 4;
            textBox1.Text = "Результат";
            // 
            // textBoxRes_BYS
            // 
            textBoxRes_BYS.BackColor = SystemColors.Control;
            textBoxRes_BYS.ForeColor = SystemColors.Desktop;
            textBoxRes_BYS.Location = new Point(6, 43);
            textBoxRes_BYS.Multiline = true;
            textBoxRes_BYS.Name = "textBoxRes_BYS";
            textBoxRes_BYS.ReadOnly = true;
            textBoxRes_BYS.ScrollBars = ScrollBars.Vertical;
            textBoxRes_BYS.Size = new Size(238, 246);
            textBoxRes_BYS.TabIndex = 0;
            // 
            // buttonDone_BYS
            // 
            buttonDone_BYS.BackColor = Color.Green;
            buttonDone_BYS.Location = new Point(354, 226);
            buttonDone_BYS.Name = "buttonDone_BYS";
            buttonDone_BYS.Size = new Size(102, 62);
            buttonDone_BYS.TabIndex = 6;
            buttonDone_BYS.Text = "Выполнить";
            buttonDone_BYS.UseVisualStyleBackColor = false;
            buttonDone_BYS.Click += buttonDone_BYS_Click;
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_BYS.Location = new Point(286, 226);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(62, 62);
            buttonHelp_BYS.TabIndex = 7;
            buttonHelp_BYS.Text = "?";
            buttonHelp_BYS.UseVisualStyleBackColor = false;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 308);
            Controls.Add(buttonHelp_BYS);
            Controls.Add(buttonDone_BYS);
            Controls.Add(groupBoxPrint_BYS);
            Controls.Add(groupBoxYsl_BYS);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 28 | Брезина Ю.С.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxYsl_BYS.ResumeLayout(false);
            groupBoxYsl_BYS.PerformLayout();
            groupBoxPrint_BYS.ResumeLayout(false);
            groupBoxPrint_BYS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxStartStep_BYS;
        private TextBox textBoxStopStep_BYS;
        private GroupBox groupBox1;
        private TextBox textBoxStop_BYS;
        private TextBox textBoxSt_BYS;
        private GroupBox groupBoxYsl_BYS;
        private TextBox textBoxTask_BYS;
        private GroupBox groupBoxPrint_BYS;
        private TextBox textBoxRes_BYS;
        private TextBox textBox1;
        private Button buttonDone_BYS;
        private Button buttonHelp_BYS;
    }
}
