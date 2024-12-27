using Tyuiu.KhabibullinMR.Sprint7.Project.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private List<DataService> books = new List<DataService>();
        private bool cancelContextMenu = false;
        string openFilePath;
        static int rows;
        static int columns;

        public object DateTimePickerDatePublished { get; private set; }

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

            for (int l = 0; l < rows; l++)
            {
                books.Add(new DataService(Convert.ToInt32(arrayValues[l, 0]), Convert.ToInt32(arrayValues[l, 1]), Convert.ToInt32(arrayValues[l, 2]), Convert.ToInt32(arrayValues[l, 3]), Convert.ToInt32(arrayValues[l, 4]), arrayValues[l, 5], arrayValues[l, 6], Convert.ToInt32(arrayValues[l, 7]), Convert.ToInt32(arrayValues[l, 8]), Convert.ToBoolean(arrayValues[l, 9]), arrayValues[l, 10]));
            }

            UpdateButtonAddState();
            RefreshDataGridView();
        }

        private List<DataService> GetFilteredBooks()
        {
            List<DataService> result = new List<DataService>();

            string searchString = textBoxSearch_KMR.Text;

            if (searchString.Length == 0)
            {
                return books;
            }

            searchString = searchString.ToLower();

            foreach (DataService book in books)
            {
                if ((book.Surname.Length > 0 && book.Surname.ToLower().Contains(searchString)))
                {
                    result.Add(book);
                }
            }
            return result;
        }

        private void UpdateButtonAddState()
        {
            buttonAdd_KMR.Enabled = textBoxSurname_KMR.Text.Length > 0;
        }

        private void RefreshDataGridView()
        {
            dataGridViewInfo_KMR.DataSource = null;
            dataGridViewInfo_KMR.DataSource = GetFilteredBooks();

            dataGridViewInfo_KMR.Columns["NumP"].HeaderText = "Номер подъезда";
            dataGridViewInfo_KMR.Columns["NumP"].Width = 100;

            dataGridViewInfo_KMR.Columns["NumK"].HeaderText = "Номер квартиры";
            dataGridViewInfo_KMR.Columns["NumK"].Width = 100;

            dataGridViewInfo_KMR.Columns["TotalArea"].HeaderText = "Общая площадь";
            dataGridViewInfo_KMR.Columns["TotalArea"].Width = 100;

            dataGridViewInfo_KMR.Columns["UsableArea"].HeaderText = "Полезная площадь";
            dataGridViewInfo_KMR.Columns["UsableArea"].Width = 100;

            dataGridViewInfo_KMR.Columns["NumberOfRooms"].HeaderText = "Количество комнат";
            dataGridViewInfo_KMR.Columns["NumberOfRooms"].Width = 100;

            dataGridViewInfo_KMR.Columns["Surname"].HeaderText = "Фамилия";
            dataGridViewInfo_KMR.Columns["Surname"].Width = 100;

            dataGridViewInfo_KMR.Columns["TimeReg"].HeaderText = "Дата прописки";
            dataGridViewInfo_KMR.Columns["TimeReg"].Width = 100;

            dataGridViewInfo_KMR.Columns["NumOfFamMem"].HeaderText = "Кол-во членов семьи";
            dataGridViewInfo_KMR.Columns["NumOfFamMem"].Width = 100;

            dataGridViewInfo_KMR.Columns["NumOfKids"].HeaderText = "Кол-во детей";
            dataGridViewInfo_KMR.Columns["NumOfKids"].Width = 100;

            dataGridViewInfo_KMR.Columns["Arreas"].HeaderText = "Задолжность";
            dataGridViewInfo_KMR.Columns["Arreas"].Width = 100;

            dataGridViewInfo_KMR.Columns["Note"].HeaderText = "Примечание";
            dataGridViewInfo_KMR.Columns["Note"].Width = 100;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
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
            MessageBox.Show("Сохранено успешно!");
        }

        private void buttonAdd_KMR_Click(object sender, EventArgs e)
        {
            DataService ds2 = new DataService(Convert.ToInt32(textBoxNumP_KMR.Text), Convert.ToInt32(textBoxNumK_KMR.Text), Convert.ToInt32(textBoxTotalArea_KMR.Text), Convert.ToInt32(textBoxUsableArea_KMR.Text), Convert.ToInt32(textBoxNumberOfRooms_KMR.Text), textBoxSurname_KMR.Text, textBoxTimeReg_KMR.Text, Convert.ToInt32(textBoxNumOfFamMem_KMR.Text), Convert.ToInt32(textBoxNumOfKids_KMR.Text), Convert.ToBoolean(textBoxArreas_KMR.Text), textBoxNote_KMR.Text);
            books.Add(ds2);
            RefreshDataGridView();
        }

        private void dataGridViewInfo_KMR_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            DataGridViewCell cell = dataGridViewInfo_KMR[col, row];

            object cellValue = cell.Value;

            DataService book = books[row];
            switch (col)
            {
                case 0:
                    book.NumP = (int)cellValue;
                    break;
                case 1:
                    book.NumK = (int)cellValue;
                    break;
                case 2:
                    book.TotalArea = (int)cellValue;
                    break;
                case 3:
                    book.UsableArea = (int)cellValue;
                    break;
                case 4:
                    book.NumberOfRooms = (int)cellValue;
                    break;
                case 5:
                    book.Surname = (string)cellValue;
                    break;
                case 6:
                    book.TimeReg = (string)cellValue;
                    break;
                case 7:
                    book.NumOfFamMem = (int)cellValue;
                    break;
                case 8:
                    book.NumOfKids = (int)cellValue;
                    break;
                case 9:
                    book.Arreas = (bool)cellValue;
                    break;
                case 10:
                    book.Note = (string)cellValue;
                    break;
            }
        }

        private void dataGridViewInfo_KMR_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTestInfo = dataGridViewInfo_KMR.HitTest(e.X, e.Y);
                if (hitTestInfo.RowIndex >= 0 && hitTestInfo.ColumnIndex >= 0)
                {
                    dataGridViewInfo_KMR.ClearSelection();
                    dataGridViewInfo_KMR.Rows[hitTestInfo.RowIndex].Selected = true;
                    cancelContextMenu = false;
                }
                else
                {
                    cancelContextMenu = true;
                }
            }
        }

        private void contextMenuStripForGrid_KMR_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cancelContextMenu)
            {
                e.Cancel = true;
            }
        }

        private void ToolStripMenuItemRemove_KMR_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewInfo_KMR.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                DataService book = books[rowIndex];

                DialogResult dlgConfirm = MessageBox.Show("Удалить эту книгу?", "Подтвердите", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dlgConfirm == DialogResult.Yes)
                {
                    books.RemoveAt(rowIndex);
                }
            }

            RefreshDataGridView();
        }

        private void ToolStripMenuItemEdit_KMR_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewInfo_KMR.SelectedRows;

            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                int rowIndex = selectedRow.Index;

                if (rowIndex < 0)
                {
                    continue;
                }

                DataService book = books[rowIndex];

                FormRed frmEdit = new FormRed();
                frmEdit.EditedRow = book;
                frmEdit.UpdatedEvent += FrmEdit_UpdatedEvent;
                frmEdit.Show();
            }
        }
        private void FrmEdit_UpdatedEvent(DataService updatedRow)
        {
            RefreshDataGridView();
        }

        private void textBoxNumP_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxNumK_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxTotalArea_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxUsableArea_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxNumberOfRooms_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxSurname_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxTimeReg_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxNumOfFamMem_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxNumOfKids_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxArreas_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxNote_KMR_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonAddState();
        }

        private void textBoxSearch_KMR_TextChanged(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }
    }
}
