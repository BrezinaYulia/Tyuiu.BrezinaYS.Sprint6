namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButton_BYS = new Panel();
            buttonHelp_BYS = new Button();
            buttonSave_BYS = new Button();
            buttonDone_BYS = new Button();
            buttonOpen_BYS = new Button();
            panelTask_BYS = new Panel();
            groupBoxTask_BYS = new GroupBox();
            textBoxTAsk_BYS = new TextBox();
            panelLeft_BYS = new Panel();
            groupBoxInput_BYS = new GroupBox();
            splitter1 = new Splitter();
            dataGridViewInput_BYS = new DataGridView();
            panelRight_BYS = new Panel();
            groupBoxPrint_BYS = new GroupBox();
            dataGridViewPrint_BYS = new DataGridView();
            toolTipButton = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            panelButton_BYS.SuspendLayout();
            panelTask_BYS.SuspendLayout();
            groupBoxTask_BYS.SuspendLayout();
            panelLeft_BYS.SuspendLayout();
            groupBoxInput_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BYS).BeginInit();
            panelRight_BYS.SuspendLayout();
            groupBoxPrint_BYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrint_BYS).BeginInit();
            SuspendLayout();
            // 
            // panelButton_BYS
            // 
            panelButton_BYS.Controls.Add(buttonHelp_BYS);
            panelButton_BYS.Controls.Add(buttonSave_BYS);
            panelButton_BYS.Controls.Add(buttonDone_BYS);
            panelButton_BYS.Controls.Add(buttonOpen_BYS);
            panelButton_BYS.Dock = DockStyle.Top;
            panelButton_BYS.Location = new Point(0, 0);
            panelButton_BYS.Name = "panelButton_BYS";
            panelButton_BYS.Size = new Size(832, 85);
            panelButton_BYS.TabIndex = 0;
            // 
            // buttonHelp_BYS
            // 
            buttonHelp_BYS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonHelp_BYS.Image = (Image)resources.GetObject("buttonHelp_BYS.Image");
            buttonHelp_BYS.Location = new Point(708, 14);
            buttonHelp_BYS.Name = "buttonHelp_BYS";
            buttonHelp_BYS.Size = new Size(112, 65);
            buttonHelp_BYS.TabIndex = 3;
            toolTipButton.SetToolTip(buttonHelp_BYS, "Сведение о программме");
            buttonHelp_BYS.UseVisualStyleBackColor = false;
            buttonHelp_BYS.Click += buttonHelp_BYS_Click;
            // 
            // buttonSave_BYS
            // 
            buttonSave_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonSave_BYS.Enabled = false;
            buttonSave_BYS.Image = (Image)resources.GetObject("buttonSave_BYS.Image");
            buttonSave_BYS.Location = new Point(266, 12);
            buttonSave_BYS.Name = "buttonSave_BYS";
            buttonSave_BYS.Size = new Size(106, 67);
            buttonSave_BYS.TabIndex = 2;
            toolTipButton.SetToolTip(buttonSave_BYS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSave_BYS.UseVisualStyleBackColor = false;
            buttonSave_BYS.Click += buttonSave_BYS_Click;
            buttonSave_BYS.MouseEnter += buttonSave_BYS_MouseEnter;
            // 
            // buttonDone_BYS
            // 
            buttonDone_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonDone_BYS.Enabled = false;
            buttonDone_BYS.Image = (Image)resources.GetObject("buttonDone_BYS.Image");
            buttonDone_BYS.Location = new Point(141, 12);
            buttonDone_BYS.Name = "buttonDone_BYS";
            buttonDone_BYS.Size = new Size(111, 67);
            buttonDone_BYS.TabIndex = 1;
            toolTipButton.SetToolTip(buttonDone_BYS, "Выполнить обработку данных");
            buttonDone_BYS.UseVisualStyleBackColor = false;
            buttonDone_BYS.Click += buttonDone_BYS_Click;
            buttonDone_BYS.MouseEnter += buttonDone_BYS_MouseEnter;
            // 
            // buttonOpen_BYS
            // 
            buttonOpen_BYS.BackColor = SystemColors.ButtonHighlight;
            buttonOpen_BYS.Image = (Image)resources.GetObject("buttonOpen_BYS.Image");
            buttonOpen_BYS.Location = new Point(12, 12);
            buttonOpen_BYS.Name = "buttonOpen_BYS";
            buttonOpen_BYS.Size = new Size(116, 67);
            buttonOpen_BYS.TabIndex = 0;
            toolTipButton.SetToolTip(buttonOpen_BYS, "Открыть файл для обработки данных в формате CSV");
            buttonOpen_BYS.UseVisualStyleBackColor = false;
            buttonOpen_BYS.Click += buttonOpen_BYS_Click;
            buttonOpen_BYS.MouseEnter += buttonOpen_BYS_MouseEnter;
            // 
            // panelTask_BYS
            // 
            panelTask_BYS.Controls.Add(groupBoxTask_BYS);
            panelTask_BYS.Dock = DockStyle.Top;
            panelTask_BYS.Location = new Point(0, 85);
            panelTask_BYS.Name = "panelTask_BYS";
            panelTask_BYS.Size = new Size(832, 90);
            panelTask_BYS.TabIndex = 1;
            // 
            // groupBoxTask_BYS
            // 
            groupBoxTask_BYS.Controls.Add(textBoxTAsk_BYS);
            groupBoxTask_BYS.Dock = DockStyle.Fill;
            groupBoxTask_BYS.Location = new Point(0, 0);
            groupBoxTask_BYS.Name = "groupBoxTask_BYS";
            groupBoxTask_BYS.Size = new Size(832, 90);
            groupBoxTask_BYS.TabIndex = 0;
            groupBoxTask_BYS.TabStop = false;
            groupBoxTask_BYS.Text = "Условие ";
            groupBoxTask_BYS.Enter += groupBox1_Enter;
            // 
            // textBoxTAsk_BYS
            // 
            textBoxTAsk_BYS.BackColor = SystemColors.Control;
            textBoxTAsk_BYS.BorderStyle = BorderStyle.None;
            textBoxTAsk_BYS.Dock = DockStyle.Fill;
            textBoxTAsk_BYS.Location = new Point(3, 23);
            textBoxTAsk_BYS.Multiline = true;
            textBoxTAsk_BYS.Name = "textBoxTAsk_BYS";
            textBoxTAsk_BYS.Size = new Size(826, 64);
            textBoxTAsk_BYS.TabIndex = 0;
            textBoxTAsk_BYS.Text = resources.GetString("textBoxTAsk_BYS.Text");
            // 
            // panelLeft_BYS
            // 
            panelLeft_BYS.Controls.Add(groupBoxInput_BYS);
            panelLeft_BYS.Dock = DockStyle.Left;
            panelLeft_BYS.Location = new Point(0, 175);
            panelLeft_BYS.Name = "panelLeft_BYS";
            panelLeft_BYS.Size = new Size(478, 378);
            panelLeft_BYS.TabIndex = 2;
            // 
            // groupBoxInput_BYS
            // 
            groupBoxInput_BYS.Controls.Add(splitter1);
            groupBoxInput_BYS.Controls.Add(dataGridViewInput_BYS);
            groupBoxInput_BYS.Dock = DockStyle.Fill;
            groupBoxInput_BYS.Location = new Point(0, 0);
            groupBoxInput_BYS.Name = "groupBoxInput_BYS";
            groupBoxInput_BYS.Size = new Size(478, 378);
            groupBoxInput_BYS.TabIndex = 0;
            groupBoxInput_BYS.TabStop = false;
            groupBoxInput_BYS.Text = "Ввод";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(3, 23);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 352);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // dataGridViewInput_BYS
            // 
            dataGridViewInput_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_BYS.ColumnHeadersVisible = false;
            dataGridViewInput_BYS.Dock = DockStyle.Fill;
            dataGridViewInput_BYS.Location = new Point(3, 23);
            dataGridViewInput_BYS.Name = "dataGridViewInput_BYS";
            dataGridViewInput_BYS.RowHeadersVisible = false;
            dataGridViewInput_BYS.RowHeadersWidth = 51;
            dataGridViewInput_BYS.ScrollBars = ScrollBars.Vertical;
            dataGridViewInput_BYS.Size = new Size(472, 352);
            dataGridViewInput_BYS.TabIndex = 0;
            // 
            // panelRight_BYS
            // 
            panelRight_BYS.Controls.Add(groupBoxPrint_BYS);
            panelRight_BYS.Dock = DockStyle.Fill;
            panelRight_BYS.Location = new Point(478, 175);
            panelRight_BYS.Name = "panelRight_BYS";
            panelRight_BYS.Size = new Size(354, 378);
            panelRight_BYS.TabIndex = 3;
            // 
            // groupBoxPrint_BYS
            // 
            groupBoxPrint_BYS.Controls.Add(dataGridViewPrint_BYS);
            groupBoxPrint_BYS.Dock = DockStyle.Fill;
            groupBoxPrint_BYS.Location = new Point(0, 0);
            groupBoxPrint_BYS.Name = "groupBoxPrint_BYS";
            groupBoxPrint_BYS.Size = new Size(354, 378);
            groupBoxPrint_BYS.TabIndex = 0;
            groupBoxPrint_BYS.TabStop = false;
            groupBoxPrint_BYS.Text = "Вывод";
            // 
            // dataGridViewPrint_BYS
            // 
            dataGridViewPrint_BYS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrint_BYS.ColumnHeadersVisible = false;
            dataGridViewPrint_BYS.Dock = DockStyle.Fill;
            dataGridViewPrint_BYS.Location = new Point(3, 23);
            dataGridViewPrint_BYS.Name = "dataGridViewPrint_BYS";
            dataGridViewPrint_BYS.RowHeadersVisible = false;
            dataGridViewPrint_BYS.RowHeadersWidth = 51;
            dataGridViewPrint_BYS.ScrollBars = ScrollBars.Vertical;
            dataGridViewPrint_BYS.Size = new Size(348, 352);
            dataGridViewPrint_BYS.TabIndex = 0;
            // 
            // toolTipButton
            // 
            toolTipButton.ForeColor = SystemColors.Highlight;
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 553);
            Controls.Add(panelRight_BYS);
            Controls.Add(panelLeft_BYS);
            Controls.Add(panelTask_BYS);
            Controls.Add(panelButton_BYS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Брезина Ю.С.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelButton_BYS.ResumeLayout(false);
            panelTask_BYS.ResumeLayout(false);
            groupBoxTask_BYS.ResumeLayout(false);
            groupBoxTask_BYS.PerformLayout();
            panelLeft_BYS.ResumeLayout(false);
            groupBoxInput_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_BYS).EndInit();
            panelRight_BYS.ResumeLayout(false);
            groupBoxPrint_BYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrint_BYS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButton_BYS;
        private Panel panelTask_BYS;
        private GroupBox groupBoxTask_BYS;
        private TextBox textBoxTAsk_BYS;
        private Panel panelLeft_BYS;
        private GroupBox groupBoxInput_BYS;
        private Panel panelRight_BYS;
        private GroupBox groupBoxPrint_BYS;
        private Button buttonOpen_BYS;
        private Button buttonSave_BYS;
        private Button buttonDone_BYS;
        private ToolTip toolTipButton;
        private Button buttonHelp_BYS;
        private Splitter splitter1;
        private DataGridView dataGridViewInput_BYS;
        private DataGridView dataGridViewPrint_BYS;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
