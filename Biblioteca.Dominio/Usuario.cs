using Biblioteca.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class Usuario : IObjectValidation
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public bool PodeEmprestar { get; set; }



        public void Validate()
        {
            //se for vazio trate a exeção
            if (Nome == string.Empty)
                throw new DominioException("Nome não preenchido");


            if (string.IsNullOrEmpty(Nome))
                throw new DominioException("Nome do usuário em branco");

            if (string.IsNullOrEmpty(Matricula))
                throw new DominioException("Matricula do usuário em branco");


            //if (string.Equals(PodeEmprestar))
            //    throw new DominioException("Não pode emprestar");

      
            //if (bool.PodeEmprestar) == (false))
            //    throw new DominioException("Este valor é maior que 5.000");
   

        }
    }
}
