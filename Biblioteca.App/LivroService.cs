using Biblioteca.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
   public class LivroService : ILivroService
    {
       private ILivroRepository livroRepository;

       public LivroService(ILivroRepository livroRepository)
       {
           this.livroRepository = livroRepository;
       }

       public void CreateLivro(Dominio.Livro livro)
       {
           livro.Validate();
           livroRepository.Save(livro);
       }

       public void EditLivro(Dominio.Livro livro)
       {
           livro.Validate();
           livroRepository.Update(livro);
       }

       public void DeleteLivro(int Id)
       {
           if (livroRepository.VerificaSeLivroDisponivel(Id))
           {
               throw new AppException("Existe referencia do autor em livros");
           }

           livroRepository.Delete(Id);
       }

    }
}
