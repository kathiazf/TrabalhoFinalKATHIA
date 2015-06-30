using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class EmprestimoRepository 
    {
        private BibliotecaContext _context;
        private DbSet _dbset;

        public EmprestimoRepository(BibliotecaContext context)
        {
            this._context = context;
            this._dbset = _context.Set<Emprestimo>();
        }

         public Biblioteca.Dominio.Emprestimo Save(Biblioteca.Dominio.Emprestimo emprestimo)
         {
             _context.Emprestimos.Add(emprestimo);
             _context.SaveChanges();

             return emprestimo;
         }

         public Biblioteca.Dominio.Emprestimo Get(int id)
         {
             return _context.Emprestimos.Find(id);
         }

         public Biblioteca.Dominio.Emprestimo Update(Biblioteca.Dominio.Emprestimo emprestimo)
         {
             _dbset.Attach(emprestimo);
             _context.Entry(emprestimo).State = EntityState.Modified;
             _context.SaveChanges();
             return emprestimo;
         }

         public Biblioteca.Dominio.Emprestimo Delete(int id)
         {
             Emprestimo emprestimo = _context.Emprestimos.Find(id);

             _dbset.Attach(emprestimo);
             _context.Entry(emprestimo).State = EntityState.Deleted;
             _context.SaveChanges();
             return emprestimo;
         }

         public List<Biblioteca.Dominio.Emprestimo> Getall()
         {
             return _context.Emprestimos.ToList();
         }


         public bool VerificaSeEmprestimoDisponivel(int Id)
         {
             //var livros = _context.Emprestimos.Where(c => c.LivroId.Equals(Id)).ToList();
             var emprestimos = _context.Emprestimos.Where(c => c.Id.Equals(Id)).ToList();
             //verificação se livro esta emprestadp
             if (emprestimos.Count > 0)
                 return true;

                 return false;
         }

    }
}
