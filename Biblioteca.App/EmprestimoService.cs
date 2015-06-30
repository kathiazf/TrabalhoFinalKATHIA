using Biblioteca.Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
    public class EmprestimoService : IEmprestimoService
    {
        private IEmprestimoRepository emprestimoRepository;

        public EmprestimoService(IEmprestimoRepository emprestimoRepository)
        {
            this.emprestimoRepository = emprestimoRepository;
        }

        public void CreateEmprestimo(Dominio.Emprestimo emprestimo)
        {
            emprestimo.Validate();
            emprestimoRepository.Save(emprestimo);
        }

        public void EditEmprestimo(Dominio.Emprestimo emprestimo)
        {
            emprestimo.Validate();
            emprestimoRepository.Update(emprestimo);
        }

        public void DeleteEmprestimo(int Id)
        {
            if (emprestimoRepository.VerificaSeEmprestimoUtilizado(Id))
            {
                throw new AppException("Exiteste referencia do emprestimo no livro");
            }

            emprestimoRepository.Delete(Id);
        }
    }

}
