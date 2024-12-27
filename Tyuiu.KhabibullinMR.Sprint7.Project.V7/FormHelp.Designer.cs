namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            textBoxHelp_KMR = new TextBox();
            SuspendLayout();
            // 
            // textBoxHelp_KMR
            // 
            textBoxHelp_KMR.Dock = DockStyle.Fill;
            textBoxHelp_KMR.Location = new Point(0, 0);
            textBoxHelp_KMR.Multiline = true;
            textBoxHelp_KMR.Name = "textBoxHelp_KMR";
            textBoxHelp_KMR.ReadOnly = true;
            textBoxHelp_KMR.Size = new Size(378, 308);
            textBoxHelp_KMR.TabIndex = 0;
            textBoxHelp_KMR.Text = resources.GetString("textBoxHelp_KMR.Text");
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 308);
            Controls.Add(textBoxHelp_KMR);
            Name = "FormHelp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Краткое руководство пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxHelp_KMR;
    }
}