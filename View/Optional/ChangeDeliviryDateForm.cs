using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace llc_decorations.View.Optional
{
    public partial class ChangeDeliviryDateForm : Form
    {
        public DateTime date;
        public ChangeDeliviryDateForm()
        {
            InitializeComponent();

            dtpDeliviryDate.Format = DateTimePickerFormat.Short;
            dtpDeliviryDate.MinDate = DateTime.Today;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            date = dtpDeliviryDate.Value;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
