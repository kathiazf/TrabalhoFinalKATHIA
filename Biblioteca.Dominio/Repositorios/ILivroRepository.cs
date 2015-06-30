using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Repositorios
{
    public interface ILivroRepository
    {
        Livro Save(Livro livro);
       // Livro Create(Livro livro);
        Livro Get(int id);
        Livro Update(Livro livro);
        Livro Delete(int id);
        List<Livro> Getall();

        bool VerificaSeLivroDisponivel(int Id);
    }
}
