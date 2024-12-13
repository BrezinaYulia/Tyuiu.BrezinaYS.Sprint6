using Tyuiu.BrezinaYS.Sprint6.Task4.V2.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task4.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студентка группы ИИПб-24-2 Брезина Юлия Сергеевна ", "Сообщение");
        }
        private void buttonDone_BYS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BYS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BYS.Text);
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] value;
                value = new double[len];
                value = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction_BYS.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_BYS.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_BYS.Text = "";
                chartFunction_BYS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_BYS.Series[0].Points.AddXY(startStep, value[i]);
                    textBoxRes_BYS.AppendText(value[i] + Environment.NewLine);
                    startStep++;

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask4V2.txt");
                File.WriteAllText(path, textBoxRes_BYS.Text);

                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно! \n Открыть его в болкноте? ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
