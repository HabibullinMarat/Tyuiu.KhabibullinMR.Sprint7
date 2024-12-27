using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.KhabibullinMR.Sprint7.Project.V7.Lib;

namespace Tyuiu.KhabibullinMR.Sprint7.Project.V7
{
    public partial class FormRed : Form
    {
        public DataService EditedRow { get; set; }

        public FormRed()
        {
            InitializeComponent();
        }

        public delegate void DelegateUpdate(DataService updatedRow);

        public event DelegateUpdate UpdatedEvent;

        private void buttonOK_KMR_Click(object sender, EventArgs e)
        {
            DataService UpdatedRow = (DataService)dataServiceBindingSource_KMR.Current;
            if (UpdatedEvent != null)
            {
                UpdatedEvent(UpdatedRow);
            }
            Close();
        }

        private void buttonCancel_KMR_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormRed_Load(object sender, EventArgs e)
        {
            dataServiceBindingSource_KMR.Add(EditedRow);
        }
    }
}
