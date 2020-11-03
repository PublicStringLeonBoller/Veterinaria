using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4_Veterinaria_Dueño_Mascota
{
    public partial class Form1 : Form
    {
        double acuPerro, acuGato, acuAraña, acuIguana, acuTot , acuMujeresIguana , acuHombreGato ;
        double acuEdadPerro, acuEdadGato, acuEdadAraña, acuEdadIguana;
        bool max , min;
        string nomPerroViejo, nomMascotaJoven;
        int edadPerroViejo, edadMascotaJoven;
        Mascota perroViejo, mascotaJoven;
        public Form1()
        {
            InitializeComponent();
            acuAraña = acuGato = acuIguana = acuPerro = acuTot = acuMujeresIguana = acuHombreGato = 0;
            acuEdadPerro = acuEdadGato = acuEdadAraña = acuEdadIguana = 0;
            max = min = true;
            nomMascotaJoven = nomPerroViejo = "";
            edadMascotaJoven = edadPerroViejo = 0;
            perroViejo = mascotaJoven = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Dueño du = new Dueño();
            du.NombrePersona = txtNombreDueño.Text;
            if (rbtMasculino.Checked) du.Sexo = 1;
            if (rbtFemenino.Checked) du.Sexo = 2;
            if (rbtOtro.Checked) du.Sexo = 3;
            du.Codigo = Convert.ToInt32(txtCodigo.Text);

            Mascota ma = new Mascota();
            ma.Edad = Convert.ToInt32(txtEdad.Text);
            ma.NombreMascota = txtNombnreMascota.Text;
            ma.Tipo = Convert.ToInt32(cboTipo.SelectedIndex + 1);

            ma.Dueño = du;

            MessageBox.Show(ma.ShowInfoMascota());

            if (ma.Tipo == 1) 
            {
                acuPerro++;
                acuEdadPerro += ma.Edad;
            }
            lblCantPerros.Text = Convert.ToString(acuPerro);
            if (ma.Tipo == 2)
            {
                acuGato++;
                acuEdadGato += ma.Edad;
            }
            lblCantGatos.Text = Convert.ToString(acuGato);
            if (ma.Tipo == 3)
            {
                acuAraña++;
                acuEdadAraña += ma.Edad;
            }
            lblCantArañas.Text = Convert.ToString(acuAraña);
            if (ma.Tipo == 4)
            {
                acuIguana++;
                acuEdadIguana += ma.Edad;
            }
            lblCantIguanas.Text = Convert.ToString(acuIguana);

            acuTot = acuPerro + acuIguana + acuGato + acuAraña;
            if (acuPerro != 0) lblPorcPerros.Text = Math.Round((acuPerro * 100) / acuTot, 2).ToString();
            if (acuGato != 0) lblPorcGatos.Text = Math.Round((acuGato * 100) / acuTot, 2).ToString();
            if (acuAraña != 0) lblPorcArañas.Text = Math.Round((acuAraña * 100) / acuTot, 2).ToString();
            if (acuIguana != 0) lblPorcIguanas.Text = Math.Round((acuIguana * 100) / acuTot, 2).ToString();

            if (acuPerro != 0) lblEdadPromPerros.Text = Convert.ToString(Math.Round(acuEdadPerro / acuPerro, 2));
            if (acuGato != 0) lblEdadPromGatos.Text = Convert.ToString(Math.Round(acuEdadGato / acuGato, 2));
            if (acuAraña != 0) lblEdadPromArañas.Text = Convert.ToString(Math.Round(acuEdadAraña / acuAraña, 2));
            if (acuIguana != 0) lblEdadPromIguanas.Text = Convert.ToString(Math.Round(acuEdadIguana / acuIguana, 2));

            if (ma.Dueño.Sexo == 2 && ma.Tipo == 4) acuMujeresIguana++;
            lblMujeresConIguana.Text = (acuMujeresIguana).ToString();

            if (ma.Dueño.Sexo == 1 && ma.Tipo == 2) acuHombreGato++;
            lblHombresConGato.Text = Convert.ToString(acuHombreGato);

            if (ma.Tipo == 1)
            {
                if (perroViejo == null) perroViejo = ma;
                else if (ma.Edad > perroViejo.Edad) perroViejo = ma;
                lblNombrePerroMasViejo.Text = perroViejo.ShowInfoMascota();
            }
            
            if (mascotaJoven == null) mascotaJoven = ma;
            else if (ma.Edad < mascotaJoven.Edad) mascotaJoven = ma;
            lblNombreMascotaMasJoven.Text = mascotaJoven.ShowInfoMascota();

            //if (max)
            //{
            //    max = false;
            //    nomPerroViejo = du.NombrePersona;
            //    edadPerroViejo = ma.Edad;
            //}
            //if (ma.Tipo == 1)
            //{
            //    if (edadPerroViejo < ma.Edad)
            //    {
            //        edadPerroViejo = ma.Edad;
            //        nomPerroViejo = du.NombrePersona;
            //    }
            //}
            //lblNombrePerroMasViejo.Text = (nomPerroViejo);
            //lblEdadPerroMasViejo.Text = Convert.ToString(edadPerroViejo);

            //if (min)
            //{
            //    min = false;
            //    nomMascotaJoven = du.NombrePersona;
            //    edadMascotaJoven = ma.Edad;
            //}
            //if (edadMascotaJoven > ma.Edad)
            //{
            //    edadMascotaJoven = ma.Edad;
            //    nomMascotaJoven = du.NombrePersona;
            //}
            //lblEdadMascotaMasJover.Text = Convert.ToString(edadMascotaJoven);
            //lblNombreMascotaMasJoven.Text = (nomMascotaJoven);

        }


    }
}
