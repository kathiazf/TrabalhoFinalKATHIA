using Biblioteca.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class Emprestimo : IObjectValidation
    {
        public int Id { get; set; }
        public virtual Livro Livro { get; set; }
        public int LivroId { get; set; }
        public string Usuario { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolução { get; set; }

        public void Validate()
        {
            if (Usuario == string.Empty)
                throw new DominioException("Usuário inválido");

            if (DataEmprestimo >= DateTime.Today)
                throw new DominioException("Data de Emprestimo deve maior que a data atual");

            if (DataDevolução >= DataEmprestimo)
                throw new DominioException("Data de devovolução deve ser maior ou igual a data de emprestimo");
        }
    }
}
