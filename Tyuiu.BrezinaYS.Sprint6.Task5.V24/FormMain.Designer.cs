namespace Tyuiu.BrezinaYS.Sprint6.Task5.V24
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
            buttonOpen_BYS = new Button();
            buttonDone_BYS = new Button();
            groupBoxTask_BYS = new GroupBox();
            textBoxTask_BYS = new TextBox();
            panelLeft_BYS = new Panel();
            groupBoxPrint_BYS = new GroupBox();
            dataGridViewNums_BYS = new DataGridView();
            panelRight_BYS = new Panel();
            chartFunction_BYS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelUp_BYS.SuspendLayout();
            groupBoxTask_BYS.SuspendLayout();
            panelLeft_BYS.SuspendLayout();
            groupBoxPrint_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BYS).BeginInit();
            panelRight_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).BeginInit();
            SuspendLayout();
            // 
            // panelUp_BYS
            // 
            panelUp_BYS.Controls.Add(buttonHelp_BYS);
            panelUp_BYS.Controls.Add(buttonOpen_BYS);
            panelUp_BYS.Controls.Add(buttonDone_BYS);
            panelUp_BYS.Controls.Add(groupBoxTask_BYS);
            panelUp_BYS.Dock = DockStyle.Top;
            panelUp_BYS.Location = new Point(0, 0);
            panelUp_BYS.Name = "panelUp_BYS";
            panelUp_BYS.Size = new Size(800, 89);
            panelUp_BYS.TabIndex = 0;
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.BackColor = Color.FromArgb(255, 128, 255);
            buttonHelp_BYS.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonHelp_BYS.Location = new Point(700, 23);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(88, 54);
            buttonHelp_BYS.TabIndex = 3;
            buttonHelp_BYS.Text = "Справка";
            buttonHelp_BYS.UseVisualStyleBackColor = false;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // buttonOpen_BYS
            // 
            buttonOpen_BYS.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpen_BYS.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOpen_BYS.Location = new Point(600, 22);
            buttonOpen_BYS.Name = "buttonOpen_BYS";
            buttonOpen_BYS.Size = new Size(94, 55);
            buttonOpen_BYS.TabIndex = 2;
            buttonOpen_BYS.Text = "Открыть файл";
            buttonOpen_BYS.UseVisualStyleBackColor = false;
            buttonOpen_BYS.Click += buttonOpen_BYS_Click;
            // 
            // buttonDone_BYS
            // 
            buttonDone_BYS.BackColor = Color.FromArgb(128, 255, 255);
            buttonDone_BYS.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone_BYS.Location = new Point(503, 22);
            buttonDone_BYS.Name = "buttonDone_BYS";
            buttonDone_BYS.Size = new Size(91, 55);
            buttonDone_BYS.TabIndex = 1;
            buttonDone_BYS.Text = "Выполнить ";
            buttonDone_BYS.UseVisualStyleBackColor = false;
            buttonDone_BYS.Click += buttonDone_BYS_Click;
            // 
            // groupBoxTask_BYS
            // 
            groupBoxTask_BYS.Controls.Add(textBoxTask_BYS);
            groupBoxTask_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTask_BYS.Location = new Point(3, 6);
            groupBoxTask_BYS.Name = "groupBoxTask_BYS";
            groupBoxTask_BYS.Size = new Size(494, 77);
            groupBoxTask_BYS.TabIndex = 0;
            groupBoxTask_BYS.TabStop = false;
            groupBoxTask_BYS.Text = "Условие:";
            // 
            // textBoxTask_BYS
            // 
            textBoxTask_BYS.BackColor = SystemColors.Control;
            textBoxTask_BYS.BorderStyle = BorderStyle.None;
            textBoxTask_BYS.Location = new Point(17, 20);
            textBoxTask_BYS.Multiline = true;
            textBoxTask_BYS.Name = "textBoxTask_BYS";
            textBoxTask_BYS.ReadOnly = true;
            textBoxTask_BYS.Size = new Size(473, 51);
            textBoxTask_BYS.TabIndex = 0;
            textBoxTask_BYS.Text = "Прочитать данные из файла. Вывести в dstsGridView значения равные 0. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_BYS
            // 
            panelLeft_BYS.Controls.Add(groupBoxPrint_BYS);
            panelLeft_BYS.Dock = DockStyle.Left;
            panelLeft_BYS.Location = new Point(0, 89);
            panelLeft_BYS.Name = "panelLeft_BYS";
            panelLeft_BYS.Size = new Size(198, 384);
            panelLeft_BYS.TabIndex = 1;
            // 
            // groupBoxPrint_BYS
            // 
            groupBoxPrint_BYS.Controls.Add(dataGridViewNums_BYS);
            groupBoxPrint_BYS.Dock = DockStyle.Left;
            groupBoxPrint_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxPrint_BYS.Location = new Point(0, 0);
            groupBoxPrint_BYS.Name = "groupBoxPrint_BYS";
            groupBoxPrint_BYS.Size = new Size(198, 384);
            groupBoxPrint_BYS.TabIndex = 0;
            groupBoxPrint_BYS.TabStop = false;
            groupBoxPrint_BYS.Text = "Вывод данных:";
            groupBoxPrint_BYS.Enter += groupBox1_Enter;
            // 
            // dataGridViewNums_BYS
            // 
            dataGridViewNums_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_BYS.ColumnHeadersVisible = false;
            dataGridViewNums_BYS.Dock = DockStyle.Left;
            dataGridViewNums_BYS.Location = new Point(3, 21);
            dataGridViewNums_BYS.Name = "dataGridViewNums_BYS";
            dataGridViewNums_BYS.RowHeadersVisible = false;
            dataGridViewNums_BYS.RowHeadersWidth = 51;
            dataGridViewNums_BYS.Size = new Size(189, 360);
            dataGridViewNums_BYS.TabIndex = 0;
            // 
            // panelRight_BYS
            // 
            panelRight_BYS.Controls.Add(chartFunction_BYS);
            panelRight_BYS.Dock = DockStyle.Fill;
            panelRight_BYS.Location = new Point(198, 89);
            panelRight_BYS.Name = "panelRight_BYS";
            panelRight_BYS.Size = new Size(602, 384);
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
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BYS.Series.Add(series1);
            chartFunction_BYS.Size = new Size(602, 384);
            chartFunction_BYS.TabIndex = 0;
            chartFunction_BYS.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(panelRight_BYS);
            Controls.Add(panelLeft_BYS);
            Controls.Add(panelUp_BYS);
            MinimumSize = new Size(818, 520);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 24 | Брезина Ю.С.";
            panelUp_BYS.ResumeLayout(false);
            groupBoxTask_BYS.ResumeLayout(false);
            groupBoxTask_BYS.PerformLayout();
            panelLeft_BYS.ResumeLayout(false);
            groupBoxPrint_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_BYS).EndInit();
            panelRight_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp_BYS;
        private GroupBox groupBoxTask_BYS;
        private TextBox textBoxTask_BYS;
        private Panel panelLeft_BYS;
        private Panel panelRight_BYS;
        private GroupBox groupBoxPrint_BYS;
        private Button buttonHelp_BYS;
        private Button buttonOpen_BYS;
        private Button buttonDone_BYS;
        private DataGridView dataGridViewNums_BYS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYS;
    }
}
