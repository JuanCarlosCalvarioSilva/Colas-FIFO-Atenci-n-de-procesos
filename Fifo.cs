using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO_Atención_de_procesos
{
    class Fifo
    {
        Proceso proceso, pUltimo;

        public void enqueue(Proceso nuevo)
        {
            if (proceso == null)
                proceso = nuevo;
            else
                pUltimo.siguiente = nuevo;
            pUltimo = nuevo;
        }

        public Proceso Dequeue()
        {
            if (proceso.siguiente != null)
                proceso = proceso.siguiente;

            return proceso;
        }

        public Proceso Peek()
        {
            //Proceso proceso;
            if (proceso == null)
                proceso = null;
            else
            {
                if (proceso.tiempo >= 0)
                    return proceso;
                else
                    proceso = Dequeue();
            }          

            return proceso;            
        }
    }
}

