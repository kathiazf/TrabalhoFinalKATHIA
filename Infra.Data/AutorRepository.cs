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
   public class AutorRepository : IAutorRepository
    {

       private BibliotecaContext _context;

       public AutorRepository()
       {
           this._context =  new BibliotecaContext();
       }

        public Biblioteca.Dominio.Autor Save(Autor autor)
        {
            var newAutor = _context.Autores.Add(autor);
            _context.SaveChanges();
            return newAutor;
        }

        public Biblioteca.Dominio.Autor Get(int id)
        {
            return _context.Autores.Find(id);
        }

        public Biblioteca.Dominio.Autor Update(Autor autor)
        {
            _context.Entry(autor).State = EntityState.Modified;
            _context.SaveChanges();
            return autor;
        }

        public Biblioteca.Dominio.Autor Delete(int id)
        {
            Autor autor= _context.Autores.Find(id);
           
            _context.Entry(autor).State = EntityState.Deleted;
            _context.SaveChanges();
            return autor;
        }

        public List<Biblioteca.Dominio.Autor> Getall()
        {
            return _context.Autores.ToList();
        }

        public bool VerificaSeAutorUtilizado(int autorCodigo)
        {
            var livros = _context.Livros.Where(c => c.AutorId.Equals(autorCodigo)).ToList();
            //verificação de mais de um registro
            if (livros.Count > 0)
                return true;

            return false;

        }
    }
}
