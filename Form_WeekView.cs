﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZoomSliderProject;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Agenda Compacte:
//
//  Auteur: Nicolas Chourot
//  Date:   Novembre 2014
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//  Ce source constitution la plate forme de déaprt pour le TP#3
//  INTIALEZ LES PORTIONS DE CODE QUE VOUS AVEZ MODIFIÉ ET/OU AJOUTÉ
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Compact_Agenda
{
    public partial class Form_WeekView : Form
    {
        public string ConnexionString;
        private DateTime _CurrentWeek;
        private Events evenement = new Events();
        private int minInterval = 5;
        private int valeurZoom = 50;
        public DateTime CurrentWeek
        {
            set
            {
                // calculer la date du dimanche de la semaine courante
                _CurrentWeek = value.AddDays(-(int)value.DayOfWeek);
            }
            get { return _CurrentWeek; }
        }

        public Form_WeekView()
        {
            InitializeComponent();
            // Ici on assume que la BD est dans le même répertoire que l'éxécutable
            // faire attention de copier la bd dans le répertoire release et/ou debug selon le cas
            string DB_URL = System.IO.Path.GetFullPath(@"DB_AGENDA.MDF");
            ConnexionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='" + DB_URL + "';Integrated Security=True";
            CurrentWeek = DateTime.Now;
            PN_Hours.Height = PN_Content.Height = 2400;

        }
        private void Form_WeekView_Load(object sender, EventArgs e)
        {
            PN_Scroll.Focus();
            GotoCurrentWeek();
            this.Size = Properties.Settings.Default.tailleWeekView;
            this.Location = Properties.Settings.Default.positionWeekView;
            this.PN_Scroll.BackColor = Properties.Settings.Default.colorFondContent;
            this.PN_Content.BackColor = Properties.Settings.Default.colorFondContent;
            this.PN_DaysHeader.BackColor = Properties.Settings.Default.colorPN_Days;
            this.PN_Hours.BackColor = Properties.Settings.Default.colorPN_Hours;
            this.PN_Frame.BackColor = Properties.Settings.Default.colorPN_Frame;
        }

        private void PN_Scroll_MouseEnter(Object sender, EventArgs e)
        {
            ZS_ZoomMaster.Visible = false;
            // pour s'assurer que le mousewheel event sera intercepté

            PN_Scroll.Focus();

        }


        private void GetWeekEvents()
        {
            TableEvents tableEvents = new TableEvents(ConnexionString);
            DateTime date = _CurrentWeek;
            evenement.Clear();
            for (int day = 0; day < 7; day++)
            {
                tableEvents.GetDateEvents(date);
                while (tableEvents.NextEventRecord())
                {
                    tableEvents.currentEventRecord.ParentPanel = PN_Content;
                    evenement.Add(tableEvents.currentEventRecord);
                }
                tableEvents.EndQuerySQL();
                date = date.AddDays(1);
            }
        }

        private void Fill_Agenda(Graphics DC)
        {
            Brush brush = new SolidBrush(Color.Black);
            Pen penActuel = new Pen(Color.Red, 1);
            Pen pen1 = new Pen(Properties.Settings.Default.colorLignePrincipale, 1);
            Pen pen2 = new Pen(Properties.Settings.Default.colorLigneSecondaire, 1);
            pen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            for (int hour = 0; hour < 24; hour++)
            {
                DC.DrawLine(pen1, 0, Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
                DC.DrawLine(pen2, 0, Event.HourToPixel(hour, 30, PN_Hours.Height), PN_Content.Width, Event.HourToPixel(hour, 30, PN_Hours.Height));
                if (hour == DateTime.Now.Hour)
                {
                    for (int min = 0; min < 60; min++)
                    {
                        if (min == DateTime.Now.Minute)
                        {
                            Point locationFleche = new Point(0, Event.HourToPixel(hour, min, PN_Hours.Height));
                            DC.DrawLine(penActuel, locationFleche.X, locationFleche.Y, (locationFleche.X + 17) + PN_Content.Width, locationFleche.Y);
                        }
                    }
                }

            }
            Point location;
            for (int dayNum = 0; dayNum < 7; dayNum++)
            {
                location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                DC.DrawLine(pen1, location.X, 0, location.X, PN_Content.Height);
            }
            location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * 7), 0);
            DC.DrawLine(pen1, location.X - 1, 0, location.X - 1, PN_Content.Height);
            evenement.Draw(DC);
            PN_Scroll.Focus();
        }

        private void PN_Content_Paint(object sender, PaintEventArgs e)
        {
            Fill_Agenda(e.Graphics);
        }

        private void Fill_Days_Header(Graphics DC)
        {
            Point location;
            Point location2;
            DateTime date = _CurrentWeek;
            string[] dayNames = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.DayNames;//[col].Substring(0, 3).ToUpper();
            Pen pen = new Pen(Color.Black, 1);
            Pen penLignes = new Pen(Properties.Settings.Default.colorLigneDaysHeader);
            Brush brush = new SolidBrush(Color.White);
            for (int dayNum = 0; dayNum < 7; dayNum++)
            {
                location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * dayNum), 0);
                location2 = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * (dayNum + 1)), 0);
                String headerText = dayNames[dayNum];
                String headerDate = date.ToShortDateString();
                if (Convert.ToInt32(DateTime.Now.DayOfWeek) == dayNum && DateTime.Now.Day == date.Day && DateTime.Now.Year == date.Year) //si le jour de la semaine est pareille que le jour de semaine actuel, 
                {
                    pen = new Pen(Properties.Settings.Default.colorPN_Days_Today, (PN_DaysHeader.Width / 7f) - 2);
                    brush = new SolidBrush(Color.Black);
                    DC.DrawLine(pen, (location.X + location2.X) / 2, 0, (location.X + location2.X) / 2, PN_DaysHeader.Height - 1); //surligne la journée d'aujourd'hui 
                }
                else
                {
                    pen = new Pen(Color.LightGray, 1);
                    brush = new SolidBrush(Color.White);
                }
                DC.DrawLine(penLignes, location.X, 0, location.X, PN_DaysHeader.Height);
                DC.DrawString(headerText, PN_DaysHeader.Font, brush, Convert.ToInt32(location.X * 1.05), location.Y);//afficher à un pourcentage de la location
                DC.DrawString(headerDate, PN_DaysHeader.Font, brush, Convert.ToInt32(location.X * 1.05), location.Y + 14);//""      
                date = date.AddDays(1);
            }
            DC.DrawLine(penLignes, 0, PN_DaysHeader.Height - 1, PN_DaysHeader.Width, PN_DaysHeader.Height - 1);
            DC.DrawLine(penLignes, PN_DaysHeader.Width - 2, 0, PN_DaysHeader.Width - 2, PN_DaysHeader.Height);//ligne qui sépare le PN_DaysHeader de reste
            location = new Point((int)Math.Round(PN_DaysHeader.Width / 7f * 7), 0);
            DC.DrawLine(penLignes, location.X - 1, 0, location.X - 1, PN_DaysHeader.Height); //ligne completement à la droite
        }

        private void Fill_Hours_Header(Graphics DC)
        {
            Brush brush = new SolidBrush(Properties.Settings.Default.colorFontPN_Hours);
            Pen pen = new Pen(Color.LightGray, 1);
            for (int hour = 0; hour <= 24; hour++)
            {
                Point location = new Point(0, Event.HourToPixel(hour, 0, PN_Hours.Height));
                String headerText = (hour < 10 ? "0" : "") + hour.ToString() + ":00";
                DC.DrawString(headerText, Properties.Settings.Default.fontPN_Hours, brush, location);
                DC.DrawLine(pen, 0, Event.HourToPixel(hour + 1, 0, PN_Hours.Height), PN_Hours.Width, Event.HourToPixel(hour + 1, 0, PN_Hours.Height));
                if (hour == DateTime.Now.Hour)
                {
                    for (int min = 0; min < 60; min++)
                    {
                        if (min == DateTime.Now.Minute)
                        {
                            Point locationFleche = new Point(0, Event.HourToPixel(hour, min, PN_Hours.Height));
                            PB_Fleche.Visible = true;
                            PB_Fleche.Location = new Point(locationFleche.X + 17, locationFleche.Y - 11);
                        }
                    }
                }
            }
        }

        private void PN_DaysHeader_Paint(object sender, PaintEventArgs e)
        {
            Fill_Days_Header(e.Graphics);
        }

        private void PN_Hours_Paint(object sender, PaintEventArgs e)
        {
            Fill_Hours_Header(e.Graphics);
        }

        private void AdjustMinInterval()
        {
            minInterval = 5;
            while (Event.HourToPixel(0, minInterval, PN_Content.Height) < 5)
                minInterval += 5;
        }
        private void PN_Scroll_Resize(object sender, EventArgs e)
        {
            PN_Content.Width = PN_Scroll.Width - 70;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Width = PN_Content.Width;
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();
        }

        private void PN_Scroll_Scroll(object sender, ScrollEventArgs e)
        {
            PN_DaysHeader.Refresh();
            PN_Content.Refresh();
        }


        Point lastMouseLocation;
        Point firstMouseLocation;
        bool mouseIsDown = false;
        Pen pen = new Pen(Color.Blue, 1);

        private int RoundToMinutes(int pixel, int interval)
        {
            int pixel_interval = Event.HourToPixel(0, interval, PN_Content.Height);
            if (pixel_interval > 5)
            {
                int half_interval = (int)Math.Round(pixel_interval / 2f);

                int minutes = Event.PixelToMinutes(pixel + half_interval, PN_Content.Height);
                minutes = (int)Math.Truncate((float)minutes / interval) * interval;
                int hour = (int)Math.Truncate(minutes / 60f);
                minutes = minutes - hour * 60;
                return Event.HourToPixel(hour, minutes, PN_Content.Height);
            }
            else
                return pixel;
        }

        private void EventContextMenu()
        {
            CM_Event.Show(Cursor.Position);
        }

        private void PN_Content_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseIsDown = true;
                firstMouseLocation = lastMouseLocation = e.Location;

                if (evenement.TargetEvent != null)
                {
                    switch (evenement.TargetPart)
                    {
                        case TargetPart.Top:
                            firstMouseLocation.Y =
                            lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(evenement.TargetEvent.Starting.Hour, evenement.TargetEvent.Starting.Minute, PN_Content.Height), minInterval);
                            break;
                        case TargetPart.Bottom:
                            firstMouseLocation.Y =
                            lastMouseLocation.Y = RoundToMinutes(Event.HourToPixel(evenement.TargetEvent.Ending.Hour, evenement.TargetEvent.Ending.Minute, PN_Content.Height), minInterval);
                            break;
                        default: break;
                    }
                }
            }
        }

        private void AjustCurrentWeek()
        {
            DateTime Target = new DateTime(evenement.TargetEvent.Starting.Year, evenement.TargetEvent.Starting.Month, evenement.TargetEvent.Starting.Day, 0, 0, 0);
            DateTime CW = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day, 0, 0, 0);
            int delta = (int)(Target - CW).TotalDays;
            if (delta > 6)
            {
                Event currentTarget = evenement.TargetEvent.Klone();
                Increment_Week();
                evenement.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                evenement.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X - 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
            if (delta < 0)
            {
                Event currentTarget = evenement.TargetEvent.Klone();
                Decrement_Week();
                evenement.Add(currentTarget);
                currentTarget.Draw(PN_Content.CreateGraphics());
                evenement.TargetEvent = currentTarget;
                Cursor.Position = new Point(Cursor.Position.X + 7 * (int)(PN_Content.Width / 7F), Cursor.Position.Y);
            }
        }

        private void AdjustScroll(int value)
        {
            int PN_Scroll_Mouse_Location = value - PN_Scroll.VerticalScroll.Value;
            int hour_heigth = Event.HourToPixel(1, 0, PN_Scroll.Height);

            if (PN_Scroll_Mouse_Location < 0)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y + hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value - hour_heigth) > hour_heigth)
                    PN_Scroll.VerticalScroll.Value -= hour_heigth;
            }
            if (PN_Scroll_Mouse_Location > PN_Scroll.Height)
            {
                Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y - hour_heigth);
                if ((PN_Scroll.VerticalScroll.Value + hour_heigth) < PN_Content.Height)
                    PN_Scroll.VerticalScroll.Value += hour_heigth;
            }
        }

        private static DateTime Klone(DateTime x)
        {
            return new DateTime(x.Year, x.Month, x.Day, x.Hour, x.Minute, 0);
        }

        private void PN_Content_MouseMove(object sender, MouseEventArgs e)
        {
            int Bottom = RoundToMinutes(e.Location.Y, minInterval);
            if (mouseIsDown)
            {
                AdjustScroll(e.Location.Y);
                if (evenement.TargetEvent != null)
                {
                    DateTime Moving = LocationToDateTime(new Point(RoundToMinutes(firstMouseLocation.X, minInterval), Bottom));
                    switch (evenement.TargetPart)
                    {
                        case TargetPart.Top:
                            if (Moving > evenement.TargetEvent.Ending)
                            {
                                evenement.TargetPart = TargetPart.Bottom;
                                evenement.TargetEvent.Starting = Klone(evenement.TargetEvent.Ending);
                                evenement.TargetEvent.Ending = Moving;
                            }
                            else
                                evenement.TargetEvent.Starting = Moving;
                            break;
                        case TargetPart.Bottom:

                            if (Moving < evenement.TargetEvent.Starting)
                            {
                                evenement.TargetPart = TargetPart.Top;
                                evenement.TargetEvent.Ending = Klone(evenement.TargetEvent.Starting);
                                evenement.TargetEvent.Starting = Moving;
                            }
                            else
                                evenement.TargetEvent.Ending = Moving;
                            break;
                        case TargetPart.Inside:
                            int deltaY = RoundToMinutes(e.Location.Y, minInterval) - RoundToMinutes(lastMouseLocation.Y, minInterval);
                            evenement.TargetEvent.Starting = LocationToDateTime(new Point(e.Location.X, RoundToMinutes(Event.HourToPixel(evenement.TargetEvent.Starting.Hour, evenement.TargetEvent.Starting.Minute, PN_Content.Height) + deltaY, minInterval)));
                            evenement.TargetEvent.Ending = LocationToDateTime(new Point(e.Location.X, RoundToMinutes(Event.HourToPixel(evenement.TargetEvent.Ending.Hour, evenement.TargetEvent.Ending.Minute, PN_Content.Height) + deltaY, minInterval)));
                            AjustCurrentWeek();
                            break;
                        default: break;
                    }
                    PN_Content.Refresh();
                }
                else
                {
                    int day = (int)Math.Truncate(firstMouseLocation.X / (PN_Content.Width / 7F));
                    PN_Content.Cursor = Cursors.Cross;
                    Point top = new Point((int)Math.Round(day * PN_Content.Width / 7F), RoundToMinutes(firstMouseLocation.Y, minInterval));
                    Rectangle border = new Rectangle(top.X + 1, (int)Math.Min(top.Y, Bottom), (int)Math.Round(PN_Content.Width / 7F) - 2, (int)Math.Abs(Bottom - top.Y));
                    PN_Content.Refresh();
                    PN_Content.CreateGraphics().DrawRectangle(pen, border);
                }
            }
            else
                evenement.UpdateTarget(e.Location);
            lastMouseLocation = e.Location;
        }

        private DateTime LocationToDateTime(Point location)
        {
            DateTime date = new DateTime(_CurrentWeek.Year, _CurrentWeek.Month, _CurrentWeek.Day);
            int adjust = (location.X < 0 ? (int)(PN_Content.Width / 7F) : 0);
            int days = (int)(Math.Truncate((location.X - adjust) / (PN_Content.Width / 7F)));

            date = date.AddDays(days);
            int Minutes = (int)Math.Max(Event.PixelToMinutes(RoundToMinutes(location.Y, minInterval), PN_Content.Height), 0);
            int Hours = (int)Math.Min((int)Math.Truncate(Minutes / 60f), 23);
            Minutes = Minutes - Hours * 60;
            if (Minutes >= 60)
                Minutes = 59;
            return new DateTime(date.Year, date.Month, date.Day, Hours, Minutes, 0);
        }

        private void ConludeMouseEvent()
        {

            if (mouseIsDown)
            {
                mouseIsDown = false;

                if (evenement.TargetEvent != null)
                {
                    if (evenement.TargetEvent.Starting > evenement.TargetEvent.Ending)
                    {
                        evenement.TargetPart = TargetPart.Top;
                        DateTime d = evenement.TargetEvent.Starting;
                        evenement.TargetEvent.Starting = evenement.TargetEvent.Ending;
                        evenement.TargetEvent.Ending = d;
                    }

                    TimeSpan delta = evenement.TargetEvent.Ending.Subtract(evenement.TargetEvent.Starting);
                    if (delta.Minutes < 30 && delta.Hours == 0)
                    {
                        evenement.TargetEvent.Ending = evenement.TargetEvent.Starting + new TimeSpan(0, 30, 0);
                    }
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.UpdateEventRecord(evenement.TargetEvent);
                }
                else
                {
                    DLG_Events dlg = new DLG_Events();
                    Event Event = new Event();


                    Event.Starting = LocationToDateTime(firstMouseLocation);

                    DateTime date = LocationToDateTime(lastMouseLocation);
                    Event.Ending = new DateTime(Event.Starting.Year, Event.Starting.Month, Event.Starting.Day, date.Hour, date.Minute, 0);

                    if (Event.Starting > Event.Ending)
                    {
                        evenement.TargetPart = TargetPart.Top;
                        DateTime d = Event.Starting;
                        Event.Starting = Event.Ending;
                        Event.Ending = d;

                    }
                    TimeSpan delta = Event.Ending.Subtract(Event.Starting);
                    if (delta.Minutes < 30 && delta.Hours == 0)
                    {
                        Event.Ending = Event.Starting + new TimeSpan(0, 30, 0);
                    }
                    dlg.Event = Event.Klone();
                    if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        TableEvents tableEvents = new TableEvents(ConnexionString);
                        tableEvents.AddEvent(dlg.Event);
                    }
                }
                GetWeekEvents();
                PN_Content.Refresh();
            }

        }

        private void PN_Content_MouseUp(object sender, MouseEventArgs e)
        {
            ConludeMouseEvent();
        }

        private void Decrement_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(-7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }
        private void Increment_Week()
        {
            _CurrentWeek = _CurrentWeek.AddDays(7);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }
        private void Increment_Month()
        {

            _CurrentWeek = _CurrentWeek.AddDays(28);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
            PN_DaysHeader.Refresh();
        }

        private void Decrement_Month()
        {
            _CurrentWeek = _CurrentWeek.AddDays(-28);
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }

        private void GotoCurrentWeek()
        {
            CurrentWeek = DateTime.Now;
            GetWeekEvents();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
            PN_Scroll.VerticalScroll.Value = Event.HourToPixel((int)Math.Max(DateTime.Now.Hour - 3, 0), 0, PN_Hours.Height);
        }

        private void FBTN_DecrementWeek_Click(object sender, EventArgs e)
        {
            Decrement_Week();
        }

        private void FBTN_IncrementWeek_Click(object sender, EventArgs e)
        {
            Increment_Week();
        }

        private void RecurrenceUneFois()
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            Event duplicata = evenement.TargetEvent;
            duplicata.Starting = duplicata.Starting.AddHours(0.5);
            duplicata.Ending = duplicata.Ending.AddHours(0.5);
            tableevents.AddEvent(duplicata);
            GetWeekEvents();
            PN_Content.Refresh();
        }

        private void RecurrenceQuotidienne(int nbrRecurrence)
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            Event duplicata = evenement.TargetEvent;
            for (int i = 1; i <= nbrRecurrence; i++)
            {
                duplicata.Starting = duplicata.Starting.AddDays(1);
                duplicata.Ending = duplicata.Ending.AddDays(1);
                tableevents.AddEvent(duplicata);
                GetWeekEvents();
                PN_Content.Refresh();
            }
        }

        private void RecurrenceHebdomadaire(int nbrRecurrence)
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            Event duplicata = evenement.TargetEvent;
            for (int i = 1; i <= nbrRecurrence; i++)
            {
                duplicata.Starting = duplicata.Starting.AddDays(7);
                duplicata.Ending = duplicata.Ending.AddDays(7);
                tableevents.AddEvent(duplicata);
            }
        }

        private void RecurrenceMensuelle(int nbrRecurrence)
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            Event duplicata = evenement.TargetEvent;
            for (int i = 1; i <= nbrRecurrence; i++)
            {
                duplicata.Starting = duplicata.Starting.AddDays(28);
                duplicata.Ending = duplicata.Ending.AddDays(28);
                tableevents.AddEvent(duplicata);
            }
        }

        private void RecurrenceAnnuelle(int nbrRecurrence)
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            Event duplicata = evenement.TargetEvent;
            for (int i = 1; i <= nbrRecurrence; i++)
            {
                duplicata.Starting = duplicata.Starting.AddDays(364);
                duplicata.Ending = duplicata.Ending.AddDays(364);
                tableevents.AddEvent(duplicata);
            }
        }

        private void DeleteModif()
        {
            DLG_Events dlg = new DLG_Events();
            dlg.Event = evenement.TargetEvent;
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (dlg.delete)
                {
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.DeleteEvent(dlg.Event);
                    evenement.TargetEvent = null;
                    mouseIsDown = false;
                }
                else
                {
                    TableEvents tableEvents = new TableEvents(ConnexionString);
                    tableEvents.UpdateEventRecord(dlg.Event);
                }
            }
            GetWeekEvents();
            PN_Content.Refresh();
        }

        private void PN_Content_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((evenement.TargetEvent != null) && (evenement.TargetPart == TargetPart.Inside) && (e.Button == MouseButtons.Left))
            {
                DeleteModif();
            }
        }
        private void PN_Content_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            KeyPreview = true;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    break;
                case Keys.Right:
                    //action
                    break;
                case Keys.Up:
                    break;
                case Keys.Left:
                    //action
                    break;
                case Keys.Control:
                case Keys.Q:
                    break;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Add: // Augmente le zoom
                    if (!mouseIsDown)
                        if (PN_Content.Height < PN_Frame.Height * 12)
                        {
                            PN_Content.Height += 100;
                            PN_Hours.Height += 100;
                            PN_Content.Refresh();
                            PN_Hours.Refresh();
                        }
                    valeurZoom = ZS_ZoomMaster.Value;
                    break;
                case Keys.Subtract: // Diminue le zoom
                    {
                        if (!mouseIsDown)
                            if (PN_Content.Height > (PN_Frame.Height))
                            {
                                PN_Content.Height -= 100;
                                PN_Hours.Height -= 100;
                                PN_Content.Refresh();
                                PN_Hours.Refresh();
                            }
                        valeurZoom = ZS_ZoomMaster.Value;
                    }
                    break;
                case Keys.Up: // Augmente de un le mois de 1
                    if (!mouseIsDown)
                        Increment_Month();
                    break;
                case Keys.Down: // Réduit de un le mois de 1
                    {
                        if (!mouseIsDown)
                            Decrement_Month();
                    }
                    break;
                case Keys.Right:
                    {
                        if (!mouseIsDown)
                            Increment_Week();
                    }
                    break;
                case Keys.Left:
                    {
                        if (!mouseIsDown)
                            Decrement_Week();
                    }
                    break;
                case Keys.Space:
                    {
                        if (!mouseIsDown)
                            GotoCurrentWeek();
                    }
                    break;
                case Keys.F1:
                    {
                        MessageBox.Show("Bonjour cher utilisateur!\n" +
                                        "Vous avez fait un excellent choix!\n" +
                                        "\n" +
                                        "Voici les touches que vous pouvez appuyer:\n" +
                                        "F1: Menu d'aide\n" +
                                        "Espace: Présente la semaine courante\n" +
                                        "Flèche droite: Présente la semaine suivante\n" +
                                        "Flèche gauche: Présente la semaine précédente\n" +
                                        "Flèche haut: Présente le mois suivant\n" +
                                        "Flèche bas: Présente le mois précédent\n" +
                                        "+: Zoom positif vertical\n" +
                                        "-: Zoom négatif vertical\n" +
                                        "Ctrl+Q: Quitter le programme");
                    }
                    break;
            }
            bool result = base.ProcessCmdKey(ref msg, keyData);
            PN_Scroll.Focus();
            return result;
        }

        private void PN_Content_Resize(object sender, EventArgs e)
        {
            AdjustMinInterval();
        }

        private void PN_Content_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if ((evenement.TargetEvent != null) && (evenement.TargetPart == TargetPart.Inside))
                {
                    EventContextMenu();
                    PN_Content.Refresh();
                }
                else if (evenement.TargetEvent == null)
                {
                    CM_SemaineCourante.Show(Cursor.Position);
                }
            }
        }

        private void CMI_Modifier_Click(object sender, EventArgs e)
        {
            DeleteModif();
        }

        private void CMI_Effacer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Êtes-vous certain de vouloir supprimer cette événement?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                TableEvents tableevents = new TableEvents(ConnexionString);
                tableevents.DeleteEvent(evenement.TargetEvent);
                GetWeekEvents();
                PN_Content.Refresh();
            }

        }

        private void CMI_Reporter_Click(object sender, EventArgs e)
        {
            TableEvents tableevents = new TableEvents(ConnexionString);
            tableevents.DeleteEvent(evenement.TargetEvent);
            evenement.TargetEvent.Starting = evenement.TargetEvent.Starting.AddDays(7);
            evenement.TargetEvent.Ending = evenement.TargetEvent.Ending.AddDays(7);
            tableevents.AddEvent(evenement.TargetEvent);
            GetWeekEvents();
            PN_Content.Refresh();
        }
        private void CMI_Dupliquer_Click(object sender, EventArgs e)
        {

        }

        private void PN_DaysHeader_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CM_EnteteJour.Show(Cursor.Position);
            }
        }

        private void policeDesÉvênementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.MaxSize = 12;
            dlg.Font = Properties.Settings.Default.fontEvenement;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorFontEvenement = dlg.Color;
                Properties.Settings.Default.fontEvenement = dlg.Font;
                Properties.Settings.Default.Save();
            }
            PN_Content.Refresh();
        }

        private void PN_Hours_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                CM_EnteteHeures.Show(Cursor.Position);
            }
        }

        private void policeTitreÉvênementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.MaxSize = 12;
            dlg.Font = Properties.Settings.Default.fontEvenementBold;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.fontEvenementBold = dlg.Font;
                Properties.Settings.Default.Save();
            }
            PN_Content.Refresh();
        }

        private void couleurDeFondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorFondContent;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorFondContent = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_Content.BackColor = Properties.Settings.Default.colorFondContent;
            PN_Scroll.BackColor = Properties.Settings.Default.colorFondContent;
            PN_Hours.BackColor = Properties.Settings.Default.colorFondContent;
            PN_Content.Refresh();

        }

        private void couleurDeLaPoliceDesÉvênementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorFontEvenement;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorFontEvenement = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_Content.Refresh();
        }

        private void CMI_Ligne_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorLignePrincipale;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorLignePrincipale = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_Content.Refresh();
        }

        private void couleurLignesHorizontalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorLigneSecondaire;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorLigneSecondaire = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_Content.Refresh();
        }

        private void PN_Frame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_WeekView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.positionWeekView = this.Location;
            Properties.Settings.Default.tailleWeekView = this.Size;
            Properties.Settings.Default.colorFondContent = this.PN_Content.BackColor;
            Properties.Settings.Default.Save();
        }

        private void PN_Hours_MouseEnter(object sender, EventArgs e)
        {
            ZS_ZoomMaster.Visible = true;
            Point zoom = new Point(0, Cursor.Position.Y - 100);
            ZS_ZoomMaster.Location = zoom;
        }


        private void PN_Hours_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CMI_CouleurFond_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorPN_Days;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorPN_Days = dlg.Color;
                Properties.Settings.Default.colorPN_Frame = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_DaysHeader.BackColor = Properties.Settings.Default.colorPN_Days;
            PN_Frame.BackColor = Properties.Settings.Default.colorPN_Frame;
        }

        private void couleurDeFondToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorPN_Hours;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorPN_Hours = dlg.Color;
                Properties.Settings.Default.Save();
            }
            PN_Hours.BackColor = Properties.Settings.Default.colorPN_Hours;
        }

        private void policeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.MaxSize = 10;
            dlg.Font = Properties.Settings.Default.fontPN_Hours;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.fontPN_Hours = dlg.Font;
                PN_Hours.Refresh();
            }
        }

        private void couleurDeLaPoliceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorFontPN_Hours;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorFontPN_Hours = dlg.Color;
                Properties.Settings.Default.Save();
                PN_Hours.Refresh();
            }
        }

        private void CMI_CouleurLigne_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorLigneDaysHeader;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorLigneDaysHeader = dlg.Color;
                Properties.Settings.Default.Save();
                PN_DaysHeader.Refresh();
            }
        }

        private void dateSemaineCouranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double difference = 0;
            double dansLaSemaine = 0;
            int nbDeSemaines = 0;
            DateSelect dlg = new DateSelect();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                GotoCurrentWeek();
                difference = Math.Round(dlg.dateSemaineCourante.Subtract(DateTime.Now).TotalDays);
                dansLaSemaine = 7 - (Convert.ToInt32(DateTime.Now.DayOfWeek));
                if (difference < dansLaSemaine)
                {
                    GotoCurrentWeek();
                }
                else
                {
                    nbDeSemaines = Convert.ToInt32(difference / 7);
                    _CurrentWeek = _CurrentWeek.AddDays(nbDeSemaines * 7);
                    GetWeekEvents();
                }
                PN_Content.Refresh();
                PN_DaysHeader.Refresh();
            }

        }
        private void couleurDeFondDeLaJournéeCouranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = Properties.Settings.Default.colorPN_Days_Today;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.colorPN_Days_Today = dlg.Color;
                Properties.Settings.Default.Save();
                PN_DaysHeader.Refresh();
            }
        }

        private void ZS_ZoomMaster_ValueChanged(object sender, EventArgs e)
        {
            if (valeurZoom > ZS_ZoomMaster.Value)
            {
                if (PN_Content.Height >= (PN_Frame.Height))
                {
                    PN_Content.Height -= 100;
                    PN_Hours.Height -= 100;
                    PN_Content.Refresh();
                    PN_Hours.Refresh();
                }
            }
            else if (valeurZoom < ZS_ZoomMaster.Value)
            {
                if (PN_Content.Height < PN_Frame.Height * 12)
                {
                    PN_Content.Height += 100;
                    PN_Hours.Height += 100;
                    PN_Content.Refresh();
                    PN_Hours.Refresh();
                }
            }
            valeurZoom = ZS_ZoomMaster.Value;
        }

        private void afficherSemainCouranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GotoCurrentWeek();
            PN_Content.Refresh();
            PN_DaysHeader.Refresh();
        }

        private void Form_WeekView_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void Form_WeekView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Control)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Q && e.Modifiers == (Keys.Control | Keys.Shift | Keys.Alt))
            {
                TableEvents table = new TableEvents(ConnexionString);

                table.DeleteAllEvents();
                GetWeekEvents();
                PN_Content.Refresh();
            }
        }

        private void uneFoisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecurrenceUneFois();
        }

        private void quotidiennementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nbr_Recurrences dlg = new Form_Nbr_Recurrences();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RecurrenceQuotidienne(dlg.nbrRecurrence);
            }
        }

        private void hebdomadairementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nbr_Recurrences dlg = new Form_Nbr_Recurrences();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RecurrenceHebdomadaire(dlg.nbrRecurrence);
            }
        }

        private void mensuellementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nbr_Recurrences dlg = new Form_Nbr_Recurrences();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RecurrenceMensuelle(dlg.nbrRecurrence);
            }
        }

        private void annuellementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Nbr_Recurrences dlg = new Form_Nbr_Recurrences();
            dlg.ShowDialog();
            if (dlg.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                RecurrenceAnnuelle(dlg.nbrRecurrence);
            }
        }
    }
}
