using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        Empleados Empleado = new Empleados();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int ID;

            if (!int.TryParse(txtID.Text, out ID))
            {
                errorProvider1.SetError(txtID, "No ingreso un ID valido");
                txtID.Focus();
                return;
            }

            errorProvider1.SetError(txtID, "");

            if (txtNombre.Text == "")
            {
                errorProvider1.SetError(txtNombre, "No ingreso el nombre");
                txtNombre.Focus();
                return;
            }

            errorProvider1.SetError(txtNombre, "");

            if (txtDUI.Text == "")
            {
                errorProvider1.SetError(txtDUI, "No ingreso el DUI");
                txtDUI.Focus();
                return;
            }

            errorProvider1.SetError(txtDUI, "");

            double Salario;

            if (!double.TryParse(txtSalario.Text, out Salario))
            {
                errorProvider1.SetError(txtSalario, "No ingreso el salario de forma correcta");
                txtSalario.Focus();
                return;
            }

            errorProvider1.SetError(txtSalario, "");

            Empleado.Id = Convert.ToInt32(txtID.Text);
            Empleado.Nombre = txtNombre.Text;
            Empleado.Dui = txtDUI.Text;
            Empleado.Salario = Convert.ToDouble(txtSalario.Text);
            labelRegistro.Text = "¡Registro guardado!";
        }

        private void btAFP_Click(object sender, EventArgs e)
        {
            txtAFP.Text = Empleado.AFP(Empleado.Salario).ToString();
        }

        private void btISSS_Click(object sender, EventArgs e)
        {
            txtISSS.Text = Empleado.ISSS(Empleado.Salario).ToString();
        }

        private void btneto_Click(object sender, EventArgs e)
        {
            txtneto.Text = Empleado.neto(Empleado.Salario).ToString();
        }
    }
}
