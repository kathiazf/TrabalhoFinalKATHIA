using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Infra;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for CreateDominioTeste
    /// </summary>
    [TestClass]
    public class CreateUsuarioDominioTeste
    {
        public CreateUsuarioDominioTeste()
        {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "João Paulo Souza";
            usuario.Matricula = "150456";
            usuario.PodeEmprestar = true;

            Assert.AreEqual("", string.Empty);
        }



        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioNameInvalidTest()
        {
                Usuario usuario = new Usuario();
                Validador.Validate(usuario);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioCreatedInvalidTest()
        {
            Usuario usuario = new Usuario();
            usuario.Nome = "";
            Validador.Validate(usuario);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioMatriculaInvalidTest()
        {
            Usuario usuario = new Usuario();
            usuario.Matricula = "";
            Validador.Validate(usuario);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void UsuarioPodeEmprestarTest()
        {
            Usuario usuario = new Usuario();
            usuario.PodeEmprestar = false;
            Validador.Validate(usuario);

        }

        [TestMethod]
        public void CreateUsuarioTest()
        {
            Usuario usuario = new Usuario();
            usuario.Id = 1;
            usuario.Nome = "Luis Santos";
            usuario.Matricula= "150412";
            usuario.PodeEmprestar = true;
           
        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

       
    }
}
