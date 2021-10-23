using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectografico1
{
    public class Escenario
    {
        List<Objeto> _objetos;

        public Escenario()
        {
            _objetos = new List<Objeto>();
        }

        public Escenario(List<Objeto> objetos) {
            _objetos = new List<Objeto>(objetos.Count);
            objetos.ForEach((item) =>
            {
                _objetos.Add(new Objeto(item));
           });
        }

        
    }


}
