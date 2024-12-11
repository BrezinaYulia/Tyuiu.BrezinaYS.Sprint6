namespace Tyuiu.BrezinaYS.Sprint6.Task2.V3
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
            groupBoxTask_BYS = new GroupBox();
            textBoxYsl_BYS = new TextBox();
            groupBox1 = new GroupBox();
            textBoxStopSrep_BYS = new TextBox();
            textBoxStop_BYS = new TextBox();
            textBoxStartStep_BYS = new TextBox();
            textBoxStart_BYS = new TextBox();
            button1 = new Button();
            buttonRes_BYS = new Button();
            groupBoxPrint_BYS = new GroupBox();
            chartFunction_BYS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_BYS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            groupBoxTask_BYS.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxPrint_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BYS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BYS
            // 
            groupBoxTask_BYS.Controls.Add(textBoxYsl_BYS);
            groupBoxTask_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTask_BYS.Location = new Point(26, 12);
            groupBoxTask_BYS.Name = "groupBoxTask_BYS";
            groupBoxTask_BYS.Size = new Size(539, 221);
            groupBoxTask_BYS.TabIndex = 0;
            groupBoxTask_BYS.TabStop = false;
            groupBoxTask_BYS.Text = "Условие ";
            // 
            // textBoxYsl_BYS
            // 
            textBoxYsl_BYS.BackColor = SystemColors.Control;
            textBoxYsl_BYS.BorderStyle = BorderStyle.None;
            textBoxYsl_BYS.Location = new Point(9, 23);
            textBoxYsl_BYS.Multiline = true;
            textBoxYsl_BYS.Name = "textBoxYsl_BYS";
            textBoxYsl_BYS.Size = new Size(455, 192);
            textBoxYsl_BYS.TabIndex = 0;
            textBoxYsl_BYS.Text = "Протабулировать функцию sin(x)/(x +1.2) + cos(x) *7x - 2 на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции. ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxStopSrep_BYS);
            groupBox1.Controls.Add(textBoxStop_BYS);
            groupBox1.Controls.Add(textBoxStartStep_BYS);
            groupBox1.Controls.Add(textBoxStart_BYS);
            groupBox1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(29, 233);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 76);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxStopSrep_BYS
            // 
            textBoxStopSrep_BYS.Location = new Point(158, 44);
            textBoxStopSrep_BYS.Name = "textBoxStopSrep_BYS";
            textBoxStopSrep_BYS.Size = new Size(125, 25);
            textBoxStopSrep_BYS.TabIndex = 3;
            // 
            // textBoxStop_BYS
            // 
            textBoxStop_BYS.BackColor = SystemColors.Control;
            textBoxStop_BYS.BorderStyle = BorderStyle.None;
            textBoxStop_BYS.Location = new Point(157, 21);
            textBoxStop_BYS.Name = "textBoxStop_BYS";
            textBoxStop_BYS.ReadOnly = true;
            textBoxStop_BYS.ShortcutsEnabled = false;
            textBoxStop_BYS.Size = new Size(125, 18);
            textBoxStop_BYS.TabIndex = 2;
            textBoxStop_BYS.Text = "Конец шага:";
            // 
            // textBoxStartStep_BYS
            // 
            textBoxStartStep_BYS.Location = new Point(12, 43);
            textBoxStartStep_BYS.Name = "textBoxStartStep_BYS";
            textBoxStartStep_BYS.Size = new Size(125, 25);
            textBoxStartStep_BYS.TabIndex = 1;
            // 
            // textBoxStart_BYS
            // 
            textBoxStart_BYS.BackColor = SystemColors.Control;
            textBoxStart_BYS.BorderStyle = BorderStyle.None;
            textBoxStart_BYS.Location = new Point(12, 21);
            textBoxStart_BYS.Name = "textBoxStart_BYS";
            textBoxStart_BYS.ReadOnly = true;
            textBoxStart_BYS.Size = new Size(125, 18);
            textBoxStart_BYS.TabIndex = 0;
            textBoxStart_BYS.Text = "Старт шага:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(323, 239);
            button1.Name = "button1";
            button1.Size = new Size(81, 65);
            button1.TabIndex = 2;
            button1.Text = "Справка";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonRes_BYS
            // 
            buttonRes_BYS.BackColor = Color.Green;
            buttonRes_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRes_BYS.Location = new Point(409, 240);
            buttonRes_BYS.Name = "buttonRes_BYS";
            buttonRes_BYS.Size = new Size(156, 61);
            buttonRes_BYS.TabIndex = 3;
            buttonRes_BYS.Text = "Выполнить ";
            buttonRes_BYS.UseVisualStyleBackColor = false;
            buttonRes_BYS.Click += buttonDone_Click;
            buttonRes_BYS.MouseDown += buttonDone_MouseDown;
            buttonRes_BYS.MouseEnter += buttonDone_MouseEnter;
            buttonRes_BYS.MouseLeave += buttonDone_MouseLeave;
            // 
            // groupBoxPrint_BYS
            // 
            groupBoxPrint_BYS.Controls.Add(chartFunction_BYS);
            groupBoxPrint_BYS.Controls.Add(dataGridViewFunction_BYS);
            groupBoxPrint_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxPrint_BYS.Location = new Point(574, 21);
            groupBoxPrint_BYS.Name = "groupBoxPrint_BYS";
            groupBoxPrint_BYS.Size = new Size(441, 283);
            groupBoxPrint_BYS.TabIndex = 4;
            groupBoxPrint_BYS.TabStop = false;
            groupBoxPrint_BYS.Text = "Вывод данных ";
            // 
            // chartFunction_BYS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BYS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_BYS.Legends.Add(legend1);
            chartFunction_BYS.Location = new Point(142, 12);
            chartFunction_BYS.Name = "chartFunction_BYS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BYS.Series.Add(series1);
            chartFunction_BYS.Size = new Size(293, 265);
            chartFunction_BYS.TabIndex = 1;
            chartFunction_BYS.Text = "chart1";
            // 
            // dataGridViewFunction_BYS
            // 
            dataGridViewFunction_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_BYS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewFunction_BYS.Location = new Point(6, 18);
            dataGridViewFunction_BYS.Name = "dataGridViewFunction_BYS";
            dataGridViewFunction_BYS.RowHeadersVisible = false;
            dataGridViewFunction_BYS.RowHeadersWidth = 51;
            dataGridViewFunction_BYS.Size = new Size(122, 259);
            dataGridViewFunction_BYS.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 313);
            Controls.Add(groupBoxPrint_BYS);
            Controls.Add(buttonRes_BYS);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTask_BYS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 3 | Брезина Ю.С.";
            groupBoxTask_BYS.ResumeLayout(false);
            groupBoxTask_BYS.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxPrint_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BYS;
        private TextBox textBoxYsl_BYS;
        private GroupBox groupBox1;
        private TextBox textBoxStopSrep_BYS;
        private TextBox textBoxStop_BYS;
        private TextBox textBoxStartStep_BYS;
        private TextBox textBoxStart_BYS;
        private Button button1;
        private Button buttonRes_BYS;
        private GroupBox groupBoxPrint_BYS;
        private DataGridView dataGridViewFunction_BYS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYS;
    }
}
