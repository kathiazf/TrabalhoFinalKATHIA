using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
    public interface IUsuarioService
    {
        void CreateUsuario(Usuario usuario);
        void EditUsuario(Usuario usuario);
        void DeleteUsuario(Usuario usuario);
    }
}
