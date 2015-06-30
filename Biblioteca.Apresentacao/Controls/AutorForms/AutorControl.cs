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

namespace Biblioteca.Apresentacao.Controls.AutorForms
{
    public partial class AutorControl : UserControl
    {
        private readonly IAutorRepository _repository;

        public AutorControl()
        {
            InitializeComponent();
        }

        public AutorControl(IAutorRepository repository)
            : this()
        {
            _repository = repository;
        }

        public Autor GetAutor()
        {
            return listAutores.SelectedItem as Autor;
        }

        /// <summary>
        /// É responsável por atualizar as tarefas que estão sendo mostradas no ListBox
        /// Esta função é chamada nos métodos AddData, EditData, DeleteData e na primeira vez
        /// que passa pelo método GetControl da classe TarefaDataManager
        /// </summary>
        /// <returns></returns>
        public void RefreshGrid()
        {
            var autores = _repository.Getall();

            listAutores.Items.Clear();

            foreach (var autor in autores)
            {
                listAutores.Items.Add(autor);
            }
        }
    }
}
