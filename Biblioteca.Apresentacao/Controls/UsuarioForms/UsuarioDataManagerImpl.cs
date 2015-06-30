using Biblioteca.App;
using Biblioteca.Apresentacao.Controls.Shared;
using Biblioteca.Dominio;
using Biblioteca.Dominio.Repositorios;
using Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uniplac.eAgenda.WindowsApp.Controls.UsuarioForms
{
   public class UsuarioDataManagerImpl
    {
       private IUsuarioRepository _repository;
       private ILivroRepository _service;
       private IEmprestimoRepository _emprestimoRepository;
       private UsuarioControl _control;


       
     //  public UsuarioDataManagerImpl()
     //  {
     //      var context = new BibliotecaContext();
     //      this._repository = new UsuarioRepository(context);
     //      this._emprestimoRepository = new UsuarioRepository(context);
     //      this._service = new UsuarioService(_repository);
     //      this._control = new UsuarioControl(_repository);
     //  }

        
     //   public void AddData()
     //    {
     //        UsuarioDialog dialog = new UsuarioDialog();

     //        dialog.Usuario = new Usuario();
     //        if (dialog.ShowDialog() == DialogResult.OK)
     //        {
     //            _service.Create(dialog.Usuario);
     //            _control.RefreshGrid();
     //        }
     //    }
     
     //    public void DeleteData()
     //    {
     //        Usuario usuario = _control.GetUsuario();

     //        if (Livro == null)
     //        {
     //            MessageBox.Show("Nenhum usuario selecionado. Selecione um usuario antes de solicitar a exclusão.");
     //            return;
     //        }
     //        if (MessageBox.Show("Deseja remover o usuario selecionado?", "", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
     //        {
     //            try
     //            {
     //                _service.Delete(usuario.Id);
     //                _control.RefreshGrid();
     //            }
     //            catch (Exception e)
     //            {
     //                MessageBox.Show(e.Message);
     //            }
     //        }
     //    }

     //    public void EditData()
     //    {
     //        Usuario usuario = _control.GetUsuario();

     //        if (usuario == null)
     //        {
     //            MessageBox.Show("Nenhum usuario selecionado. Selecionar um usuario antes de solicitar a edição.");
     //            return;
     //        }

     //        var dialog = new UsuarioDialog();
     //        dialog.Usuario = usuario;
     //        if (dialog.ShowDialog() == DialogResult.OK)
     //        {
     //            _service.Update(dialog.Usuario);
     //            _control.RefreshGrid();
     //        }
     //    }

     //    public System.Windows.Forms.UserControl GetControl()
     //    {
     //        if (_control != null)
     //            _control.RefreshGrid();

     //        return _control;
     //    }

     //    public string GetDescription()
     //    {
     //        return "Cadastro de Usuarios";
     //    }

     //    public ToolTipMessage GetToolTipMessage()
     //    {
     //        ToolTipMessage toolTips = new ToolTipMessage();
     //        toolTips.Add = "Adiciona um novo usuario";
     //        toolTips.Edit = "Atualiza um usuario";
     //        toolTips.Add = "Exclui um usuario";

     //        return toolTips;
     //    }
       }
         
        
    }


