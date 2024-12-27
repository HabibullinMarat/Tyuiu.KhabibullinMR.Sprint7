namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
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
            panelTop_KMR = new Panel();
            textBoxSearch_KMR = new TextBox();
            labelSearch_KMR = new Label();
            buttonSave_KMR = new Button();
            buttonOpen_KMR = new Button();
            panelMid_KMR = new Panel();
            dataGridViewInfo_KMR = new DataGridView();
            contextMenuStripForGrid_KMR = new ContextMenuStrip(components);
            ToolStripMenuItemRemove_KMR = new ToolStripMenuItem();
            ToolStripMenuItemEdit_KMR = new ToolStripMenuItem();
            openFileDialogTask_KMR = new OpenFileDialog();
            saveFileDialogTask_KMR = new SaveFileDialog();
            panelDown_KMR = new Panel();
            groupBoxAdd_KMR = new GroupBox();
            buttonAdd_KMR = new Button();
            textBoxNote_KMR = new TextBox();
            label22 = new Label();
            label21 = new Label();
            textBoxArreas_KMR = new TextBox();
            textBoxNumOfKids_KMR = new TextBox();
            label20 = new Label();
            textBoxNumOfFamMem_KMR = new TextBox();
            labelNumOfFamMes = new Label();
            labelTimaReg_KMR = new Label();
            textBoxSurname_KMR = new TextBox();
            labelSurname_KMR = new Label();
            textBoxTimeReg_KMR = new TextBox();
            textBoxNumberOfRooms_KMR = new TextBox();
            labelNumberOfRooms_KMR = new Label();
            textBoxUsableArea_KMR = new TextBox();
            labelUsableArea_KMR = new Label();
            textBoxTotalArea_KMR = new TextBox();
            labelTotalArea_KMR = new Label();
            textBoxNumK_KMR = new TextBox();
            labelNumPod_KMR = new Label();
            labelNumK_KMR = new Label();
            textBoxNumP_KMR = new TextBox();
            panelTop_KMR.SuspendLayout();
            panelMid_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_KMR).BeginInit();
            contextMenuStripForGrid_KMR.SuspendLayout();
            panelDown_KMR.SuspendLayout();
            groupBoxAdd_KMR.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(textBoxSearch_KMR);
            panelTop_KMR.Controls.Add(labelSearch_KMR);
            panelTop_KMR.Controls.Add(buttonSave_KMR);
            panelTop_KMR.Controls.Add(buttonOpen_KMR);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(1284, 52);
            panelTop_KMR.TabIndex = 0;
            // 
            // textBoxSearch_KMR
            // 
            textBoxSearch_KMR.Location = new Point(258, 16);
            textBoxSearch_KMR.Name = "textBoxSearch_KMR";
            textBoxSearch_KMR.Size = new Size(564, 23);
            textBoxSearch_KMR.TabIndex = 2;
            textBoxSearch_KMR.TextChanged += textBoxSearch_KMR_TextChanged;
            // 
            // labelSearch_KMR
            // 
            labelSearch_KMR.AutoSize = true;
            labelSearch_KMR.Location = new Point(135, 19);
            labelSearch_KMR.Name = "labelSearch_KMR";
            labelSearch_KMR.Size = new Size(117, 15);
            labelSearch_KMR.TabIndex = 1;
            labelSearch_KMR.Text = "Поиск по фамилии:";
            // 
            // buttonSave_KMR
            // 
            buttonSave_KMR.BackColor = Color.White;
            buttonSave_KMR.FlatStyle = FlatStyle.Flat;
            buttonSave_KMR.Image = (Image)resources.GetObject("buttonSave_KMR.Image");
            buttonSave_KMR.Location = new Point(68, 7);
            buttonSave_KMR.Name = "buttonSave_KMR";
            buttonSave_KMR.Size = new Size(50, 39);
            buttonSave_KMR.TabIndex = 0;
            buttonSave_KMR.UseVisualStyleBackColor = false;
            buttonSave_KMR.Click += buttonSave_Click;
            // 
            // buttonOpen_KMR
            // 
            buttonOpen_KMR.BackColor = Color.White;
            buttonOpen_KMR.FlatStyle = FlatStyle.Flat;
            buttonOpen_KMR.Image = (Image)resources.GetObject("buttonOpen_KMR.Image");
            buttonOpen_KMR.Location = new Point(12, 7);
            buttonOpen_KMR.Name = "buttonOpen_KMR";
            buttonOpen_KMR.Size = new Size(50, 39);
            buttonOpen_KMR.TabIndex = 0;
            buttonOpen_KMR.UseVisualStyleBackColor = false;
            buttonOpen_KMR.Click += buttonOpen_Click;
            // 
            // panelMid_KMR
            // 
            panelMid_KMR.Controls.Add(dataGridViewInfo_KMR);
            panelMid_KMR.Dock = DockStyle.Fill;
            panelMid_KMR.Location = new Point(0, 52);
            panelMid_KMR.Name = "panelMid_KMR";
            panelMid_KMR.Size = new Size(1284, 509);
            panelMid_KMR.TabIndex = 1;
            // 
            // dataGridViewInfo_KMR
            // 
            dataGridViewInfo_KMR.BackgroundColor = SystemColors.Control;
            dataGridViewInfo_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_KMR.ContextMenuStrip = contextMenuStripForGrid_KMR;
            dataGridViewInfo_KMR.Location = new Point(0, 6);
            dataGridViewInfo_KMR.Name = "dataGridViewInfo_KMR";
            dataGridViewInfo_KMR.ReadOnly = true;
            dataGridViewInfo_KMR.RowHeadersVisible = false;
            dataGridViewInfo_KMR.Size = new Size(1272, 403);
            dataGridViewInfo_KMR.TabIndex = 0;
            dataGridViewInfo_KMR.CellEndEdit += dataGridViewInfo_KMR_CellEndEdit;
            dataGridViewInfo_KMR.MouseDown += dataGridViewInfo_KMR_MouseDown;
            // 
            // contextMenuStripForGrid_KMR
            // 
            contextMenuStripForGrid_KMR.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemRemove_KMR, ToolStripMenuItemEdit_KMR });
            contextMenuStripForGrid_KMR.Name = "contextMenuStripForGrid_KMR";
            contextMenuStripForGrid_KMR.Size = new Size(155, 48);
            contextMenuStripForGrid_KMR.Opening += contextMenuStripForGrid_KMR_Opening;
            // 
            // ToolStripMenuItemRemove_KMR
            // 
            ToolStripMenuItemRemove_KMR.Name = "ToolStripMenuItemRemove_KMR";
            ToolStripMenuItemRemove_KMR.Size = new Size(154, 22);
            ToolStripMenuItemRemove_KMR.Text = "Удалить";
            ToolStripMenuItemRemove_KMR.Click += ToolStripMenuItemRemove_KMR_Click;
            // 
            // ToolStripMenuItemEdit_KMR
            // 
            ToolStripMenuItemEdit_KMR.Name = "ToolStripMenuItemEdit_KMR";
            ToolStripMenuItemEdit_KMR.Size = new Size(154, 22);
            ToolStripMenuItemEdit_KMR.Text = "Редактировать";
            ToolStripMenuItemEdit_KMR.Click += ToolStripMenuItemEdit_KMR_Click;
            // 
            // openFileDialogTask_KMR
            // 
            openFileDialogTask_KMR.FileName = "openFileDialog1";
            // 
            // panelDown_KMR
            // 
            panelDown_KMR.Controls.Add(groupBoxAdd_KMR);
            panelDown_KMR.Dock = DockStyle.Bottom;
            panelDown_KMR.Location = new Point(0, 490);
            panelDown_KMR.Name = "panelDown_KMR";
            panelDown_KMR.Size = new Size(1284, 71);
            panelDown_KMR.TabIndex = 3;
            // 
            // groupBoxAdd_KMR
            // 
            groupBoxAdd_KMR.Controls.Add(buttonAdd_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxNote_KMR);
            groupBoxAdd_KMR.Controls.Add(label22);
            groupBoxAdd_KMR.Controls.Add(label21);
            groupBoxAdd_KMR.Controls.Add(textBoxArreas_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxNumOfKids_KMR);
            groupBoxAdd_KMR.Controls.Add(label20);
            groupBoxAdd_KMR.Controls.Add(textBoxNumOfFamMem_KMR);
            groupBoxAdd_KMR.Controls.Add(labelNumOfFamMes);
            groupBoxAdd_KMR.Controls.Add(labelTimaReg_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxSurname_KMR);
            groupBoxAdd_KMR.Controls.Add(labelSurname_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxTimeReg_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxNumberOfRooms_KMR);
            groupBoxAdd_KMR.Controls.Add(labelNumberOfRooms_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxUsableArea_KMR);
            groupBoxAdd_KMR.Controls.Add(labelUsableArea_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxTotalArea_KMR);
            groupBoxAdd_KMR.Controls.Add(labelTotalArea_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxNumK_KMR);
            groupBoxAdd_KMR.Controls.Add(labelNumPod_KMR);
            groupBoxAdd_KMR.Controls.Add(labelNumK_KMR);
            groupBoxAdd_KMR.Controls.Add(textBoxNumP_KMR);
            groupBoxAdd_KMR.Dock = DockStyle.Fill;
            groupBoxAdd_KMR.Location = new Point(0, 0);
            groupBoxAdd_KMR.Name = "groupBoxAdd_KMR";
            groupBoxAdd_KMR.Size = new Size(1284, 71);
            groupBoxAdd_KMR.TabIndex = 0;
            groupBoxAdd_KMR.TabStop = false;
            groupBoxAdd_KMR.Text = "Добавить строку:";
            // 
            // buttonAdd_KMR
            // 
            buttonAdd_KMR.Image = (Image)resources.GetObject("buttonAdd_KMR.Image");
            buttonAdd_KMR.Location = new Point(1228, 16);
            buttonAdd_KMR.Name = "buttonAdd_KMR";
            buttonAdd_KMR.Size = new Size(53, 49);
            buttonAdd_KMR.TabIndex = 5;
            buttonAdd_KMR.UseVisualStyleBackColor = true;
            buttonAdd_KMR.Click += buttonAdd_KMR_Click;
            // 
            // textBoxNote_KMR
            // 
            textBoxNote_KMR.Location = new Point(1139, 36);
            textBoxNote_KMR.Multiline = true;
            textBoxNote_KMR.Name = "textBoxNote_KMR";
            textBoxNote_KMR.Size = new Size(78, 23);
            textBoxNote_KMR.TabIndex = 3;
            textBoxNote_KMR.TextChanged += textBoxNote_KMR_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1139, 18);
            label22.Name = "label22";
            label22.Size = new Size(78, 15);
            label22.TabIndex = 2;
            label22.Text = "Примечание";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1053, 18);
            label21.Name = "label21";
            label21.Size = new Size(80, 15);
            label21.TabIndex = 2;
            label21.Text = "Задолжность";
            // 
            // textBoxArreas_KMR
            // 
            textBoxArreas_KMR.Location = new Point(1053, 37);
            textBoxArreas_KMR.Name = "textBoxArreas_KMR";
            textBoxArreas_KMR.Size = new Size(80, 23);
            textBoxArreas_KMR.TabIndex = 3;
            textBoxArreas_KMR.TextChanged += textBoxArreas_KMR_TextChanged;
            // 
            // textBoxNumOfKids_KMR
            // 
            textBoxNumOfKids_KMR.Location = new Point(947, 37);
            textBoxNumOfKids_KMR.Name = "textBoxNumOfKids_KMR";
            textBoxNumOfKids_KMR.Size = new Size(100, 23);
            textBoxNumOfKids_KMR.TabIndex = 3;
            textBoxNumOfKids_KMR.TextChanged += textBoxNumOfKids_KMR_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(947, 18);
            label20.Name = "label20";
            label20.Size = new Size(79, 15);
            label20.TabIndex = 2;
            label20.Text = "Кол-во детей";
            // 
            // textBoxNumOfFamMem_KMR
            // 
            textBoxNumOfFamMem_KMR.Location = new Point(815, 36);
            textBoxNumOfFamMem_KMR.Name = "textBoxNumOfFamMem_KMR";
            textBoxNumOfFamMem_KMR.Size = new Size(126, 23);
            textBoxNumOfFamMem_KMR.TabIndex = 3;
            textBoxNumOfFamMem_KMR.TextChanged += textBoxNumOfFamMem_KMR_TextChanged;
            // 
            // labelNumOfFamMes
            // 
            labelNumOfFamMes.AutoSize = true;
            labelNumOfFamMes.Location = new Point(815, 18);
            labelNumOfFamMes.Name = "labelNumOfFamMes";
            labelNumOfFamMes.Size = new Size(126, 15);
            labelNumOfFamMes.TabIndex = 2;
            labelNumOfFamMes.Text = "Кол-во членов семьи";
            // 
            // labelTimaReg_KMR
            // 
            labelTimaReg_KMR.AutoSize = true;
            labelTimaReg_KMR.Location = new Point(720, 18);
            labelTimaReg_KMR.Name = "labelTimaReg_KMR";
            labelTimaReg_KMR.Size = new Size(89, 15);
            labelTimaReg_KMR.TabIndex = 2;
            labelTimaReg_KMR.Text = "Дата прописки";
            // 
            // textBoxSurname_KMR
            // 
            textBoxSurname_KMR.Location = new Point(544, 36);
            textBoxSurname_KMR.Name = "textBoxSurname_KMR";
            textBoxSurname_KMR.Size = new Size(170, 23);
            textBoxSurname_KMR.TabIndex = 3;
            textBoxSurname_KMR.TextChanged += textBoxSurname_KMR_TextChanged;
            // 
            // labelSurname_KMR
            // 
            labelSurname_KMR.AutoSize = true;
            labelSurname_KMR.Location = new Point(544, 18);
            labelSurname_KMR.Name = "labelSurname_KMR";
            labelSurname_KMR.Size = new Size(170, 15);
            labelSurname_KMR.TabIndex = 2;
            labelSurname_KMR.Text = "Фамилия квартиросъемщика";
            // 
            // textBoxTimeReg_KMR
            // 
            textBoxTimeReg_KMR.Location = new Point(720, 37);
            textBoxTimeReg_KMR.Name = "textBoxTimeReg_KMR";
            textBoxTimeReg_KMR.Size = new Size(89, 23);
            textBoxTimeReg_KMR.TabIndex = 3;
            textBoxTimeReg_KMR.TextChanged += textBoxTimeReg_KMR_TextChanged;
            // 
            // textBoxNumberOfRooms_KMR
            // 
            textBoxNumberOfRooms_KMR.Location = new Point(438, 36);
            textBoxNumberOfRooms_KMR.Name = "textBoxNumberOfRooms_KMR";
            textBoxNumberOfRooms_KMR.Size = new Size(100, 23);
            textBoxNumberOfRooms_KMR.TabIndex = 3;
            textBoxNumberOfRooms_KMR.TextChanged += textBoxNumberOfRooms_KMR_TextChanged;
            // 
            // labelNumberOfRooms_KMR
            // 
            labelNumberOfRooms_KMR.AutoSize = true;
            labelNumberOfRooms_KMR.Location = new Point(435, 18);
            labelNumberOfRooms_KMR.Name = "labelNumberOfRooms_KMR";
            labelNumberOfRooms_KMR.Size = new Size(89, 15);
            labelNumberOfRooms_KMR.TabIndex = 2;
            labelNumberOfRooms_KMR.Text = "Кол-во комнат";
            // 
            // textBoxUsableArea_KMR
            // 
            textBoxUsableArea_KMR.Location = new Point(319, 36);
            textBoxUsableArea_KMR.Name = "textBoxUsableArea_KMR";
            textBoxUsableArea_KMR.Size = new Size(100, 23);
            textBoxUsableArea_KMR.TabIndex = 3;
            textBoxUsableArea_KMR.TextChanged += textBoxUsableArea_KMR_TextChanged;
            // 
            // labelUsableArea_KMR
            // 
            labelUsableArea_KMR.AutoSize = true;
            labelUsableArea_KMR.Location = new Point(316, 18);
            labelUsableArea_KMR.Name = "labelUsableArea_KMR";
            labelUsableArea_KMR.Size = new Size(113, 15);
            labelUsableArea_KMR.TabIndex = 2;
            labelUsableArea_KMR.Text = "Полезная площадь";
            // 
            // textBoxTotalArea_KMR
            // 
            textBoxTotalArea_KMR.Location = new Point(218, 36);
            textBoxTotalArea_KMR.Name = "textBoxTotalArea_KMR";
            textBoxTotalArea_KMR.Size = new Size(95, 23);
            textBoxTotalArea_KMR.TabIndex = 3;
            textBoxTotalArea_KMR.TextChanged += textBoxTotalArea_KMR_TextChanged;
            // 
            // labelTotalArea_KMR
            // 
            labelTotalArea_KMR.AutoSize = true;
            labelTotalArea_KMR.Location = new Point(215, 18);
            labelTotalArea_KMR.Name = "labelTotalArea_KMR";
            labelTotalArea_KMR.Size = new Size(99, 15);
            labelTotalArea_KMR.TabIndex = 2;
            labelTotalArea_KMR.Text = "Общая площадь";
            // 
            // textBoxNumK_KMR
            // 
            textBoxNumK_KMR.Location = new Point(112, 37);
            textBoxNumK_KMR.Name = "textBoxNumK_KMR";
            textBoxNumK_KMR.Size = new Size(100, 23);
            textBoxNumK_KMR.TabIndex = 3;
            textBoxNumK_KMR.TextChanged += textBoxNumK_KMR_TextChanged;
            // 
            // labelNumPod_KMR
            // 
            labelNumPod_KMR.AutoSize = true;
            labelNumPod_KMR.Location = new Point(6, 19);
            labelNumPod_KMR.Name = "labelNumPod_KMR";
            labelNumPod_KMR.Size = new Size(98, 15);
            labelNumPod_KMR.TabIndex = 2;
            labelNumPod_KMR.Text = "Номер подъезда";
            // 
            // labelNumK_KMR
            // 
            labelNumK_KMR.AutoSize = true;
            labelNumK_KMR.Location = new Point(109, 19);
            labelNumK_KMR.Name = "labelNumK_KMR";
            labelNumK_KMR.Size = new Size(101, 15);
            labelNumK_KMR.TabIndex = 2;
            labelNumK_KMR.Text = "Номер квартиры";
            // 
            // textBoxNumP_KMR
            // 
            textBoxNumP_KMR.Location = new Point(6, 37);
            textBoxNumP_KMR.Name = "textBoxNumP_KMR";
            textBoxNumP_KMR.Size = new Size(100, 23);
            textBoxNumP_KMR.TabIndex = 3;
            textBoxNumP_KMR.TextChanged += textBoxNumP_KMR_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 561);
            Controls.Add(panelDown_KMR);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelTop_KMR);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(850, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 7 | Хабибуллин М.Р.";
            panelTop_KMR.ResumeLayout(false);
            panelTop_KMR.PerformLayout();
            panelMid_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_KMR).EndInit();
            contextMenuStripForGrid_KMR.ResumeLayout(false);
            panelDown_KMR.ResumeLayout(false);
            groupBoxAdd_KMR.ResumeLayout(false);
            groupBoxAdd_KMR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private Panel panelMid_KMR;
        private DataGridView dataGridViewInfo_KMR;
        private OpenFileDialog openFileDialogTask_KMR;
        private SaveFileDialog saveFileDialogTask_KMR;
        private Button buttonOpen_KMR;
        private Label labelNumP_KMR;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private ContextMenuStrip contextMenuStripForGrid_KMR;
        private ToolStripMenuItem ToolStripMenuItemRemove_KMR;
        private ToolStripMenuItem ToolStripMenuItemEdit_KMR;
        private TextBox textBoxSearch_KMR;
        private Label labelSearch_KMR;
        private Button buttonSave_KMR;
        private Panel panelDown_KMR;
        private GroupBox groupBoxAdd_KMR;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBoxNumK_KMR;
        private Label labelNumK_KMR;
        private TextBox textBoxNumP_KMR;
        private TextBox textBoxNote_KMR;
        private Label label22;
        private Label label21;
        private TextBox textBoxNumOfKids_KMR;
        private Label label20;
        private TextBox textBoxNumOfFamMem_KMR;
        private Label labelNumOfFamMes;
        private Label labelTimaReg_KMR;
        private TextBox textBoxSurname_KMR;
        private Label labelSurname_KMR;
        private TextBox textBoxNumberOfRooms_KMR;
        private Label labelNumberOfRooms_KMR;
        private TextBox textBoxUsableArea_KMR;
        private Label labelUsableArea_KMR;
        private TextBox textBoxTotalArea_KMR;
        private Label labelTotalArea_KMR;
        private TextBox textBoxArreas_KMR;
        private Button buttonAdd_KMR;
        private Label labelNumPod_KMR;
        private TextBox textBoxTimeReg_KMR;
    }
}
