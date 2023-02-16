using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructHM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1
            //Vector3D vector = new Vector3D(10, 20, 30);
            //vector.PrintVector();
            //vector = Vector3D.Multiply(vector, 5);
            //vector.PrintVector();
            //vector = Vector3D.AddVectors(vector, new Vector3D(2,16,2022));
            //vector.PrintVector();
            //vector = Vector3D.SubstractVectors(vector, new Vector3D(100, 200, 3000));
            //vector.PrintVector();
            #endregion
            #region #2
            //uint a = 322;
            //string str = Binary.DectoBin(a);
            //Console.WriteLine(str);
            //a = Binary.BintoDec(str);
            //Console.WriteLine(a);
            //str = Binary.DectoHex(a);
            //Console.WriteLine(str);
            #endregion
            #region #3
            
            RBGColour colour = new RBGColour(255,116,100);
            colour.PrintRBG();
            Console.WriteLine();
            string str = colour.RGBtoHSL();
            Console.WriteLine(str);
            Console.WriteLine();
            str = colour.RGBtoCMYK();
            Console.WriteLine(str);

            #endregion

        }
    }
}
