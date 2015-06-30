using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Infra
{
    public class Validador
    {
        public static void Validate(IObjectValidation domainObject)
        {
            domainObject.Validate();
        }
    }
}
