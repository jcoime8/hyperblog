using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIstaTDA
{
    internal class Celular
    {
        string marca;
        string color;
        float tamaño;
        int num_camara;
        string material;
        string modelo;

        public Celular() { }
        public Celular (string marca, string color, float tamaño, int num_camara, string material, string modelo)
        {
            this.marca = marca;
            this.color = color;
            this.tamaño = tamaño;
            this.num_camara = num_camara;
            this.material = material;
            this.modelo = modelo;
        }
        public string Marca { get { return marca; } set { marca = value; } }
        public string Color { get { return color;} set { color = value; } }
        public float Tamaño { get { return tamaño; } set { tamaño = value; } }
        public int Num_camara { get { return num_camara; } set { num_camara = value; } }
        public string Material { get { return material; } set { material = value; } }
        public string Modelo { get { return modelo; } set { modelo = value; } }

        override
            public string ToString()
        {
            return Marca + (", ") + Color + (", ") + Tamaño + (", ") + Num_camara+ (", ") + Material + (", ") + Modelo;
        }
    }
}
