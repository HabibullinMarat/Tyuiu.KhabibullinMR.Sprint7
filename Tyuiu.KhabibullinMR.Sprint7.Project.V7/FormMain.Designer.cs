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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_KMR = new Panel();
            buttonRedactor_KMR = new Button();
            buttonOpen_KMR = new Button();
            panelMid_KMR = new Panel();
            dataGridViewInfo_KMR = new DataGridView();
            openFileDialogTask_KMR = new OpenFileDialog();
            saveFileDialogTask_KMR = new SaveFileDialog();
            panelTop_KMR.SuspendLayout();
            panelMid_KMR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_KMR).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KMR
            // 
            panelTop_KMR.Controls.Add(buttonRedactor_KMR);
            panelTop_KMR.Controls.Add(buttonOpen_KMR);
            panelTop_KMR.Dock = DockStyle.Top;
            panelTop_KMR.Location = new Point(0, 0);
            panelTop_KMR.Name = "panelTop_KMR";
            panelTop_KMR.Size = new Size(834, 52);
            panelTop_KMR.TabIndex = 0;
            // 
            // buttonRedactor_KMR
            // 
            buttonRedactor_KMR.BackColor = Color.White;
            buttonRedactor_KMR.FlatStyle = FlatStyle.Flat;
            buttonRedactor_KMR.Image = (Image)resources.GetObject("buttonRedactor_KMR.Image");
            buttonRedactor_KMR.Location = new Point(68, 7);
            buttonRedactor_KMR.Name = "buttonRedactor_KMR";
            buttonRedactor_KMR.Size = new Size(50, 39);
            buttonRedactor_KMR.TabIndex = 0;
            buttonRedactor_KMR.UseVisualStyleBackColor = false;
            // 
            // buttonOpen_KMR
            // 
            buttonOpen_KMR.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOpen_KMR.BackColor = Color.White;
            buttonOpen_KMR.FlatStyle = FlatStyle.Flat;
            buttonOpen_KMR.Image = (Image)resources.GetObject("buttonOpen_KMR.Image");
            buttonOpen_KMR.Location = new Point(13, 7);
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
            panelMid_KMR.Size = new Size(834, 409);
            panelMid_KMR.TabIndex = 1;
            // 
            // dataGridViewInfo_KMR
            // 
            dataGridViewInfo_KMR.BackgroundColor = SystemColors.Control;
            dataGridViewInfo_KMR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInfo_KMR.Dock = DockStyle.Fill;
            dataGridViewInfo_KMR.Location = new Point(0, 0);
            dataGridViewInfo_KMR.Name = "dataGridViewInfo_KMR";
            dataGridViewInfo_KMR.ReadOnly = true;
            dataGridViewInfo_KMR.RowHeadersVisible = false;
            dataGridViewInfo_KMR.Size = new Size(834, 409);
            dataGridViewInfo_KMR.TabIndex = 0;
            // 
            // openFileDialogTask_KMR
            // 
            openFileDialogTask_KMR.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 461);
            Controls.Add(panelMid_KMR);
            Controls.Add(panelTop_KMR);
            MinimumSize = new Size(850, 500);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 7 | Проект | Вариант 7 | Хабибуллин М.Р.";
            panelTop_KMR.ResumeLayout(false);
            panelMid_KMR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInfo_KMR).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KMR;
        private Panel panelMid_KMR;
        private DataGridView dataGridViewInfo_KMR;
        private OpenFileDialog openFileDialogTask_KMR;
        private SaveFileDialog saveFileDialogTask_KMR;
        private Button buttonOpen_KMR;
        private Button buttonRedactor_KMR;
    }
}
