namespace Tyuiu.BrezinaYS.Sprint6.Task3.V13
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
            groupBoxYslov_BYS = new GroupBox();
            textBox1 = new TextBox();
            dataGridViewStart_BYS = new DataGridView();
            groupBoxRes_BYS = new GroupBox();
            buttonDone_BYS = new Button();
            buttonHelp_BYS = new Button();
            dataGridViewRes_BYS = new DataGridView();
            groupBoxYslov_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart_BYS).BeginInit();
            groupBoxRes_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_BYS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxYslov_BYS
            // 
            groupBoxYslov_BYS.Controls.Add(textBox1);
            groupBoxYslov_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxYslov_BYS.Location = new Point(0, 4);
            groupBoxYslov_BYS.Name = "groupBoxYslov_BYS";
            groupBoxYslov_BYS.Size = new Size(196, 257);
            groupBoxYslov_BYS.TabIndex = 0;
            groupBoxYslov_BYS.TabStop = false;
            groupBoxYslov_BYS.Text = "Условие ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(5, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(185, 232);
            textBox1.TabIndex = 0;
            textBox1.Text = "Дана матрица 5 на 5\r\n -7  34  -2  25   5\r\n\r\n -16 -12  30  -3  17\r\n\r\n   3 -15  12   5  -5\r\n\r\n  17  22  -3  32 -11\r\n\r\n   9  28   1  -9  -2\r\nВыполнить сортировку по возрастанию во втором столбце.";
            // 
            // dataGridViewStart_BYS
            // 
            dataGridViewStart_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStart_BYS.Location = new Point(215, 12);
            dataGridViewStart_BYS.Name = "dataGridViewStart_BYS";
            dataGridViewStart_BYS.RowHeadersVisible = false;
            dataGridViewStart_BYS.RowHeadersWidth = 51;
            dataGridViewStart_BYS.Size = new Size(189, 249);
            dataGridViewStart_BYS.TabIndex = 1;
            // 
            // groupBoxRes_BYS
            // 
            groupBoxRes_BYS.Controls.Add(buttonDone_BYS);
            groupBoxRes_BYS.Controls.Add(buttonHelp_BYS);
            groupBoxRes_BYS.Controls.Add(dataGridViewRes_BYS);
            groupBoxRes_BYS.Location = new Point(415, 11);
            groupBoxRes_BYS.Name = "groupBoxRes_BYS";
            groupBoxRes_BYS.Size = new Size(250, 250);
            groupBoxRes_BYS.TabIndex = 2;
            groupBoxRes_BYS.TabStop = false;
            groupBoxRes_BYS.Text = "Вывод данных";
            // 
            // buttonDone_BYS
            // 
            buttonDone_BYS.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonDone_BYS.Location = new Point(93, 216);
            buttonDone_BYS.Name = "buttonDone_BYS";
            buttonDone_BYS.Size = new Size(143, 34);
            buttonDone_BYS.TabIndex = 2;
            buttonDone_BYS.Text = "Выполнить";
            buttonDone_BYS.UseVisualStyleBackColor = true;
            buttonDone_BYS.Click += buttonDone_BYS_Click;
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.Location = new Point(14, 221);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(73, 29);
            buttonHelp_BYS.TabIndex = 1;
            buttonHelp_BYS.Text = "?";
            buttonHelp_BYS.UseVisualStyleBackColor = true;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // dataGridViewRes_BYS
            // 
            dataGridViewRes_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_BYS.Location = new Point(8, 22);
            dataGridViewRes_BYS.Name = "dataGridViewRes_BYS";
            dataGridViewRes_BYS.RowHeadersWidth = 51;
            dataGridViewRes_BYS.Size = new Size(228, 188);
            dataGridViewRes_BYS.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 273);
            Controls.Add(groupBoxRes_BYS);
            Controls.Add(dataGridViewStart_BYS);
            Controls.Add(groupBoxYslov_BYS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт | Таск 3 | Вариант 13 | Брезина Ю.С.";
            Load += FormMain_Load;
            groupBoxYslov_BYS.ResumeLayout(false);
            groupBoxYslov_BYS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStart_BYS).EndInit();
            groupBoxRes_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxYslov_BYS;
        private TextBox textBox1;
        private DataGridView dataGridViewStart_BYS;
        private GroupBox groupBoxRes_BYS;
        private Button buttonDone_BYS;
        private Button buttonHelp_BYS;
        private DataGridView dataGridViewRes_BYS;
    }
}
