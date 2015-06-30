using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Dominio.Repositorios;
using Biblioteca.Dominio;

namespace Biblioteca.Apresentacao.Controls.LivroForms
{
    public partial class LivroControl : UserControl
    {
        private readonly ILivroRepository _repository;

        public LivroControl()
        {
            InitializeComponent();
        }

        public LivroControl(ILivroRepository repository)
            : this()
        {
            _repository = repository;
        }

        public Livro GetLivro()
        {
            return listAutores.SelectedItem as Livro;
        }

        /// <summary>
        /// É responsável por atualizar as tarefas que estão sendo mostradas no ListBox
        /// Esta função é chamada nos métodos AddData, EditData, DeleteData e na primeira vez
        /// que passa pelo método GetControl da classe TarefaDataManager
        /// </summary>
        /// <returns></returns>
        public void RefreshGrid()
        {
            var livros = _repository.Getall();

            listAutores.Items.Clear();

            foreach (var livro in livros)
            {
                listAutores.Items.Add(livro);
            }
        }
    }
}
