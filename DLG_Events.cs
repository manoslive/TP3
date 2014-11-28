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
    public partial class DLG_Events : Form
    {
        public Event Event { get; set; }
        private bool blockUpdate;
        public bool delete = false;
        public bool deleteCM = false;
        public int choixRecurrence {get; set;}
        public int nbrRecurrence { get; set; }
        public DLG_Events()
        {
            InitializeComponent();
            choixRecurrence = 0;
            nbrRecurrence = 0;
        }

        private void DLG_Events_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.positionEvents;
            PB_General.BackColor = Properties.Settings.Default.colorGeneral;
            PB_Travail.BackColor = Properties.Settings.Default.colorTravail;
            PB_Sante.BackColor = Properties.Settings.Default.colorSante;
            PB_Important.BackColor = Properties.Settings.Default.colorImportant;
            PB_Loisir.BackColor = Properties.Settings.Default.colorLoisir;
            PB_Autre.BackColor = Properties.Settings.Default.colorAutre;
            delete = false;
            EventToDLG();
            if (deleteCM)
                Effacer();
            CB_Recurrence.SelectedItem = CB_Recurrence.Items[0];
        }

        public static DateTime Klone(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0);
        }

        private void CategoryToRB()
        {
            switch (Event.Category)
            {
                case 0:
                    RB_General.Checked = true;
                    break;
                case 1:
                    RB_Travail.Checked = true;
                    break;
                case 2:
                    RB_Sante.Checked = true;
                    break;
                case 3:
                    RB_Important.Checked = true;
                    break;
                case 4:
                    RB_Loisir.Checked = true;
                    break;
                case 5:
                    RB_Autre.Checked = true;
                    break;
            }
        }

        private int RBToInt()
        {
            if (RB_General.Checked)
                return 0;
            else if (RB_Travail.Checked)
                return 1;
            else if (RB_Sante.Checked)
                return 2;
            else if (RB_Important.Checked)
                return 3;
            else if (RB_Loisir.Checked)
                return 4;
            else if (RB_Autre.Checked)
                return 5;
            else
                return 0;
        }

        private void EventToDLG()
        {
            if (Event != null)
            {
                TBX_Title.Text = Event.Title;
                TBX_Description.Text = Event.Description;
                blockUpdate = true;
                CategoryToRB();

                DTP_Date.Value = Klone(Event.Starting);
                NUD_DebutHeure.Value = Convert.ToInt32((Klone(Event.Starting).Hour));
                NUD_DebutMinute.Value = Convert.ToInt32((Klone(Event.Starting).Minute));
                NUD_FinHeure.Value = Convert.ToInt32((Klone(Event.Ending).Hour));
                NUD_FinMinute.Value = Convert.ToInt32((Klone(Event.Ending).Minute));


                blockUpdate = false;
            }
            else
                Event = new Event();
        }

        private void TBX_Title_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBX_Description_TextChanged(object sender, EventArgs e)
        {
        }

        private void DTP_Date_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                DTP_Date.Value.Month,
                                                DTP_Date.Value.Day,
                                                Convert.ToInt32(NUD_DebutHeure.Value),
                                                Convert.ToInt32(NUD_DebutMinute.Value),
                                                0);

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            Convert.ToInt32(NUD_FinHeure.Value),
                                            Convert.ToInt32(NUD_FinMinute.Value),
                                            0);
            }
        }

        private void DTP_Starting_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_DebutHeure.Value),
                                                 Convert.ToInt32(NUD_DebutMinute.Value),
                                                 0);
            }
        }

        private void DTP_Ending_ValueChanged(object sender, EventArgs e)
        {
            if (!blockUpdate)
            {

                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                            DTP_Date.Value.Month,
                                            DTP_Date.Value.Day,
                                            Convert.ToInt32(NUD_FinHeure.Value),
                                            Convert.ToInt32(NUD_FinMinute.Value),
                                            0);
            }
        }

        private void Effacer()
        {
            if (MessageBox.Show("Voulez vous vraiment effacer cet événement ?", "Effacer", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                delete = true;
            }
            this.Close();
        }

        private void BTN_Effacer_Click(object sender, EventArgs e)
        {
            Effacer();
        }

        private void DLG_Events_FormClosing(object sender, FormClosingEventArgs e)
        {
            nbrRecurrence = Convert.ToInt32(NUD_Recurrence.Value);
            choixRecurrence = Convert.ToInt32(CB_Recurrence.SelectedIndex);
            Properties.Settings.Default.positionEvents = this.Location;
            Properties.Settings.Default.Save();
        }

        private void flashButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void TestSiChampsVides()
        {

        }

        private void FBTN_Accepter_Click(object sender, EventArgs e)
        {
            // Réitialisation à noir
            LB_Description.ForeColor = Color.Black;
            LB_Titre.ForeColor = Color.Black;
            GB_Categorie.ForeColor = Color.Black;

            if (TBX_Description.Text != "" && TBX_Title.Text != "")
            {
                Event.Description = TBX_Description.Text;
                Event.Title = TBX_Title.Text;
                Event.Category = RBToInt();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
                if (TBX_Description.Text == "" && TBX_Title.Text == "")
                {
                    LB_Description.ForeColor = Color.Red;
                    LB_Titre.ForeColor = Color.Red;
                }
                else if (TBX_Title.Text == "")
                    LB_Titre.ForeColor = Color.Red;

                else
                    LB_Description.ForeColor = Color.Red;
        }


        private void PB_General_MouseHover(object sender, EventArgs e)
        {
        }

        private void PB_General_MouseHover(object sender, MouseEventArgs e)
        {

        }

        private void PB_General_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorGeneral = dlg.Color;
                Properties.Settings.Default.Save();

            }
            PB_General.BackColor = Properties.Settings.Default.colorGeneral;
        }

        private void PB_Travail_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorTravail = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PB_Travail.BackColor = Properties.Settings.Default.colorTravail;
        }

        private void PB_Sante_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorSante = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PB_Sante.BackColor = Properties.Settings.Default.colorSante;
        }

        private void PB_Important_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorImportant = dlg.Color;
                Properties.Settings.Default.Save();

            }
            PB_Important.BackColor = Properties.Settings.Default.colorImportant;
        }

        private void PB_Loisir_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorLoisir = dlg.Color;
                Properties.Settings.Default.Save();

            }
            PB_Loisir.BackColor = Properties.Settings.Default.colorLoisir;
        }

        private void PB_Autre_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.colorAutre = dlg.Color;
                Properties.Settings.Default.Save();

            }
            PB_Autre.BackColor = Properties.Settings.Default.colorAutre;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorGeneral;
            Event.Category = 0;
        }

        private void RG_Travail_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorTravail;
            Event.Category = 1;
        }

        private void RB_Sante_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorSante;
            Event.Category = 2;
        }

        private void RB_Important_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorImportant;
            Event.Category = 3;
        }

        private void RB_Loisir_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorLoisir;
            Event.Category = 4;
        }

        private void RB_Autre_CheckedChanged(object sender, EventArgs e)
        {
            Event.eventColor = Properties.Settings.Default.colorAutre;
            Event.Category = 5;
        }

        private void NUD_DebutMinute_MouseUp(object sender, MouseEventArgs e)
        {
            NUD_OnChange();

            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_DebutHeure.Value),
                                                 Convert.ToInt32(NUD_DebutMinute.Value),
                                                 0);
            }
        }

        private void NUD_FinMinute_MouseUp(object sender, MouseEventArgs e)
        {
            NUD_OnChange();
            if (!blockUpdate)
            {
                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_FinHeure.Value),
                                                 Convert.ToInt32(NUD_FinMinute.Value),
                                                 0);
            }
        }

        private void NUD_DebutHeure_MouseUp(object sender, MouseEventArgs e)
        {
            NUD_OnChange();
            if (!blockUpdate)
            {
                Event.Starting = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_DebutHeure.Value),
                                                 Convert.ToInt32(NUD_DebutMinute.Value),
                                                 0);
            }
        }

        private void NUD_FinHeure_MouseUp(object sender, MouseEventArgs e)
        {
            NUD_OnChange();
            if (!blockUpdate)
            {
                Event.Ending = new DateTime(DTP_Date.Value.Year,
                                                 DTP_Date.Value.Month,
                                                 DTP_Date.Value.Day,
                                                 Convert.ToInt32(NUD_FinHeure.Value),
                                                 Convert.ToInt32(NUD_FinMinute.Value),
                                                 0);
            }
        }
        private void NUD_OnChange()
        {
            if (NUD_FinHeure.Value >= 23 && NUD_DebutHeure.Value >= 23)
            {
                NUD_FinHeure.Value = 23;
                NUD_DebutHeure.Value = 23;
                if (NUD_FinMinute.Value > 55)
                    NUD_FinMinute.Value = 55;
                if (NUD_DebutMinute.Value > 25)
                    NUD_DebutMinute.Value = 25;
            }
            if (NUD_DebutHeure.Value > NUD_FinHeure.Value)
            {
                NUD_FinHeure.Value = NUD_DebutHeure.Value;
            }
            if (NUD_DebutHeure.Value == NUD_FinHeure.Value)
            {
                if (NUD_DebutMinute.Value > (NUD_FinMinute.Value - 30))
                {
                    NUD_FinMinute.Value = NUD_DebutMinute.Value + 30;
                    if (NUD_FinMinute.Value > 55)
                    {
                        NUD_FinMinute.Value = 0;
                        NUD_FinHeure.Value++;
                    }
                }
            }
            else if (NUD_FinHeure.Value == (NUD_DebutHeure.Value + 1))
            {
                if (NUD_FinMinute.Value <= 30 && NUD_DebutMinute.Value >= 30)
                {
                    NUD_FinMinute.Value = NUD_DebutMinute.Value - 30;
                }
            }
            if (NUD_DebutMinute.Value > 55)
            {
                NUD_DebutHeure.Value++;
                NUD_DebutMinute.Value = 0;
            }
            else if (NUD_DebutMinute.Value < 0)
            {
                NUD_DebutHeure.Value--;
                NUD_DebutMinute.Value = 55;
            }
            if (NUD_FinMinute.Value > 55)
            {
                NUD_FinHeure.Value++;
                NUD_FinMinute.Value = 0;
            }
            else if (NUD_FinMinute.Value < 0)
            {
                NUD_FinMinute.Value = 0;
            }
        }
    }
}
