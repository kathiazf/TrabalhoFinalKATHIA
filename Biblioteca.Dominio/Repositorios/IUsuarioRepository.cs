using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Repositorios
{
    public interface IUsuarioRepository
    {
        Usuario Save(Usuario usuario);
        Usuario Get(int id);
        Usuario Update(Usuario usuario);
        Usuario Delete(int id);
        List<Usuario> Getall();

        bool VerificaSeUsuarioDisponivel(int Id);
    }
}
