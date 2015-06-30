using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
   public class UsuarioRepository : IUsuarioRepository
    {
       private BibliotecaContext context;

       public UsuarioRepository(BibliotecaContext context) 
       {
           this.context = context;
       }
        public Biblioteca.Dominio.Usuario Save(Biblioteca.Dominio.Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            return usuario;
        }

        public Biblioteca.Dominio.Usuario Get(int id)
        {
            //find pesquisar
           return context.Usuarios.Find(id);
            
        }

        public Biblioteca.Dominio.Usuario Update(Biblioteca.Dominio.Usuario usuario)
        {
            DbEntityEntry entry = context.Entry(usuario);
            entry.State = EntityState.Modified;
            context.SaveChanges();
            return usuario;
        }

        public Biblioteca.Dominio.Usuario Delete(int id)
        {
            Usuario usuario = context.Usuarios.Find(id);
            Usuario deletedUsuario = context.Usuarios.Remove(usuario);
            context.SaveChanges();
            return deletedUsuario;
        }

       //busca todos os registros da tabela
        public List<Usuario> Getall()
        {
            return context.Usuarios.ToList();
        }


        public bool VerificaSeUsuarioDisponivel(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
