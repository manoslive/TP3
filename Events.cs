using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public enum TargetPart { Top, Bottom, Inside, None};
    class Events
    {
        private List<Event> events = new List<Event>();
        public string ConnectionString {get; set;}

        public TargetPart TargetPart { get; set; }

        public Event TargetEvent { get; set; }
        public void Add(Event Event)
        {
            events.Add(Event);
        }

        public void Draw(Graphics DC)
        {
            foreach(Event Event in events)
            {
                Event.Draw(DC);
            }
        }

        public void Clear()
        {
            events.Clear();
        }

        public void UpdateTarget(Point location)
        {
            int tolerence = 5;
            TargetPart = TargetPart.None;
            TargetEvent = null;
            foreach (Event _Event in events)
            {
                Rectangle border = _Event.GetBorder();
                if ((location.X > border.Left) && (location.X < border.Right))
                {
                    if (Math.Abs(location.Y - Event.HourToPixel(_Event.Starting.Hour, _Event.Starting.Minute, _Event.ParentPanel.Height)) <= tolerence)
                    {
                        _Event.ParentPanel.Cursor = Cursors.SizeNS;
                        TargetEvent = _Event;
                        TargetPart = TargetPart.Top;
                        break;
                    }
                    else
                    {
                        if (Math.Abs(location.Y - Event.HourToPixel(_Event.Ending.Hour, _Event.Ending.Minute, _Event.ParentPanel.Height)) <= tolerence)
                        {
                            _Event.ParentPanel.Cursor = Cursors.SizeNS;
                            TargetEvent = _Event;
                            TargetPart = TargetPart.Bottom;
                            break;
                        }
                        else
                        {
                            if (border.Contains(location))
                            {
                                _Event.ParentPanel.Cursor = Cursors.Hand;
                                TargetEvent = _Event;
                                TargetPart = TargetPart.Inside;
                                break;
                            }
                            else
                                _Event.ParentPanel.Cursor = Cursors.Arrow;
                        }
                    }
                }
                else
                    _Event.ParentPanel.Cursor = Cursors.Arrow;
            }
        }
    }
}
