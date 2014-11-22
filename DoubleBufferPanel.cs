using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compact_Agenda
{
    public class DoubleBufferPanel : System.Windows.Forms.Panel
    {
        public DoubleBufferPanel()
        {

            this.DoubleBuffered = true;

            this.SetStyle(System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |

            System.Windows.Forms.ControlStyles.UserPaint |

            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);

            UpdateStyles();

        }

        protected override void OnMouseWheel(System.Windows.Forms.MouseEventArgs e)
        {
            // Faire en sorte que le scroll se fasse aux heures
            int delta = Event.HourToPixel(1, 0, this.VerticalScroll.Maximum);
            MouseEventArgs ee = new MouseEventArgs(e.Button, e.Clicks, e.X, e.Y, (int)Math.Sign(e.Delta) * delta);
            base.OnMouseWheel(ee);
        }
    }
}
