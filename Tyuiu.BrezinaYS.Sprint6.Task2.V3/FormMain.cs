using System.Drawing.Text;
using Tyuiu.BrezinaYS.Sprint6.Task2.V3.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task2.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ��������� ������ ����-24-2 ������� ���� ��������� ", "���������");
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_BYS.Text);
                int stopSteo = Convert.ToInt32(textBoxStopSrep_BYS.Text);
                int len = ds.GetMassFunction(startStep, stopSteo).Length;
                double[] value;
                value = new double[len];
                value = ds.GetMassFunction(startStep, stopSteo);
                this.chartFunction_BYS.Titles.Add("������ �������: ");
                this.chartFunction_BYS.ChartAreas[0].AxisX.Title = "��� �";
                this.chartFunction_BYS.ChartAreas[0].AxisY.Title = "��� Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_BYS.Rows.Add(Convert.ToString(startStep), Convert.ToString(value[i]));
                    this.chartFunction_BYS.Series[0].Points.AddXY(startStep, value[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonRes_BYS.BackColor = Color.Red;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonRes_BYS.BackColor = Color.Green;
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonRes_BYS.BackColor = Color.Blue;
        }

        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
