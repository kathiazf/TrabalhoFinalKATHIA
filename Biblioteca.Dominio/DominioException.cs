using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class DominioException : Exception
    {
        public DominioException(string menssage)
            : base(menssage)
        { 
        
        }
    }
}
