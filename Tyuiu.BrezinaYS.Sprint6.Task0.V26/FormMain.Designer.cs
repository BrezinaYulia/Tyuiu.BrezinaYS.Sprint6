namespace Tyuiu.BrezinaYS.Sprint6.Task0.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxTask = new TextBox();
            textBoxCondition = new TextBox();
            textBoxInput = new TextBox();
            textBoxVar = new TextBox();
            textBoxVarX = new TextBox();
            textBox1 = new TextBox();
            textBoxRes = new TextBox();
            textBoxResult = new TextBox();
            pictureBoxFormyl = new PictureBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormyl).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Cursor = Cursors.IBeam;
            textBoxTask.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(12, 36);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(329, 111);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле ";
            // 
            // textBoxCondition
            // 
            textBoxCondition.BackColor = SystemColors.Control;
            textBoxCondition.BorderStyle = BorderStyle.None;
            textBoxCondition.Font = new Font("Segoe UI", 9.2F);
            textBoxCondition.Location = new Point(12, 12);
            textBoxCondition.Multiline = true;
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.Size = new Size(125, 24);
            textBoxCondition.TabIndex = 1;
            textBoxCondition.Text = "Условие";
            textBoxCondition.TextChanged += textBoxCondition_TextChanged;
            // 
            // textBoxInput
            // 
            textBoxInput.BackColor = SystemColors.Control;
            textBoxInput.BorderStyle = BorderStyle.None;
            textBoxInput.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxInput.Location = new Point(12, 153);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(125, 26);
            textBoxInput.TabIndex = 2;
            textBoxInput.Text = "Ввод данных";
            // 
            // textBoxVar
            // 
            textBoxVar.BackColor = SystemColors.Control;
            textBoxVar.BorderStyle = BorderStyle.None;
            textBoxVar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxVar.Location = new Point(29, 176);
            textBoxVar.Multiline = true;
            textBoxVar.Name = "textBoxVar";
            textBoxVar.Size = new Size(125, 22);
            textBoxVar.TabIndex = 3;
            textBoxVar.Text = "Переменная Х:";
            textBoxVar.TextChanged += textBox2_TextChanged;
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(29, 204);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(125, 27);
            textBoxVarX.TabIndex = 4;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(307, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 26);
            textBox1.TabIndex = 5;
            textBox1.Text = "Вывод данных";
            // 
            // textBoxRes
            // 
            textBoxRes.BackColor = SystemColors.Control;
            textBoxRes.BorderStyle = BorderStyle.None;
            textBoxRes.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxRes.Location = new Point(307, 176);
            textBoxRes.Multiline = true;
            textBoxRes.Name = "textBoxRes";
            textBoxRes.Size = new Size(125, 22);
            textBoxRes.TabIndex = 6;
            textBoxRes.Text = "Результат:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Control;
            textBoxResult.Location = new Point(307, 204);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(160, 27);
            textBoxResult.TabIndex = 7;
            // 
            // pictureBoxFormyl
            // 
            pictureBoxFormyl.BackColor = SystemColors.Window;
            pictureBoxFormyl.Image = (Image)resources.GetObject("pictureBoxFormyl.Image");
            pictureBoxFormyl.Location = new Point(334, 42);
            pictureBoxFormyl.Name = "pictureBoxFormyl";
            pictureBoxFormyl.Size = new Size(125, 62);
            pictureBoxFormyl.TabIndex = 8;
            pictureBoxFormyl.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ControlDark;
            buttonDone.Location = new Point(334, 254);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(124, 41);
            buttonDone.TabIndex = 9;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(277, 254);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(51, 41);
            buttonHelp.TabIndex = 10;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(172, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 316);
            Controls.Add(checkBox1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(pictureBoxFormyl);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxRes);
            Controls.Add(textBox1);
            Controls.Add(textBoxVarX);
            Controls.Add(textBoxVar);
            Controls.Add(textBoxInput);
            Controls.Add(textBoxCondition);
            Controls.Add(textBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 26 | Брезина Ю.С.";
            Load += FormMain_Load;
            KeyPress += textBoxVarX_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormyl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTask;
        private TextBox textBoxCondition;
        private TextBox textBoxInput;
        private TextBox textBoxVar;
        private TextBox textBoxVarX;
        private TextBox textBox1;
        private TextBox textBoxRes;
        private TextBox textBoxResult;
        private PictureBox pictureBoxFormyl;
        private Button buttonDone;
        private Button buttonHelp;
        private CheckBox checkBox1;
    }
}
