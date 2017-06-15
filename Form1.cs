using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_FIFO_Atención_de_procesos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        int contadorPAtendido, contadorCVacios;

        private void txtAtender_Click(object sender, EventArgs e)
        {
            Random ciclosNecesariosPorProceso = new Random();
            Random probabilidad = new Random();

            Fifo colaFifo = new Fifo();

            for (int ciclo = 1; ciclo <= 200; ciclo++) //200
            {
                if (probabilidad.Next(1, 100) <= 25)
                {
                    Proceso nuevo = new Proceso();
                    nuevo.tiempo = ciclosNecesariosPorProceso.Next(4, 14);
                    colaFifo.enqueue(nuevo);
                }            
                if (colaFifo.Peek() != null)
                {
                    colaFifo.Peek().tiempo--;
                    if (colaFifo.Peek().tiempo == 0)
                        contadorPAtendido++;
                    //colaFifo.Dequeue();
                }
                else
                    contadorCVacios++;
            }
            txtResutados.Text = "";
            txtResutados.Text = "Procesos atendidos = " + contadorPAtendido + Environment.NewLine + "Ciclos vacios = " + contadorCVacios;
        }
    }
}
