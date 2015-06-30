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
    public class LivroRepository : ILivroRepository
    {
        private BibliotecaContext _context;
        

       public LivroRepository(BibliotecaContext context) 
       {
           this._context = context;
       }

       public LivroRepository()
       {
           this._context = new BibliotecaContext();
       }


        public Biblioteca.Dominio.Livro Save(Livro livro)
        {
            var newLivro = _context.Livros.Add(livro);
            _context.SaveChanges();
           return newLivro;
        }

        public Biblioteca.Dominio.Livro Get(int id)
        {
            return _context.Livros.Find(id);
        }

        public Biblioteca.Dominio.Livro Update(Biblioteca.Dominio.Livro livro)
        {
            
            _context.Entry(livro).State = EntityState.Modified;
            _context.SaveChanges();
            return livro;
        }

        public Biblioteca.Dominio.Livro Delete(int id)
        {
            Livro livro = _context.Livros.Find(id);

        
            _context.Entry(livro).State = EntityState.Deleted;
            _context.SaveChanges();
            return livro;
        }

        public List<Biblioteca.Dominio.Livro> Getall()
        {
            return _context.Livros.ToList();
        }


        public bool VerificaSeLivroDisponivel(int Id)
        {
            var livros = _context.Emprestimos.Where(c => c.LivroId.Equals(Id)).ToList();
            //verificação se livro esta emprestado
            if (livros.Count > 0)
                return true;

            return false;
        }
    }
}
