using Tyuiu.BrezinaYS.Sprint6.Task3.V13.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = { { -7, 34, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, -15, 12, 5, -5 }, { 17, 22, -3, 32, -11 }, { 9, 28, 1, -9, -2 } };
        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студентка группы ИИПб-24-2 Брезина Юлия Сергеевна ", "Сообщение");
        }
        private void buttonDone_BYS_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(matrix);
            int row = res.GetUpperBound(0) + 1;
            int col = res.Length / row;
            dataGridViewRes_BYS.ColumnCount = col;
            dataGridViewRes_BYS.RowCount = row;
            for (int i = 0; i < col; i++)
            {
                dataGridViewRes_BYS.Columns[i].Width = 35;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewRes_BYS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            dataGridViewStart_BYS.ColumnCount = cols;
            dataGridViewStart_BYS.RowCount = rows;
            for (int i = 0; i < cols; i++)
            {
                dataGridViewStart_BYS.Columns[i].Width = 35;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewStart_BYS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }
    }
}
