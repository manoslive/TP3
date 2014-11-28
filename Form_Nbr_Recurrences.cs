using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public partial class Form_Nbr_Recurrences : Form
    {
        public int nbrRecurrence { get; set; }
        public Form_Nbr_Recurrences()
        {
            InitializeComponent();
            nbrRecurrence = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FBTN_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FBTN_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void NUD_Recurrence_ValueChanged(object sender, EventArgs e)
        {
            nbrRecurrence = Convert.ToInt32(NUD_Recurrence.Value);
        }
    }
}
