using Biblioteca.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
    public interface IEmprestimoService
    {
        void CreateEmprestimo(Emprestimo emprestimo);
        void EditEmprestimo(Emprestimo emprestimo);
        void DeleteEmprestimo(int Id);
    }
}
