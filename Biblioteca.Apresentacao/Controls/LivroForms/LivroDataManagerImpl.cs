using Biblioteca.Apresentacao.Controls.Shared;
using Biblioteca.Dominio.Repositorios;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Apresentacao.Controls.Shared;
using Biblioteca.Dominio;
using Biblioteca.App;

namespace Biblioteca.Apresentacao.Controls.LivroForms
{
    public class LivroDataManagerImpl : IDataManager
    {
        private ILivroRepository _repository;
        private ILivroService _service;
        private IAutorRepository _autorRepository;
        private LivroControl _control;

        public LivroDataManagerImpl()
        {
            var context = new BibliotecaContext();
            this._repository = new LivroRepository(context);
            this._autorRepository = new AutorRepository();
            this._service = new LivroService(_repository);
            this._control = new LivroControl(_repository);
        }

        public void AddData()
        {
            LivroDialog dialog = new LivroDialog();

            dialog.Livro = new Livro();
            dialog.Autores = _autorRepository.Getall();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.CreateLivro(dialog.Livro);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Livro livro = _control.GetLivro();

            if (livro == null)
            {
                MessageBox.Show("Nenhum livro selecionado. Selecione um livro antes de solicitar a exclusão.");
                return;
            }
            if (MessageBox.Show("Deseja remover o livro selecionado?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    _service.DeleteLivro(livro.Id);
                    _control.RefreshGrid();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        public void EditData()
        {
            Livro livro = _control.GetLivro();

            if (livro == null)
            {
                MessageBox.Show("Nenhum livro selecionado. Selecionar um livro antes de solicitar a edição.");
                return;
            }

            var dialog = new LivroDialog();
            dialog.Livro = livro;
            dialog.Autores = _autorRepository.Getall();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.EditLivro(dialog.Livro);
                _control.RefreshGrid();
            }
        }

        public System.Windows.Forms.UserControl GetControl()
        {
            if (_control != null)
                _control.RefreshGrid();

            return _control;
        }

        public string GetDescription()
        {
            return "Cadastro de Livros";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            ToolTipMessage toolTips = new ToolTipMessage();
            toolTips.Add = "Adiciona um novo livro";
            toolTips.Edit = "Atualiza um livro";
            toolTips.Add = "Exclui um livro";

            return toolTips;
        }
    }
}
