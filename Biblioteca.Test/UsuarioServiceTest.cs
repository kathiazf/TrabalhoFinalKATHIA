using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using Moq;
using Biblioteca.App;
using Biblioteca.Infra;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for UsuarioServiceTest
    /// </summary>
    [TestClass]
    public class UsuarioServiceTest
    {

        private Usuario _usuario;

        [TestInitialize]
        public void Setup()
        {
            
        }

        [TestMethod]
        public void CreateAUsuarioValidateServiceTest()
        {
            var _usuario = ObjectMother.GetUsuario();
            //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
            var repository = new Mock<IUsuarioRepository>();

            repository.Setup(r => r.Save(_usuario)).Returns(_usuario);

            //ARRANGE - Instancia do serviço a ser testado
            IUsuarioService service = new UsuarioService(repository.Object);

            //ARRANGE - Criado Mock para simular a validação do Customer
            var validation = new Mock<Usuario>();

            validation.As<IObjectValidation>().Setup(usuario => usuario.Validate());

            //ACTION
            service.CreateUsuario(validation.Object);

            //ASSERT
            validation.As<IObjectValidation>().Verify(x => x.Validate());
        }

        [TestMethod]
        public void RetrieveUsuarioServiceTest()
        {
            var _usuario = ObjectMother.GetUsuario();
            //ARRANGE - Criado Mock do Repositório para simular a persistência de dados
            var validation = new Mock<IUsuarioRepository>();

            validation.Setup(r => r.Save(_usuario)).Returns(_usuario);

            //ARRANGE - Instancia do serviço a ser testado
            IUsuarioService service = new UsuarioService(validation.Object);

            //ACTION
            service.CreateUsuario(_usuario);

            //ASSERT
            validation.Verify(r => r.Save(_usuario));

        }




    }
}
