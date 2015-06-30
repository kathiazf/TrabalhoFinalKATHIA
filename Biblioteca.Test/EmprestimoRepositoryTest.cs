using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using Infra.Data;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;

namespace Biblioteca.Test
{
    /// <summary>
    /// Summary description for EmprestimoRepository
    /// </summary>
    [TestClass]
    public class EmprestimoRepositoryTest
    {
        private IEmprestimoRepository _repository;
        private Emprestimo _emprestimo;


        [TestInitialize]
        public void Setup()
        {
            //Inicializa a base da dados, recriando-a
            Database.SetInitializer(new DropCreateDatabaseAlways<BibliotecaContext>());

            //Inicializa os objetos utilizados no teste
            //_repository = new EmprestimoRepository();
            //_emprestimo = ObjectMother.GetEmprestimo();

            //Criar registro inicial na base da dados
            BibliotecaContext context = new BibliotecaContext();
            _emprestimo = context.Emprestimos.Add(_emprestimo);
            context.SaveChanges();

        }

    }
}
