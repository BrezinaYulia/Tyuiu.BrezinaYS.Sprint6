using Tyuiu.BrezinaYS.Sprint6.Task1.V28.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task1.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxStartStep_BYS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSt_BYS_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonDone_BYS_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_BYS.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_BYS.Text);
                string strLine;
                double[] valueArray;
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxRes_BYS.Text = "";
                textBoxRes_BYS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxRes_BYS.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxRes_BYS.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len -1;i++)
                {
                    strLine = String.Format("|{0,5:d}   | {1,5:f2}  |", startValue, valueArray[i]);
                    textBoxRes_BYS.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxRes_BYS.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студентка группы ИИПб-24-2 Брезина Юлия Сергеевна ", "Сообщение");
        }
    }
}
