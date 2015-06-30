using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data
{
    public class BibliotecaContext : DbContext

    {
        public BibliotecaContext()
            : base("BibliotecaDatabase")
        {
			//Inicianlizando o banco de dados
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BibliotecaContext>());
        }
		/// <summary>
		/// passando as classes para o banco de dados
		/// </summary>
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
