using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConjuntosApp
{
    class Conjunto
    {
        public List<Object> lista { get; set; }

        public Conjunto()
        {
            lista = new List<object>();
        }


        public bool Continencia(Object elemento)
        {

            if (lista.Contains(elemento))
                return true;
            
            return false;
        }

        public bool Pertinencia(List<Object> elementos)
        {
            foreach(var item in elementos)
            {
                if (!lista.Contains(item))
                {
                    break;
                }
               
            }

            return true ;
        }


    }
}
