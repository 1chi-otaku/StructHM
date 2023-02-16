using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StructHM
{
    public struct RBGColour
    {
        short r, g, b;

        public RBGColour(short r, short g, short b):this() { 
        
            if(r > 0 && r< 256)
                this.r = r;
            if (g > 0 && g < 256)
                this.g = g;
            if (b > 0 && b < 256)
                this.b = b;
        }
        public void PrintRBG() => Console.WriteLine("R: " + r + "\nG: " + g + "\nB: " + b);

        public string RGBtoHEX()
        {
           return r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
        }
        public string RGBtoCMYK()
        {
            float rd = r / 255f;
            float gd = g / 255f;
            float bd = b / 255f;
         
            float k = (1 - Math.Max(Math.Max(rd,gd),bd));
            float c = (1 - rd - k) / (1 - k) * 100;
            float m = (1 - gd - k) / (1 - k) * 100;
            float y = (1 - bd - k) / (1 - k) * 100;
            return "C: " + Math.Round(c) + "\nM: " + Math.Round(m) + "\nY: " + Math.Round(y) + "\nK: " + Math.Round(k);
        }
        public string RGBtoHSL()
        {

            float _R = (r / 255f);
            float _G = (g / 255f);
            float _B = (b / 255f);

            float _Min = Math.Min(Math.Min(_R, _G), _B);
            float _Max = Math.Max(Math.Max(_R, _G), _B);
            float _Delta = _Max - _Min;

            float H = 0;
            float S = 0;
            float L = (float)((_Max + _Min) / 2.0f);

            if (_Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(_Delta / (_Max + _Min));
                }
                else
                {
                    S = (float)(_Delta / (2.0f - _Max - _Min));
                }


                if (_R == _Max)
                {
                    H = (_G - _B) / _Delta;
                }
                else if (_G == _Max)
                {
                    H = 2f + (_B - _R) / _Delta;
                }
                else if (_B == _Max)
                {
                    H = 4f + (_R - _G) / _Delta;
                }
            }
            H *= 100;
            S *= 100;
            L *= 100;

            return " " + Math.Round(H) + " " + Math.Round(S) + " " + Math.Round(L);
        }

    }
}
