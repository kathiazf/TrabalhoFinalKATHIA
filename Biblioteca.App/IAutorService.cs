using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
    public interface IAutorService
    {
        void CreateAutor(Autor autor);
        void EditAutor(Autor autor);
        void DeleteAutor(int Id);

       
    }
}
