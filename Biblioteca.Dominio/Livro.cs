using Biblioteca.Infra;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio
{
    public class Livro : IObjectValidation
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Edicao { get; set; }
        public DateTime anoPublicacao { get; set; }

        [ForeignKey("AutorId")]
        public virtual Autor Autor { get; set; }
        public int AutorId { get; set; }
      
        public void Validate()
        {

            //se for vazio trate a exeção
            if (Titulo == string.Empty)
                throw new DominioException("Titulo do livro não foi preenchido");

            if (Editora == string.Empty)
                throw new DominioException("Editora do livro não foi preenchido");

            if (Edicao == string.Empty)
                throw new DominioException("Edição do Livro não foi preenchida");

            if(Autor == null)
                throw new DominioException("Autor nao informado");

            if (anoPublicacao > DateTime.Today)
                throw new DominioException("Data de criação inválida.");

        }

        public override string ToString()
        {
            return string.Format("Id: {0} - Titulo: {1} - Autor: {2}, - Editora: {3}", Id, Titulo, Autor.Nome, Editora);
        }
    }
}
