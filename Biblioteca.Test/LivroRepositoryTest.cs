using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca.Dominio;
using Infra.Data;
using System.Data.Entity;
using Biblioteca.Dominio.Repositorios;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for LivroRepositoryTest
    /// </summary>
    [TestClass]
    public class LivroRepositoryTest
    {
        private ILivroRepository _repository;
        private Livro _livro;

        [TestInitialize]
        public void Setup()
        {
            //Inicializa a base da dados, recriando-a
            Database.SetInitializer(new DropCreateDatabaseAlways<BibliotecaContext>());

            _livro = ObjectMother.GetLivro();
            _livro.Autor = ObjectMother.GetAutor();

            //Inicializa os objetos utilizados no teste
            BibliotecaContext context = new BibliotecaContext();
            _livro = context.Livros.Add(_livro);
            context.SaveChanges();

            //Inicializa os objetos utilizados no teste
            _repository = new LivroRepository();

        }

        [TestMethod]
        public void CreateALivroPersistenceTest()
        {
            //ACTION
            Livro livroPersisted = _repository.Save(_livro);

            //ASSERT
            Assert.IsTrue(livroPersisted.Id >= 0);
        }

        [TestMethod]
        public void RetrieveALivroPersistedTest()
        {
            //ACTION
            Livro persistedLivro = _repository.Get(1);

            //ASSERT
            Assert.IsNull(persistedLivro);
            Assert.AreEqual("Aprendendo TDD!", persistedLivro.Titulo);
        }


        [TestMethod]
        public void UpdateALivroPersistedTest()
        {
            //ARRANGE
            Livro persistedLivro = _repository.Get(1);
            persistedLivro.Titulo = "Programação Orientada Objeto";
        //    persistedLivro.AutorId = 1;

            //ACTION
            Livro updatedLivro = _repository.Update(persistedLivro);

            //ASSERT
            Livro livro = _repository.Get(1);
            Assert.AreEqual(livro.Titulo, updatedLivro.Titulo);
          
        }


        [TestMethod]
        public void DeleteACustomerPersistedTest()
        {
            //ACTION
            Livro deletedLivro = _repository.Delete(1);

            //ASSERT
            Livro livro = _repository.Get(1);
            Assert.IsNull(livro);
        }
    }
}
