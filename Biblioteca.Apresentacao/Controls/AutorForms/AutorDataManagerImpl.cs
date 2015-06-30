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

namespace Biblioteca.Apresentacao.Controls.AutorForms
{
    public class AutorDataManagerImpl : IDataManager
    {
        private IAutorRepository _repository;
        private IAutorService _service;
        private AutorControl _control;

        public AutorDataManagerImpl()
        {
            this._repository = new AutorRepository();
            this._service = new AutorService(_repository);
            this._control = new AutorControl(_repository);
        }

        public void AddData()
        {
            AutorDialog dialog = new AutorDialog();

            dialog.Autor = new Autor();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.CreateAutor(dialog.Autor);
                _control.RefreshGrid();
            }
        }

        public void DeleteData()
        {
            Autor autor = _control.GetAutor();

            if (autor == null)
            {
                MessageBox.Show("Nenhum autor selecionado. Selecione um autor antes de solicitar a exclusão.");
                return;
            }
            if (MessageBox.Show("Deseja remover o autor selecionado?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                try
                {
                    _service.DeleteAutor(autor.Id);
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
            Autor autor = _control.GetAutor();

            if (autor == null)
            {
                MessageBox.Show("Nenhum autor selecionado. Selecionar um autor antes de solicitar a edição.");
                return;
            }

            var dialog = new AutorDialog();
            dialog.Autor = autor;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _service.EditAutor(dialog.Autor);
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
            return "Cadastro de Autores";
        }

        public ToolTipMessage GetToolTipMessage()
        {
            ToolTipMessage toolTips = new ToolTipMessage();
            toolTips.Add = "Adiciona um novo autor";
            toolTips.Edit = "Atualiza um autor";
            toolTips.Add = "Exclui um autor";

            return toolTips;
        }
    }
}
