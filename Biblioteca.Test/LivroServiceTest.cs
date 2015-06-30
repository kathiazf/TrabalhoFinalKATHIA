using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.App;
using Biblioteca.Dominio.Repositorios;
using Moq;
using Biblioteca.Infra;
using Biblioteca.Dominio;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for LivroServiceTest
    /// </summary>
    [TestClass]
    public class LivroServiceTest
        {
            private Livro _livro;

            [TestInitialize]
            public void Setup()
            {
                _livro = ObjectMother.GetLivro();
            }

            [TestMethod]
            public void CreateACustomerValidateServiceTest()
            {
                //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
                var repository = new Mock<ILivroRepository>();

                repository.Setup(r => r.Save(_livro)).Returns(_livro);

                //ARRANGE - Instancia do serviço a ser testado
                ILivroService service = new LivroService(repository.Object);

                //ARRANGE - Criado Mock para simular a validação do Customer
                var validation = new Mock<Livro>();

                validation.As<IObjectValidation>().Setup(livro => livro.Validate());

                //ACTION
                service.CreateLivro(validation.Object);

                //ASSERT
                validation.As<IObjectValidation>().Verify(x => x.Validate());
            }

            [TestMethod]
            public void CreateALivroSaveServiceTest()
            {
                //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
                var validation = new Mock<ILivroRepository>();

                validation.Setup(r => r.Save(_livro)).Returns(_livro);

                //ARRANGE - Instancia do serviço a ser testado
                ILivroService service = new LivroService(validation.Object);

                //ACTION
                service.CreateLivro(_livro);

                //ASSERT
                validation.Verify(r => r.Save(_livro));
            }
    

    }
}
