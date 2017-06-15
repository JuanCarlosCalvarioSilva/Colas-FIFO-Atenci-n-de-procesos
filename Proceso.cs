using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atención_de_procesos
{
    class Proceso
    {     
        private int _tiempo;
        public int tiempo
        {
            set { _tiempo = value; }
            get { return _tiempo; }
        }

        private Proceso _siguiente;
        public Proceso siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }
    }
}
