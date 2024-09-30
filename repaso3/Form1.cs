using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso3
{
    public partial class FNotas : Form
    {
        public FNotas()
        {
            InitializeComponent();
        }

        int SumaNotas = 0, CantidadNotas = 0, CantidadAprobados = 0, CantidadPromocion = 0;
        double promedio = 0;
        private object lablePorcentajePromocion;

        private void bAgregar_Click(object sender, EventArgs e)
        {
            int notas = (int)NUDNotas.Value;
            
            if (notas < 0 || notas > 100)
            {
                MessageBox.Show("La nota debe estar entre 0 y 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CantidadNotas++;
            SumaNotas += notas;

            if (notas >= 55)
            {
                CantidadAprobados++;
            }

            if (notas >= 75)
            {
                CantidadPromocion++;
            }

            promedio = (double)SumaNotas / CantidadNotas;

            //actualizar etiquetas

            labelCantidadNotas.Text = "Cantidad de notas: " + CantidadNotas.ToString();
            labelCantidadAprobados.Text = "Cantidad de Aprobados: " + CantidadAprobados.ToString();
            labelCantidadPromocion.Text = "Cantidad en Promoción: " + CantidadPromocion.ToString();
            labelPromedio.Text = "Promedio de todas las notas: " + promedio.ToString("0.00");

            //calcular procentajes
            double porcentajeAprobados = ((double)CantidadAprobados / CantidadNotas) * 100;
            double porcentajePromocion = ((double)CantidadPromocion / CantidadNotas) * 100;
            double porcentajeDesaprobados = 100 - porcentajeAprobados;


            //Mostrar los porcentajes
            labelPorcentajeAprobados.Text = "Porcentaje de Aprobados: " + porcentajeAprobados.ToString("0.00") + "%";
            labelPorcentajePromocion.Text = "Porcentaje en Promoción: " + porcentajePromocion.ToString("0.00") + "%";
            labelPorcentajeDesaprobados.Text = "Porcentaje de Desaprobados: " + porcentajeDesaprobados.ToString("0.00") + "%";
        }

        private void bIniciar_Click(object sender, EventArgs e)
        {
            SumaNotas = 0;
            promedio = 0;
            CantidadNotas = 0;
            CantidadPromocion = 0;
            CantidadAprobados = 0;

            //resetear las etiquetas
            labelCantidadNotas.Text = "Cantidad de notas: 0";
            labelCantidadAprobados.Text = "Cantidad de Aprobados: 0";
            labelCantidadPromocion.Text = "Cantidad en Promoción: 0";
            labelPromedio.Text = "Promedio de todas las notas: 0";

            labelPorcentajeAprobados.Text = "Porcentaje de Aprobados: 0%";
            labelPorcentajePromocion.Text = "Porcentaje en Promoción: 0%";
            labelPorcentajeDesaprobados.Text = "Porcentaje de Desaprobados: 0%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NUDNotas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelNota_Click(object sender, EventArgs e)
        {
        }

        private void labelPorcentajeAprobados_Click(object sender, EventArgs e)
        {

        }

        private void labelPorcentajeDesaprobados_Click(object sender, EventArgs e)
        {

        }

        private void labelPorcentajePromocion_Click_2(object sender, EventArgs e)
        {

        }

        private void labelPorcentajeDesaprobados_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
