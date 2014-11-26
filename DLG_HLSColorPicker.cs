using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{

    public partial class DLG_HLSColorPicker : Form
    {
        public Color color;
        private HLSColor HLS_Color;
        public List<Color> RecentColors = new List<Color>();
        private const int MAX_RECENT_COLORS = 10;
        private string title;
        public DLG_HLSColorPicker()
        {
            InitializeComponent();
        }

        private void FORM_BackColor_Load(object sender, EventArgs e)
        {
            HLS_Color = new HLSColor(color);
            title = this.Text;
            Load_Settings();
            Init_TrackBars();
            Fill_PN_RecentColors();
            UpdateControls();
        }

        private string ColorComponetToString(int cc)
        {
            string scc = cc.ToString();
            if (cc < 10)
                scc = "00" + scc;
            else
                if (cc < 100)
                    scc = "0" + scc;
            return scc;
        }
        private void SetTitleCurrentColor()
        {
            this.Text = title + " - [" + ColorComponetToString(color.R) + ":" + ColorComponetToString(color.G) + ":" + ColorComponetToString(color.B) + "]";
        }

        private void Load_Settings()
        {
           
            Point location = Properties.Settings.Default.BackColorFormLocation;
            if (location.X != 0 && Location.Y != 0)
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = Properties.Settings.Default.BackColorFormLocation;
            }

            Load_Recent_Colors();
        }

        private void Load_Recent_Colors()
        {
            if (Properties.Settings.Default.Colors != null)
            {
                foreach (string s in Properties.Settings.Default.Colors)
                {
                    RecentColors.Add(StringToColor(s));
                }
            }
        }

        private void Save_Recent_Colors()
        {
            if (Properties.Settings.Default.Colors == null)
                Properties.Settings.Default.Colors = new System.Collections.Specialized.StringCollection();
            else
                Properties.Settings.Default.Colors.Clear();

            foreach (Color c in RecentColors)
            {
                Properties.Settings.Default.Colors.Add(ColorToString(c));
            }
        }

        private string ColorToString(Color color)
        {
            return color.R.ToString() + "|" + color.G.ToString() + "|" + color.B.ToString() + "|";
        }

        private Color StringToColor(string s)
        {
            string[] RGBStrings = s.Split('|');
            return Color.FromArgb(Byte.Parse(RGBStrings[0]), Byte.Parse(RGBStrings[1]), Byte.Parse(RGBStrings[2]));
        }

        private void AddRecentColor(Color color)
        {
            bool exist = false;

            int index;
            for (index = 0; index < RecentColors.Count; index++)
            {
                if ((RecentColors[index].R == color.R) &&
                    (RecentColors[index].B == color.B) &&
                    (RecentColors[index].G == color.G))
                {
                    exist = true;
                    break;
                }
            }
            if (!exist)
            {
                if (RecentColors.Count == MAX_RECENT_COLORS)
                {
                    for (index = 1; index < RecentColors.Count; index++)
                    {
                        RecentColors[index - 1] = Color.FromArgb(RecentColors[index].R, RecentColors[index].G, RecentColors[index].B);
                    }
                    RecentColors.RemoveAt(RecentColors.Count - 1);
                }
                RecentColors.Add(color);
            }
        }

        private void Save_Settings()
        { 
            // Chemin d'accès typique ou sont conservés les "settings"
            // C:\Users\Nicolas Chourot\AppData\Local\DémoSettings\DémoSettings.exe_Url_bety5kof3bxncjnibzie2cykiqiwamdp\1.0.0.0\user.config
            Properties.Settings.Default.BackColorFormLocation = this.Location;
            Save_Recent_Colors();
            Properties.Settings.Default.Save();
        }

        private void Init_TrackBars()
        {
            TKBR_Hue.Value        = (int)(Math.Round(HLS_Color.Hue        * (double)TKBR_Hue.Maximum       ));
            TKBR_Luminosity.Value = (int)(Math.Round(HLS_Color.Luminosity * (double)TKBR_Luminosity.Maximum));
            TKBR_Saturation.Value = (int)(Math.Round(HLS_Color.Saturation * (double)TKBR_Saturation.Maximum));
            UpdateControls();
        }

        private static String GetColorName(Color color)
        {
            double tolerence = 2;
            KnownColor[] colors = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            foreach (KnownColor knowColor in colors)
            {
                Color c = Color.FromKnownColor(knowColor);
                if ((Math.Abs(c.R - color.R) <= tolerence) &&
                    (Math.Abs(c.G - color.G) <= tolerence) &&
                    (Math.Abs(c.B - color.B) <= tolerence))
                    return c.Name;
                    
            }
            return color.Name.ToUpper().Substring(2);
        }

        private void UpdateControls()
        {
            color = PN_ColorPreview.BackColor = HLS_Color.ToRGB();
            LB_Teinte.Text = "Teinte " + GetColorName(color);
            LB_Hue.Text =        (Math.Round(HLS_Color.Hue * 360)).ToString() +"°";
            LB_Luminosity.Text = (Math.Truncate(HLS_Color.Luminosity * 100f) / 100f).ToString();
            LB_Saturaiton.Text = (Math.Truncate(HLS_Color.Saturation * 100f) / 100f).ToString();
            SetTitleCurrentColor();
        }

        private void TKBR_Hue_ValueChanged(object sender, EventArgs e)
        {
            HLS_Color.Hue = TKBR_Hue.Value / (double)TKBR_Hue.Maximum;
            PN_Lightness.Refresh();
            PN_Saturation.Refresh();
            UpdateControls();
        }

        private void TKBR_Luminosity_ValueChanged(object sender, EventArgs e)
        {
            HLS_Color.Luminosity = TKBR_Luminosity.Value / (double)TKBR_Luminosity.Maximum;
            PN_Saturation.Refresh();
            UpdateControls();
        }

        private void TKBR_Saturation_ValueChanged(object sender, EventArgs e)
        {
            HLS_Color.Saturation = TKBR_Saturation.Value / (double)TKBR_Saturation.Maximum;
            PN_Lightness.Refresh();
            UpdateControls();
        }

        private void Gradient(Graphics DC, int HLS_Select, int width, int height)
        {
            HLSColor hls = new HLSColor(HLS_Color);
            double density = 0.005;
            if (HLS_Select == 1 /*Hue*/)
            {
                hls.Luminosity = 0.5;
                hls.Saturation = 1.0;
            }
            for (double step = 0; step < 1; step += density)
            {
                Rectangle rectangle = new Rectangle((int)(step * width), 0, (int)(width/density), height);
                switch (HLS_Select)
                {
                    case 1: hls.Hue = step; break;
                    case 2: hls.Luminosity = step; break;
                    case 3: hls.Saturation = step; break;
                }
                Brush brush = new SolidBrush(hls.ToRGB());
                DC.FillRectangle(brush, rectangle);
            }
        }

        private void PN_Hue_Paint(object sender, PaintEventArgs e)
        {
            Gradient(e.Graphics, 1/*Hue*/, PN_Hue.Width, PN_Hue.Height);
        }

        private void PN_Lightness_Paint(object sender, PaintEventArgs e)
        {
            Gradient(e.Graphics, 2/*Luminosity*/, PN_Lightness.Width, PN_Lightness.Height);
        }

        private void PN_Saturation_Paint(object sender, PaintEventArgs e)
        {
            Gradient(e.Graphics, 3/*Saturation*/, PN_Saturation.Width, PN_Saturation.Height);
        }

        private void TKBR_Hue_MouseDown(object sender, MouseEventArgs e)
        {
            TrackBar TKBR = (TrackBar)sender;
            TKBR.Capture = true;
            Cursor.Hide();
        }

        private void TKBR_Hue_MouseUp(object sender, MouseEventArgs e)
        {
            TrackBar TKBR = (TrackBar)sender;
            TKBR.Capture = false;
            Cursor.Show();
        }

        private void PN_Hue_MouseDown(object sender, MouseEventArgs e)
        {
            TKBR_Hue.Select();
            TKBR_Hue.Value = (int)Math.Round((double)e.Location.X / PN_Hue.Width * TKBR_Hue.Maximum);
        }

        private void PN_Lightness_MouseDown(object sender, MouseEventArgs e)
        {
            TKBR_Luminosity.Select();
            TKBR_Luminosity.Value = (int)Math.Round((double)e.Location.X / PN_Lightness.Width * TKBR_Luminosity.Maximum);
        }

        private void PN_Saturation_MouseDown(object sender, MouseEventArgs e)
        {
            TKBR_Saturation.Select();
            TKBR_Saturation.Value = (int)Math.Round((double)e.Location.X / PN_Saturation.Width * TKBR_Saturation.Maximum);
        }

        private void PN_Hue_DoubleClick(object sender, EventArgs e)
        {
            double H = TKBR_Hue.Value / (double)TKBR_Hue.Maximum;
            double A = (Math.Truncate((H * 360D + 15D) / 30D) * 30D);
            TKBR_Hue.Value = (int) Math.Round((double)TKBR_Hue.Maximum * A / 360D);
        }

        private void PN_Lightness_DoubleClick(object sender, EventArgs e)
        {
            double v = (double)TKBR_Luminosity.Value / TKBR_Luminosity.Maximum;
            v = Math.Truncate(v * 4D + 0.5) / 4D; 
                
            TKBR_Luminosity.Value = (int)Math.Round(v * TKBR_Luminosity.Maximum);
        }

        private void PN_Saturation_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            double v = (double)TKBR_Saturation.Value / TKBR_Saturation.Maximum;
            v = Math.Truncate(v * 4D + 0.5) / 4D;
            TKBR_Saturation.Value = (int)Math.Round(v * TKBR_Saturation.Maximum);
        }

        private void Fill_PN_RecentColors()
        {
            int width = 30;
            int height = 30;
            int hspace = 15;
            int vspace = 10;
            int index = 0;

            foreach (Color c in RecentColors)
            {
                Panel PN = new Panel();
                PN.Location = new Point(index*(width+hspace), vspace);
                PN.Width = width;
                PN.Height = height;
                PN.BackColor = c;
                PN.MouseDown += PN_RecentColor_MouseDown;
                PN.MouseUp += PN_RecentColor_MouseUp;
                PN.Click += PN_RecentColor_Click;
                PN_RecentColors.Controls.Add(PN);
                index++;
            }
        }

        private void PN_RecentColor_MouseDown(object sender, EventArgs e)
        {
            Panel PN = (Panel)sender;
            PN.BorderStyle = BorderStyle.Fixed3D;
        }

        private void PN_RecentColor_MouseUp(object sender, EventArgs e)
        {
            Panel PN = (Panel)sender;
            PN.BorderStyle = BorderStyle.None;
        }

        private void PN_RecentColor_Click(object sender, EventArgs e)
        {
            Panel PN = (Panel)sender;
            HLS_Color = new HLSColor(PN.BackColor);
            Init_TrackBars();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            AddRecentColor(color);
        }

        private void FORM_BackColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save_Settings();
        }      
     
    }
}
