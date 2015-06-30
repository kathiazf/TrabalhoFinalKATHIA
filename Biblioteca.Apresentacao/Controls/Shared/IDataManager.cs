using System.Windows.Forms;

namespace Biblioteca.Apresentacao.Controls.Shared
{
    public interface IDataManager
    {
        /// <summary>
        /// É responsável por chamar o diálogo de inserção, caso o usuário confirme o cadastro clicando em ok,
        /// esta função chama o método na camada de serviço responsável pela inserção de um novo registro.
        /// Este método é chamado no formulário Principal, dentro do evento btnAdd_click
        /// </summary>
        void AddData();

        /// <summary>
        /// É responsável por chamar o diálogo de exclusão, caso o usuário confirme clicando em ok,
        /// esta função chama o método na camada de serviço responsável pela exclusão de um registro existente na base de dados.
        /// Este método é chamado no formulário Principal, dentro do evento btnDelete_Click
        /// </summary>
        void DeleteData();

        /// <summary>
        /// É responsável por chamar o diálogo de atualização, caso o usuário confirme clicando em ok,
        /// esta função chama o método na camada de serviço responsável pela alteração das informações de um registro 
        /// existente na base de dados.
        /// Este método é chamado no formulário Principal, dentro do evento btnEdit_Click
        /// </summary>
        void EditData();

        /// <summary>
        /// É responsável por chamar o diálogo de exclusão, caso o usuário confirme clicando em ok,
        /// esta função chama o método na camada de serviço responsável pela exclusão de um registro existente na base de dados.
        /// Este método é chamado no formulário Principal, dentro do evento btnDelete_Click
        /// </summary>
        UserControl GetControl();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetDescription();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ToolTipMessage GetToolTipMessage();

    }
}