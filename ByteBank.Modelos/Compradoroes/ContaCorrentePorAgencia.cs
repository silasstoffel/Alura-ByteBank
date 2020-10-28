using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos.Compradoroes
{
    public class ContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
                return 0;

            if (x == null)
                return 1;

            if (y == null)
                return -1;

            /*
             * Modo manual
            if (x.Agencia < y.Agencia)
                return -1;
            if (x.Agencia == y.Agencia)
                return 0;
            return 1;
            */
            // Modo de reaproveitamento de código do .net
            return x.Agencia.CompareTo(y.Agencia);

        }
    }
}
