using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructHM
{
    public struct Vector3D
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }

        public Vector3D(int x, int y, int z):this() { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void PrintVector() => Console.WriteLine(x + "," + y + "," + z);

        static public Vector3D Multiply(Vector3D vector, int figure)
        {
            return new Vector3D(vector.x * figure, vector.y * figure, vector.z * figure);
        }
        static public Vector3D AddVectors(Vector3D vector, Vector3D vector2)
        {
            return new Vector3D(vector.x + vector2.x, vector.y + vector2.y, vector.z + vector2.z);
        }
        static public Vector3D SubstractVectors(Vector3D vector, Vector3D vector2)
        {
            return new Vector3D(vector.x - vector2.x, vector.y - vector2.y, vector.z - vector2.z);
        }
    }
}
