using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4_Veterinaria_Dueño_Mascota
{
    class Dueño : persona
    {
        private Int32 codigo;

        public Dueño() : base()
        {
            codigo = 0;
        }

        public Dueño(int sexo, string nombrePersona, int codigo) : base(sexo,nombrePersona)
        {
            Codigo = codigo;
        }

        public Int32 Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string ShowInfoDueño()
        {
            return
            $"{base.ShowInfoPersona()}\n" +
                $"Codigo: {Codigo}";
        }

    }
}
