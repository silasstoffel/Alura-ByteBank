using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    // Internal só fica disponível no projeto (biblioteca: ByteBank.Modelo)
    // se não possuir modificador de acesso public, o C# entende que ela é uma class interna
    internal class AutenticacaoHelper
    {
        public bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
