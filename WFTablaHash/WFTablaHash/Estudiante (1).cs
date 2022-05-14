using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFArbolBinario
{
    class Estudiante : Comparador
    {
        int Carnet { get; set; }
        String Nombre { get; set; }

        public Estudiante(int carnet, String nombre)
        {
            Carnet = carne;
            Nombre = nombre;
        }

        bool Comparador.igualQue(Object op2)
        {
            Estudiante p2 = (Estudiante)op2;
            return Carne == p2.Carnet;
        }

        bool Comparador.menorQue(Object op2)
        {
            Estudiante p2 = (Estudiante)op2;
            //if (Nombre.CompareTo(p2.Nombre) < 0)
            //    return true;
            //else
            //    return false;
            return Carnet < p2.Carnet;
        }

        bool Comparador.menorIgualQue(Object op2)
        {
            Estudiante p2 = (Estudiante)op2;
            return Carnet <= p2.Carnet;
        }

        bool Comparador.mayorQue(Object op2)
        {
            Estudiante p2 = (Estudiante)op2;
            return Carnet > p2.Carnet;
        }

        bool Comparador.mayorIgualQue(Object op2)
        {
            Estudiante p2 = (Estudiante)op2;
            return Carnet > p2.Carnet;
        }

        public override string ToString()
        {
            return "(" + Carnet + ")";
        }
    }

}
