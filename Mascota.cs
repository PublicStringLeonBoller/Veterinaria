using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._4_Veterinaria_Dueño_Mascota
{
    class Mascota
    {
        private int edad;
        private string nombreMascota;
        private int tipo;
        private Dueño dueño;

        public Mascota()
        {
            edad = 0;
            nombreMascota = "";
            tipo = 0;
            
        }

        public Mascota(Dueño dueño, int tipo, string nombreMascota, int edad)
        {
            Dueño = dueño;
            Tipo = tipo;
            NombreMascota = nombreMascota;
            Edad = edad;
        }

        public Dueño Dueño
        {
            get { return dueño; }
            set { dueño = value; }
        }
        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string NombreMascota
        {
            get { return nombreMascota; }
            set { nombreMascota = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string GetTipoMascota()
        {
            switch (Tipo)
            {
                case 1: return "Perro";
                case 2: return "Gato";
                case 3: return "Araña";
                case 4: return "Iguana";
                default: return "No se ha seleccionado una mascota";
            }
        }
        public string ShowInfoMascota()
        {
            return
                $"{dueño.ShowInfoDueño()}\n" +
                $"-------- ☻ ☻ ☻ ☻ -----------\n" +
                $"Informacion De La Mascota \n" +
                $"Edad: {Edad}\n" +
                $"Nombre: {nombreMascota}\n" +
                $"Tipo: {GetTipoMascota()}\n" +
                $" ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥";
        }

    }
}
