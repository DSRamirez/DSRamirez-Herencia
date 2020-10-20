using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDocente_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            lblDNI.Visible = true;
            lblFN.Visible = true;
            lblS.Visible = true;
            lblMat.Visible = true;
            lblLeg.Visible = true;

            Persona Docente;
            Docente = new Persona(txtNombre.Text, Convert.ToInt32(txtDNI.Text), dateTimePicker1.Value, txtS.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNombre.Visible = true;
            lblDNI.Visible = true;
            lblFN.Visible = true;
            lblS.Visible = true;
            lblCar.Visible = true;
            lblLeg.Visible = true;

            Persona Alumno;
            Alumno = new Persona(txtNombre.Text, Convert.ToInt32(txtDNI.Text), dateTimePicker1.Value, txtS.Text);
        }
    }
}
