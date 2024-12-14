using System.Windows.Forms;
using Tyuiu.BrezinaYS.Sprint6.Task7.V7.Lib;
namespace Tyuiu.BrezinaYS.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog1.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }

        private void panelTask_BYS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRight_BYS_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_BYS.ColumnCount = 50;
            dataGridViewPrint_BYS.ColumnCount = 50;

            dataGridViewInput_BYS.RowCount = 50;
            dataGridViewPrint_BYS.RowCount = 50;
            panelLeft_BYS.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_BYS.Columns[i].Width = 35;
                dataGridViewPrint_BYS.Columns[i].Width = 35;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpen_BYS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_BYS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_BYS_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить в файл";
        }

        private void buttonHelp_BYS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonOpen_BYS_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFilePath);
            dataGridViewInput_BYS.ColumnCount = columns;
            dataGridViewInput_BYS.RowCount = rows;
            dataGridViewPrint_BYS.ColumnCount = columns;
            dataGridViewPrint_BYS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_BYS.Columns[i].Width = 35;
                dataGridViewPrint_BYS.Columns[i].Width = 35;

            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput_BYS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(LoadFromData(openFilePath));
            buttonDone_BYS.Enabled = true;


        }

        private void buttonDone_BYS_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(LoadFromData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewPrint_BYS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_BYS.Enabled = true;

        }

        private void buttonSave_BYS_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExzist = fileInfo.Exists;
            if (fileExzist)
            {
                File.Delete(path);
            }
            int rows = dataGridViewPrint_BYS.RowCount;
            int columns = dataGridViewPrint_BYS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j!= columns - 1)
                    {
                        str = str + dataGridViewPrint_BYS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewPrint_BYS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }
    }
}
