using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio.Repositorios;
using Moq;
using Biblioteca.Dominio;
using Biblioteca.Infra;
using Biblioteca.App;

namespace Biblioteca.Test
{

    [TestClass]
    public class AutorServiceTest
    {
       
        private Autor _autor;

        [TestInitialize]
        public void Setup()
        {
            _autor = ObjectMother.GetAutor();
        }

           [TestMethod]
           public void CreateAAutorValidateServiceTest()
           {
               //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
               var repository = new Mock<IAutorRepository>();

               repository.Setup(r => r.Save(It.IsAny<Autor>())).Returns(It.IsAny<Autor>());

               //ARRANGE - Instancia do serviço a ser testado
               IAutorService service = new AutorService(repository.Object);

               //ARRANGE - Criado Mock para simular a validação do Customer
               var validation = new Mock<Autor>();

               validation.As<IObjectValidation>().Setup(x => x.Validate());

               //ACTION
               service.CreateAutor(validation.Object);

               //ASSERT
               validation.As<IObjectValidation>().Verify(x => x.Validate());
           }


           [TestMethod]
           public void RetrieveAutorServiceTest()
           {

               //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
               var validation = new Mock<IAutorRepository>();

               validation.Setup(r => r.Save(_autor)).Returns(_autor);

               //ARRANGE - Instancia do serviço a ser testado
               IAutorService service = new AutorService(validation.Object);

               //ACTION
               service.CreateAutor(_autor);

               //ASSERT
               validation.Verify(r => r.Save(_autor));
            
           }

       


    }
}
