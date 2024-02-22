using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_20242202
{
    internal class Endereco
    {
        private string rua { get; set; }
        private int numero { get; set; }

        public Endereco(string rua, int numero)
        {
            this.rua = rua;
            this.numero = numero;
        }
    }
}
