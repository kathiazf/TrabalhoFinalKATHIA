using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Biblioteca.Infra;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for CreateLivroDominioTeste
    /// </summary>
    [TestClass]
    public class CreateLivroDominioTeste
    {
        public CreateLivroDominioTeste()
        {
            Livro livro = new Livro();
            livro.Id = 1;
            livro.Titulo = "Pai Rico, Pai Pobre";
            livro.Editora = "Elsevier";
            livro.Edicao = "80";

            Assert.AreEqual("", string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void LivroCreatedInvalidTest()
        {
            Livro livro = new Livro();
            livro.Titulo = "";
            Validador.Validate(livro);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void LivroCreatedInvalidEditoraTest()
        {
            Livro livro = new Livro();
            livro.Editora = "";
            Validador.Validate(livro);
        }

        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void LivroCreatedInvalidAnoPubTest()
        {
            Livro livro = new Livro();
            livro.Titulo = "";
            livro.anoPublicacao = DateTime.Now;
            Validador.Validate(livro);

        }


        [TestMethod]
        [ExpectedException(typeof(DominioException))]
        public void LivroCreatedInvalidEdicaoTest()
        {
            Livro livro = new Livro();
            livro.Edicao = "";
            Validador.Validate(livro);
        }


        [TestMethod]
        public void CreateLivroTest()
        {
            Livro livro = new Livro();
            livro.Id = 1;
            livro.Titulo = "Pai Rico, Pai Pobre";
            livro.Editora = "ELSEVIER";
            livro.Edicao = "80ª tiagem";
            livro.anoPublicacao = DateTime.Now;

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
