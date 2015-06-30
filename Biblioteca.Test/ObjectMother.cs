using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Test
{
    public static class ObjectMother
    {
        public static Autor GetAutor()
        {
            Autor autor = new Autor();
            autor.Nome = "Kathia Zanotto";
            autor.CodigoCutter = "AB87";
            return autor;

        }

        //public static UsuarioRepositoryTest GetUsuario()
        //{
        //    Usuario usuario = new Usuario();
        //    usuario.Nome = "Jose Carlos Oliveira";
        //    usuario.Matricula = "126789";
        //    usuario.PodeEmprestar = true;

        // return usuario;
        // }


        public static Usuario GetUsuario()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "João Paulo de Assis";
            usuario.Matricula = "123456";
            return usuario;
        }



        public static Livro GetLivro()
        {
            Livro livro = new Livro();
            livro.Titulo = "Aprendendo C#";
            livro.Edicao = "2012";
            livro.Editora = "Abril";
            livro.anoPublicacao = DateTime.Today;
            return livro;
        }

        //public static object GetEmprestimo()
        //{
        //    Emprestimo emprestimo = new Emprestimo();
        //    emprestimo.Id = 1;
        //    emprestimo.DataEmprestimo = DateTime.Today;
        //}
    }
}
