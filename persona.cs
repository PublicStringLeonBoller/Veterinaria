using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_Veterinaria_Dueño_Mascota
{
    abstract class persona
    {
        protected string nombrePersona;
        protected int sexo;

        public persona()
        {
            nombrePersona = "";
            sexo = 0;
        }

        protected persona(int sexo, string nombrePersona)
        {
            Sexo = sexo;
            NombrePersona = nombrePersona;
        }

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public string NombrePersona
        {
            get { return nombrePersona; }
            set { nombrePersona = value; }
        }
        public string GetSexo()
        {
            switch (Sexo)
            {
                case 1: return "Masculino";
                case 2: return "Femenino";
                case 3: return "Otro";
                default: return "No se ha seleccionado sexo";
            }
        }
        public string ShowInfoPersona()
        {
            return
                $"♥ ¡REGISTRO EXITOSO! ♥\n" +
                $"Nombre: {NombrePersona}\n" +
                $"Sexo: {GetSexo()}";
        }

    }
}
