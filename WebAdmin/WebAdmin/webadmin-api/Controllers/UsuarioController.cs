using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAdmin.webadmin_model.Entity;
using WebAdmin.webadmin_model.Model;

namespace WebAdmin.webadmin_api.Controllers
{
    public class UsuarioController : ApiController
    {
        DB_A0BB07_babersoftdbEntities DB_EntityModel = new DB_A0BB07_babersoftdbEntities();
        Bugs B_Results = new Bugs();

        /// <summary>
        /// Description: Metodo para validar inicio de sesion
        /// Developer: Ing. Alex Aicardi
        /// Date: 13/08/2016
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("Login")]
        public Bugs LoginUser(Usuario usuario)
        {
            List<usp_ValidarIngresoUsuario_Result1> User = new List<usp_ValidarIngresoUsuario_Result1>();
            object parameter = new object();
            try
            {
                using (DB_EntityModel)
                {
                    User = DB_EntityModel.usp_ValidarIngresoUsuario(usuario.Nombre, usuario.Clave).ToList();
                }


                if ((User.Count > 0))
                {

                    B_Results.Error = false;
                    B_Results.Mensaje = "¡Bienvenido!";
                    B_Results.Resultado = User;
                }
                else
                {
                    B_Results.Error = true;
                    B_Results.Mensaje = "El usuario o contraseña no es correcto.";
                    B_Results.Resultado = User;
                }


            }
            catch (Exception ex)
            {
                B_Results.Error = true;
                B_Results.Mensaje = ex.Message;

            }
            return B_Results;
        }
    }
}
