using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.DAL;
using Loja.DTO;

namespace Loja.BLL
{
    public class UsuarioBLL
    {
        /*Método cargaUsuario, retorna uma lista de objetos usuario DTO
         * Composto por vários atributos , vai até o BD e busca todos os usuários
         * usamos o try e catch caso dê algum erro , retorna para camada view 
         * executar o método cargaUsuario (será criado na DAL)*/
         public IList<usuario_DTO> cargaUsuario()
        {
            try
            {
                return new UsuarioDAL().cargaUsuario();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int insereUsuario(usuario_DTO USU)
        {
            /*Insere usuario sera criado na DAL*/
            try
            {
                return new UsuarioDAL().insereUsuario(USU);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int editaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().editaUsuario(USU);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int deletaUsuario(usuario_DTO USU)
        {
            try
            {
                return new UsuarioDAL().deletaUsuario(USU);
            }

            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
