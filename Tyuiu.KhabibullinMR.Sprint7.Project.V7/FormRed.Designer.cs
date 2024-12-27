namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    partial class FormRed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxNumP_KMR = new TextBox();
            dataServiceBindingSource_KMR = new BindingSource(components);
            textBoxNumK_KMR = new TextBox();
            textBoxTotalArea_KMR = new TextBox();
            textBoxUsableArea_KMR = new TextBox();
            textBoxNumberOfRooms_KMR = new TextBox();
            textBoxSurname_KMR = new TextBox();
            textBoxNumOfFamMem_KMR = new TextBox();
            textBoxNumOfKids_KMR = new TextBox();
            textBoxArreas_KMR = new TextBox();
            textBoxNote_KMR = new TextBox();
            buttonOK_KMR = new Button();
            buttonCancel_KMR = new Button();
            textBoxTimeReg_KMR = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource_KMR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Номер подъезда";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 0;
            label2.Text = "Номер квартиры";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 128);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 0;
            label3.Text = "Общая площадь";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 236);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 0;
            label4.Text = "Кол-во комнат";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 183);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 0;
            label5.Text = "Полезная площадь";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 19);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 0;
            label6.Text = "Дата прописки";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 293);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 0;
            label7.Text = "Фамилия";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(153, 73);
            label8.Name = "label8";
            label8.Size = new Size(126, 15);
            label8.TabIndex = 0;
            label8.Text = "Кол-во членов семьи";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(153, 128);
            label9.Name = "label9";
            label9.Size = new Size(79, 15);
            label9.TabIndex = 0;
            label9.Text = "Кол-во детей";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(153, 236);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 0;
            label10.Text = "Примечание";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(153, 183);
            label11.Name = "label11";
            label11.Size = new Size(80, 15);
            label11.TabIndex = 0;
            label11.Text = "Задолжность";
            // 
            // textBoxNumP_KMR
            // 
            textBoxNumP_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "NumP", true));
            textBoxNumP_KMR.Location = new Point(16, 37);
            textBoxNumP_KMR.Name = "textBoxNumP_KMR";
            textBoxNumP_KMR.Size = new Size(100, 23);
            textBoxNumP_KMR.TabIndex = 1;
            // 
            // dataServiceBindingSource_KMR
            // 
            dataServiceBindingSource_KMR.DataSource = typeof(Lib.DataService);
            // 
            // textBoxNumK_KMR
            // 
            textBoxNumK_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "NumK", true));
            textBoxNumK_KMR.Location = new Point(16, 91);
            textBoxNumK_KMR.Name = "textBoxNumK_KMR";
            textBoxNumK_KMR.Size = new Size(100, 23);
            textBoxNumK_KMR.TabIndex = 1;
            // 
            // textBoxTotalArea_KMR
            // 
            textBoxTotalArea_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "TotalArea", true));
            textBoxTotalArea_KMR.Location = new Point(16, 146);
            textBoxTotalArea_KMR.Name = "textBoxTotalArea_KMR";
            textBoxTotalArea_KMR.Size = new Size(100, 23);
            textBoxTotalArea_KMR.TabIndex = 1;
            // 
            // textBoxUsableArea_KMR
            // 
            textBoxUsableArea_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "UsableArea", true));
            textBoxUsableArea_KMR.Location = new Point(16, 201);
            textBoxUsableArea_KMR.Name = "textBoxUsableArea_KMR";
            textBoxUsableArea_KMR.Size = new Size(100, 23);
            textBoxUsableArea_KMR.TabIndex = 1;
            // 
            // textBoxNumberOfRooms_KMR
            // 
            textBoxNumberOfRooms_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "NumberOfRooms", true));
            textBoxNumberOfRooms_KMR.Location = new Point(16, 254);
            textBoxNumberOfRooms_KMR.Name = "textBoxNumberOfRooms_KMR";
            textBoxNumberOfRooms_KMR.Size = new Size(100, 23);
            textBoxNumberOfRooms_KMR.TabIndex = 1;
            // 
            // textBoxSurname_KMR
            // 
            textBoxSurname_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "Surname", true));
            textBoxSurname_KMR.Location = new Point(14, 311);
            textBoxSurname_KMR.Name = "textBoxSurname_KMR";
            textBoxSurname_KMR.Size = new Size(100, 23);
            textBoxSurname_KMR.TabIndex = 1;
            // 
            // textBoxNumOfFamMem_KMR
            // 
            textBoxNumOfFamMem_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "NumOfFamMem", true));
            textBoxNumOfFamMem_KMR.Location = new Point(153, 91);
            textBoxNumOfFamMem_KMR.Name = "textBoxNumOfFamMem_KMR";
            textBoxNumOfFamMem_KMR.Size = new Size(100, 23);
            textBoxNumOfFamMem_KMR.TabIndex = 1;
            // 
            // textBoxNumOfKids_KMR
            // 
            textBoxNumOfKids_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "NumOfKids", true));
            textBoxNumOfKids_KMR.Location = new Point(153, 146);
            textBoxNumOfKids_KMR.Name = "textBoxNumOfKids_KMR";
            textBoxNumOfKids_KMR.Size = new Size(100, 23);
            textBoxNumOfKids_KMR.TabIndex = 1;
            // 
            // textBoxArreas_KMR
            // 
            textBoxArreas_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "Arreas", true));
            textBoxArreas_KMR.Location = new Point(153, 201);
            textBoxArreas_KMR.Name = "textBoxArreas_KMR";
            textBoxArreas_KMR.Size = new Size(100, 23);
            textBoxArreas_KMR.TabIndex = 1;
            // 
            // textBoxNote_KMR
            // 
            textBoxNote_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "Note", true));
            textBoxNote_KMR.Location = new Point(153, 254);
            textBoxNote_KMR.Name = "textBoxNote_KMR";
            textBoxNote_KMR.Size = new Size(100, 23);
            textBoxNote_KMR.TabIndex = 1;
            // 
            // buttonOK_KMR
            // 
            buttonOK_KMR.Location = new Point(204, 338);
            buttonOK_KMR.Name = "buttonOK_KMR";
            buttonOK_KMR.Size = new Size(75, 23);
            buttonOK_KMR.TabIndex = 3;
            buttonOK_KMR.Text = "OK";
            buttonOK_KMR.UseVisualStyleBackColor = true;
            buttonOK_KMR.Click += buttonOK_KMR_Click;
            // 
            // buttonCancel_KMR
            // 
            buttonCancel_KMR.Location = new Point(289, 338);
            buttonCancel_KMR.Name = "buttonCancel_KMR";
            buttonCancel_KMR.Size = new Size(75, 23);
            buttonCancel_KMR.TabIndex = 4;
            buttonCancel_KMR.Text = "Отмена";
            buttonCancel_KMR.UseVisualStyleBackColor = true;
            buttonCancel_KMR.Click += buttonCancel_KMR_Click;
            // 
            // textBoxTimeReg_KMR
            // 
            textBoxTimeReg_KMR.DataBindings.Add(new Binding("Text", dataServiceBindingSource_KMR, "TimeReg", true));
            textBoxTimeReg_KMR.Location = new Point(153, 37);
            textBoxTimeReg_KMR.Name = "textBoxTimeReg_KMR";
            textBoxTimeReg_KMR.Size = new Size(100, 23);
            textBoxTimeReg_KMR.TabIndex = 5;
            // 
            // FormRed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 373);
            Controls.Add(textBoxTimeReg_KMR);
            Controls.Add(buttonCancel_KMR);
            Controls.Add(buttonOK_KMR);
            Controls.Add(textBoxSurname_KMR);
            Controls.Add(textBoxNote_KMR);
            Controls.Add(textBoxArreas_KMR);
            Controls.Add(textBoxNumberOfRooms_KMR);
            Controls.Add(textBoxNumOfKids_KMR);
            Controls.Add(textBoxUsableArea_KMR);
            Controls.Add(textBoxTotalArea_KMR);
            Controls.Add(textBoxNumOfFamMem_KMR);
            Controls.Add(textBoxNumK_KMR);
            Controls.Add(textBoxNumP_KMR);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактор";
            Load += FormRed_Load;
            ((System.ComponentModel.ISupportInitialize)dataServiceBindingSource_KMR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxNumP_KMR;
        private TextBox textBoxNumK_KMR;
        private TextBox textBoxTotalArea_KMR;
        private TextBox textBoxUsableArea_KMR;
        private TextBox textBoxNumberOfRooms_KMR;
        private TextBox textBoxSurname_KMR;
        private TextBox textBoxNumOfFamMem_KMR;
        private TextBox textBoxNumOfKids_KMR;
        private TextBox textBoxArreas_KMR;
        private TextBox textBoxNote_KMR;
        private Button buttonOK_KMR;
        private Button buttonCancel_KMR;
        private TextBox textBoxTimeReg_KMR;
        private BindingSource dataServiceBindingSource_KMR;
    }
}