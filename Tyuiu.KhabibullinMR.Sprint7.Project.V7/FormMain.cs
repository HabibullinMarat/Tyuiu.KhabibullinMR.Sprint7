using Tyuiu.KhabibullinMR.Sprint7.Project.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        static int rows;
        static int columns;

        public static string[,] LoadFromFileData(string efilePath)
        {
            string fileData = File.ReadAllText(efilePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] arrayValues = new string[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {   
                    arrayValues[r, c] = line_r[c];
                }
            }
            return arrayValues;

        }

        public void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KMR.ShowDialog();
            openFilePath = openFileDialogTask_KMR.FileName;

            string[,] arrayValues = new string[rows, columns];
            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInfo_KMR.ColumnCount = columns;
            dataGridViewInfo_KMR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInfo_KMR.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInfo_KMR.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_KMR.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_KMR.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask_KMR.ShowDialog();

            string path = openFilePath;

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewInfo_KMR.RowCount;
            int columns = dataGridViewInfo_KMR.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewInfo_KMR.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewInfo_KMR.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        public void buttonRedactor_Click(object sender, EventArgs e)
        {
            FormRed formAbout = new FormRed();
            formAbout.ShowDialog();


        }
    }
}
