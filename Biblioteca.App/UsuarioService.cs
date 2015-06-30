using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
   public class UsuarioService : IUsuarioService
    {
       private IUsuarioRepository usuarioRepository;

       public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            this.usuarioRepository = usuarioRepository;
        }


        public void CreateUsuario(Dominio.Usuario usuario)
        {
            usuario.Validate();
            usuarioRepository.Save(usuario);
        }

        public void EditUsuario(Dominio.Usuario usuario)
        {
            usuario.Validate();
            usuarioRepository.Update(usuario);
        }

        public void DeleteUsuario(Dominio.Usuario usuario)
        {
            if (usuarioRepository.VerificaSeUsuarioDisponivel(Id))
            {
                throw new AppException("Usuário disponível para emprestimo");
            }

            usuarioRepository.Delete(Id);
        }

        public int Id { get; set; }
    }
}
