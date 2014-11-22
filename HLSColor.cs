using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PasswordKeeper
{
    ///////////////////////////////////////////////////////////////////////////////////////
    // C L A S S   H L S C o l o r
    ///////////////////////////////////////////////////////////////////////////////////////
    // Source de l'alogorithme
    // http://www.had2know.com/technology/hsl-rgb-color-converter.html
    // Implantion et adaption:
    // Nicolas Chourot
    // Département d'informatique
    // Collège Lionel Groulx
    // Date: octobre 2014
    ///////////////////////////////////////////////////////////////////////////////////////
    public class HLSColor
    {
        private double _Hue;
        private double _Luminosity;
        private double _Saturation;

        public double Hue
        {
            get { return _Hue; }
            set { _Hue = ((value >= 0) && (value <= 1) ? value : _Hue); }
        }

        public double Luminosity
        {
            get { return _Luminosity; }
            set { _Luminosity = ((value >= 0) && (value <= 1) ? value : _Luminosity); }
        }

        public double Saturation
        {
            get { return _Saturation; }
            set { _Saturation = ((value >= 0) && (value <= 1) ? value : _Saturation); }
        }

        public HLSColor()
        {
            _Hue        = 0;
            _Luminosity = 0.5;
            _Saturation = 1.0;
        }

        public HLSColor(double h, double l, double s)
        {
            Hue = h;
            Luminosity = l;
            Saturation = s;
        }

        public HLSColor(Color RGB_Color)
        {
            RGBToHLS(RGB_Color, out _Hue, out _Luminosity, out _Saturation);
        }

        public HLSColor(HLSColor copy)
        {
            Hue        = copy.Hue;
            Luminosity = copy.Luminosity;
            Saturation = copy.Saturation;
        }

        public Color ToRGB()
        {
            return HLSToRGB(_Hue, _Luminosity, _Saturation);
        }

        public static void RGBToHLS(Color color, out double H, out double L, out double S)
        {
            double R = color.R;
            double G = color.G;
            double B = color.B;

            double _Min = Math.Min(Math.Min(R, G), B);
            double _Max = Math.Max(Math.Max(R, G), B);
            double _Delta = (_Max - _Min) / 255D;

            H = 0;
            S = 0;
            L = (_Max + _Min) / 510D;

            if (L > 0)
            {
                double LL = (1 - Math.Abs(L * 2 - 1));
                if (LL > 0) 
                    S = _Delta / LL;

                double X = Math.Abs(R * R + G * G + B * B - R * G - R * B - G * B);
                if (X > 0)
                {
                    if (G >= B)
                        H = Math.Acos((R - G / 2 - B / 2) / Math.Sqrt(X));
                    else
                        H = Math.PI * 2 - Math.Acos((R - G / 2 - B / 2) / Math.Sqrt(X));

                    H /= Math.PI * 2;
                }
            }
        }

        public static Color HLSToRGB(double H, double L, double S)
        {
            double d = S * (1 - Math.Abs(2 * L - 1));
            double m = 255D * (L - d / 2D);
            H *= 360D;
            double x = d * (1 - Math.Abs(H / 60D % 2 - 1));
            double R, G, B;
            if (H < 60)
            {
                R = 255 * d + m;
                G = 255 * x + m;
                B = m;
            }
            else if (H < 120)
            {
                R = 255 * x + m;
                G = 255 * d + m;
                B = m;
            }
            else if (H < 180)
            {
                R = m;
                G = 255 * d + m;
                B = 255 * x + m;
            }
            else if (H < 240)
            {
                R = m;
                G = 255 * x + m;
                B = 255 * d + m;
            }
            else if (H < 300)
            {
                R = 255 * x + m;
                G = m;
                B = 255 * d + m;
            }
            else
            {
                R = 255 * d + m;
                G = m;
                B = 255 * x + m;
            }
            return Color.FromArgb((byte)Math.Round(R), (byte)Math.Round(G), (byte)Math.Round(B));
        }
    }
}
