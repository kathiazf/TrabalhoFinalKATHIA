using Biblioteca.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dominio
{
    public class Autor : IObjectValidation
    {

        public Autor()
        {
            Autores = new List<Autor>();
        }

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }
        public string CodigoCutter { get; set; } // Codigo Cutter tabela de códigos que indicam a autoria de uma obra literária
        public virtual ICollection<Autor> Autores { get; set; }

        public void Validate()
        {
            //se for vazio trate a exeção
            if(Nome == string.Empty)
                throw new DominioException("Nome não preenchido");


            if (string.IsNullOrEmpty(Nome))
                throw new DominioException("Nome do Autor em branco");

            if (string.IsNullOrEmpty(CodigoCutter))
                throw new DominioException("Codigo Cutter do autor em branco");

        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Nome: {1} - Cutter: {2}", Id, Nome, CodigoCutter);
        }
    }



}
