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
    public partial class DateSelect : Form
    {
        public DateTime dateSemaineCourante { get; set; }
        public DateSelect()
        {
            InitializeComponent();
        }
        private void DateSelect_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.positionDateSelect;
            DTP_DateSemaineCourante.CustomFormat = "dd-MM-YYYY";
        }

        private void FBTN_Ok_Click(object sender, EventArgs e)
        {
            dateSemaineCourante = DTP_DateSemaineCourante.Value;
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void FBTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DateSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.positionDateSelect = this.Location;
        }


    }
}
