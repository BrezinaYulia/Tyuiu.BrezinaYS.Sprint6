namespace Tyuiu.BrezinaYS.Sprint6.Task4.V2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelUp_BYS = new Panel();
            buttonHelp_BYS = new Button();
            buttonSave_BYS = new Button();
            buttonDone_BYS = new Button();
            groupBoxInput_BYS = new GroupBox();
            textBox2 = new TextBox();
            textBoxStopStep_BYS = new TextBox();
            textBoxStartStep_BYS = new TextBox();
            textBoxStart_BYS = new TextBox();
            groupBox1 = new GroupBox();
            textBoxYSL_BYS = new TextBox();
            panelLeft_BYS = new Panel();
            groupBoxLeft_BYS = new GroupBox();
            textBoxRes_BYS = new TextBox();
            panelRight_BYS = new Panel();
            chartFunction_BYS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_BYS.SuspendLayout();
            groupBoxInput_BYS.SuspendLayout();
            groupBox1.SuspendLayout();
            panelLeft_BYS.SuspendLayout();
            groupBoxLeft_BYS.SuspendLayout();
            panelRight_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).BeginInit();
            SuspendLayout();
            // 
            // panelUp_BYS
            // 
            panelUp_BYS.Controls.Add(buttonHelp_BYS);
            panelUp_BYS.Controls.Add(buttonSave_BYS);
            panelUp_BYS.Controls.Add(buttonDone_BYS);
            panelUp_BYS.Controls.Add(groupBoxInput_BYS);
            panelUp_BYS.Controls.Add(groupBox1);
            panelUp_BYS.Dock = DockStyle.Top;
            panelUp_BYS.Location = new Point(0, 0);
            panelUp_BYS.Name = "panelUp_BYS";
            panelUp_BYS.Size = new Size(977, 90);
            panelUp_BYS.TabIndex = 0;
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BYS.BackColor = Color.FromArgb(255, 192, 255);
            buttonHelp_BYS.Location = new Point(893, 13);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(72, 64);
            buttonHelp_BYS.TabIndex = 4;
            buttonHelp_BYS.Text = "???";
            buttonHelp_BYS.UseVisualStyleBackColor = false;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // buttonSave_BYS
            // 
            buttonSave_BYS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_BYS.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_BYS.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSave_BYS.Location = new Point(794, 13);
            buttonSave_BYS.Name = "buttonSave_BYS";
            buttonSave_BYS.Size = new Size(88, 64);
            buttonSave_BYS.TabIndex = 3;
            buttonSave_BYS.Text = "Сохранить ";
            buttonSave_BYS.UseVisualStyleBackColor = false;
            buttonSave_BYS.Click += buttonSave_Click;
            // 
            // buttonDone_BYS
            // 
            buttonDone_BYS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_BYS.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_BYS.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone_BYS.Location = new Point(701, 12);
            buttonDone_BYS.Name = "buttonDone_BYS";
            buttonDone_BYS.Size = new Size(85, 65);
            buttonDone_BYS.TabIndex = 2;
            buttonDone_BYS.Text = "Выполнить";
            buttonDone_BYS.UseVisualStyleBackColor = false;
            buttonDone_BYS.Click += buttonDone_BYS_Click;
            // 
            // groupBoxInput_BYS
            // 
            groupBoxInput_BYS.Anchor = AnchorStyles.Top;
            groupBoxInput_BYS.Controls.Add(textBox2);
            groupBoxInput_BYS.Controls.Add(textBoxStopStep_BYS);
            groupBoxInput_BYS.Controls.Add(textBoxStartStep_BYS);
            groupBoxInput_BYS.Controls.Add(textBoxStart_BYS);
            groupBoxInput_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxInput_BYS.Location = new Point(429, 3);
            groupBoxInput_BYS.Name = "groupBoxInput_BYS";
            groupBoxInput_BYS.Size = new Size(266, 81);
            groupBoxInput_BYS.TabIndex = 1;
            groupBoxInput_BYS.TabStop = false;
            groupBoxInput_BYS.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(135, 24);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 18);
            textBox2.TabIndex = 3;
            textBox2.Text = "Конец шага:";
            // 
            // textBoxStopStep_BYS
            // 
            textBoxStopStep_BYS.Location = new Point(135, 49);
            textBoxStopStep_BYS.Name = "textBoxStopStep_BYS";
            textBoxStopStep_BYS.Size = new Size(125, 25);
            textBoxStopStep_BYS.TabIndex = 2;
            // 
            // textBoxStartStep_BYS
            // 
            textBoxStartStep_BYS.Location = new Point(7, 49);
            textBoxStartStep_BYS.Name = "textBoxStartStep_BYS";
            textBoxStartStep_BYS.Size = new Size(125, 25);
            textBoxStartStep_BYS.TabIndex = 1;
            // 
            // textBoxStart_BYS
            // 
            textBoxStart_BYS.BackColor = SystemColors.Control;
            textBoxStart_BYS.BorderStyle = BorderStyle.None;
            textBoxStart_BYS.Location = new Point(8, 22);
            textBoxStart_BYS.Name = "textBoxStart_BYS";
            textBoxStart_BYS.Size = new Size(125, 18);
            textBoxStart_BYS.TabIndex = 0;
            textBoxStart_BYS.Text = "Старт шага:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxYSL_BYS);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 81);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие ";
            // 
            // textBoxYSL_BYS
            // 
            textBoxYSL_BYS.BackColor = SystemColors.Control;
            textBoxYSL_BYS.BorderStyle = BorderStyle.None;
            textBoxYSL_BYS.Location = new Point(13, 20);
            textBoxYSL_BYS.Multiline = true;
            textBoxYSL_BYS.Name = "textBoxYSL_BYS";
            textBoxYSL_BYS.ReadOnly = true;
            textBoxYSL_BYS.Size = new Size(384, 61);
            textBoxYSL_BYS.TabIndex = 0;
            textBoxYSL_BYS.Text = "Протабулировать функцию на заданном диапазоне. \r\nРезультат вывести в textBox, построить график и сохранить в файл по нажатии на кнопку";
            // 
            // panelLeft_BYS
            // 
            panelLeft_BYS.Controls.Add(groupBoxLeft_BYS);
            panelLeft_BYS.Dock = DockStyle.Left;
            panelLeft_BYS.Location = new Point(0, 90);
            panelLeft_BYS.Name = "panelLeft_BYS";
            panelLeft_BYS.Size = new Size(258, 483);
            panelLeft_BYS.TabIndex = 1;
            // 
            // groupBoxLeft_BYS
            // 
            groupBoxLeft_BYS.Controls.Add(textBoxRes_BYS);
            groupBoxLeft_BYS.Dock = DockStyle.Fill;
            groupBoxLeft_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxLeft_BYS.Location = new Point(0, 0);
            groupBoxLeft_BYS.Name = "groupBoxLeft_BYS";
            groupBoxLeft_BYS.Size = new Size(258, 483);
            groupBoxLeft_BYS.TabIndex = 0;
            groupBoxLeft_BYS.TabStop = false;
            groupBoxLeft_BYS.Text = "Вывод";
            // 
            // textBoxRes_BYS
            // 
            textBoxRes_BYS.Dock = DockStyle.Left;
            textBoxRes_BYS.Location = new Point(3, 21);
            textBoxRes_BYS.Multiline = true;
            textBoxRes_BYS.Name = "textBoxRes_BYS";
            textBoxRes_BYS.ScrollBars = ScrollBars.Vertical;
            textBoxRes_BYS.Size = new Size(252, 459);
            textBoxRes_BYS.TabIndex = 0;
            // 
            // panelRight_BYS
            // 
            panelRight_BYS.Controls.Add(chartFunction_BYS);
            panelRight_BYS.Dock = DockStyle.Fill;
            panelRight_BYS.Location = new Point(258, 90);
            panelRight_BYS.Name = "panelRight_BYS";
            panelRight_BYS.Size = new Size(719, 483);
            panelRight_BYS.TabIndex = 2;
            // 
            // chartFunction_BYS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BYS.ChartAreas.Add(chartArea1);
            chartFunction_BYS.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_BYS.Legends.Add(legend1);
            chartFunction_BYS.Location = new Point(0, 0);
            chartFunction_BYS.Name = "chartFunction_BYS";
            chartFunction_BYS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BYS.Series.Add(series1);
            chartFunction_BYS.Size = new Size(719, 483);
            chartFunction_BYS.TabIndex = 0;
            chartFunction_BYS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 573);
            Controls.Add(panelRight_BYS);
            Controls.Add(panelLeft_BYS);
            Controls.Add(panelUp_BYS);
            MinimumSize = new Size(995, 620);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 2 | Брезина Ю.С.";
            panelUp_BYS.ResumeLayout(false);
            groupBoxInput_BYS.ResumeLayout(false);
            groupBoxInput_BYS.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelLeft_BYS.ResumeLayout(false);
            groupBoxLeft_BYS.ResumeLayout(false);
            groupBoxLeft_BYS.PerformLayout();
            panelRight_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_BYS;
        private Panel panelLeft_BYS;
        private GroupBox groupBoxLeft_BYS;
        private Panel panelRight_BYS;
        private GroupBox groupBox1;
        private TextBox textBoxYSL_BYS;
        private GroupBox groupBoxInput_BYS;
        private TextBox textBox2;
        private TextBox textBoxStopStep_BYS;
        private TextBox textBoxStartStep_BYS;
        private TextBox textBoxStart_BYS;
        private Button buttonHelp_BYS;
        private Button buttonSave_BYS;
        private Button buttonDone_BYS;
        private TextBox textBoxRes_BYS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYS;
    }
}
