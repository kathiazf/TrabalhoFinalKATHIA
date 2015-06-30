using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Repositorios
{
   public interface IEmprestimoRepository
    {
        Emprestimo Save(Emprestimo emprestimo);
        Emprestimo Get(int id);
        Emprestimo Update(Emprestimo emprestimo);
        Emprestimo Delete(int id);
        List<Emprestimo> Getall();

        bool VerificaSeEmprestimoUtilizado(int Id);
    }
}
