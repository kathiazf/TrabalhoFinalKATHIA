using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Dominio.Repositorios
{
    public interface IAutorRepository
    {
        Autor Save(Autor autor);
        Autor Get(int id);
        Autor Update(Autor autor);
        Autor Delete(int id);
        List<Autor> Getall();


       bool VerificaSeAutorUtilizado(int autorCodigo);
        
    }
}
