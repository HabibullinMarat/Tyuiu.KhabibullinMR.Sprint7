namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            textBoxAbout_KMR = new TextBox();
            SuspendLayout();
            // 
            // textBoxAbout_KMR
            // 
            textBoxAbout_KMR.Dock = DockStyle.Fill;
            textBoxAbout_KMR.Location = new Point(0, 0);
            textBoxAbout_KMR.Multiline = true;
            textBoxAbout_KMR.Name = "textBoxAbout_KMR";
            textBoxAbout_KMR.ReadOnly = true;
            textBoxAbout_KMR.Size = new Size(311, 245);
            textBoxAbout_KMR.TabIndex = 0;
            textBoxAbout_KMR.Text = resources.GetString("textBoxAbout_KMR.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(311, 245);
            Controls.Add(textBoxAbout_KMR);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout_KMR;
    }
}