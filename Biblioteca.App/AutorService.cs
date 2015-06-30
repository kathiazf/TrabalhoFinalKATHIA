using Biblioteca.Dominio.Repositorios;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.App
{
    public class AutorService : IAutorService
    {
        private IAutorRepository autorRepository;


        public AutorService(IAutorRepository autorRepository)
        {
            this.autorRepository = autorRepository;
        }

        public void CreateAutor(Dominio.Autor autor)
        {
            autor.Validate();
            autorRepository.Save(autor);
        }

        public void EditAutor(Dominio.Autor autor)
        {
            autor.Validate();
            autorRepository.Update(autor);
        }

        public void DeleteAutor(int Id)
        {
            if (autorRepository.VerificaSeAutorUtilizado(Id))
            {
                throw new AppException("Exiteste referencia do autor em livros");
            }

            autorRepository.Delete(Id);
        }
    }
}
