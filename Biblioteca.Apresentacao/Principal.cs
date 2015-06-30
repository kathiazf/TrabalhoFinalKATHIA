using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Biblioteca.Apresentacao.Controls.AutorForms;
using Biblioteca.Apresentacao.Controls.Shared;
using Biblioteca.Apresentacao.Controls.LivroForms;

namespace Biblioteca.Apresentacao
{
    public partial class Principal : Form
    {
        private static Principal _instance;
        private IDataManager _dataManager;
        private UserControl _control;

        public Principal()
        {
            InitializeComponent();
            _instance = this;
        }

        public static Principal Instance
        {
            get
            {
                return _instance;
            }
        }

        public void ShowMessageInFooter(string message)
        {
            lblStatus.Text = message;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.AddData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.DeleteData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                _dataManager.EditData();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// O Método LoadDataManager() é responsável por definir o contexto de cadastro da tela principal,
        /// ou seja, quando o usuário seleciona uma opção da barra de menu, esta operação carrega o UserControl
        /// correspondente, atualiza o título da janela e também os Tooltips dos botões.
        /// </summary>
        /// <param name="manager"></param>
        private void LoadDataManager(IDataManager manager)
        {
            try
            {
                if (_dataManager != null && _dataManager.GetType() == manager.GetType())
                    return;

                if (_control != null)
                {
                    panControl.Controls.Clear();
                }
                
                _dataManager = manager;

                _control = _dataManager.GetControl();
                
                _control.Dock = DockStyle.Fill;

                panControl.Controls.Add(_control);

                tituloLabel.Text = _dataManager.GetDescription();

                btnAdd.ToolTipText = _dataManager.GetToolTipMessage().Add;
                btnEdit.ToolTipText = _dataManager.GetToolTipMessage().Edit;
                btnDelete.ToolTipText = _dataManager.GetToolTipMessage().Delete;
                
                toolbar.Enabled = _dataManager != null;
            }
            catch (Exception be)
            {
                MessageBox.Show(be.Message);
            }
        }

        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new LivroDataManagerImpl());
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDataManager(new AutorDataManagerImpl());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuárioCtrlFToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
