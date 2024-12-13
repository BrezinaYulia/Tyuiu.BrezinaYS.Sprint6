using Tyuiu.BrezinaYS.Sprint6.Task5.V24.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V24.txt";
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void buttonDone_BYS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_BYS.ColumnCount = 2;
            dataGridViewNums_BYS.Columns[0].Width = 20;
            dataGridViewNums_BYS.Columns[1].Width = 50;

            this.chartFunction_BYS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BYS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_BYS.Series[0].Points.Clear();
            double[] num = new double[ds.len];
            num = ds.LoadFromDataFile(path);

            for (int i = 0; i <num.Length; i++)
            {
                dataGridViewNums_BYS.Rows.Add(Convert.ToString(i), Convert.ToString(num[i]));
                chartFunction_BYS.Series[0].Points.AddXY(i, num[i]);
            }

        }
        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студентка группы ИИПб-24-2 Брезина Юлия Сергеевна ", "Сообщение");
        }
        private void buttonOpen_BYS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
