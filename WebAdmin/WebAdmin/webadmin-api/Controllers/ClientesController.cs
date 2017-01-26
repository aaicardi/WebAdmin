using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAdmin.webadmin_model.Entity;
using WebAdmin.webadmin_model.Model;


namespace WebAdmin.webadmin_api.Controllers
{
    public class ClientesController : ApiController
    {
        DB_A0BB07_babersoftdbEntities DB_EntityModel = new DB_A0BB07_babersoftdbEntities();
        Bugs B_Results = new Bugs();

        /// <summary>
        /// Description: Metodo para seleccionar todos los clientes
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>       
        /// <returns></returns>
        [HttpGet]
        [Route("SelectCliente")]
        public List<usp_ClienteSeleccionarTodos_Result> SelectCliente()
        {
            List<usp_ClienteSeleccionarTodos_Result> result = new List<usp_ClienteSeleccionarTodos_Result>();
            using (DB_EntityModel)
            {
                result = DB_EntityModel.usp_ClienteSeleccionarTodos().ToList();
            }
            return result;
        }


        /// <summary>
        /// Description: Metodo para insertar los clientes
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Cliente"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertCliente")]
        public Bugs InsertCliente(Cliente TP_Cliente)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_ClienteInsertar(TP_Cliente.Nombre, TP_Cliente.Apellidos, TP_Cliente.Identificacion, TP_Cliente.Correo, TP_Cliente.Direccion, TP_Cliente.Telefono, TP_Cliente.Estado,TP_Cliente.UsuarioCreacion);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se ingreso el cliente satisfactoriamente";
                    B_Results.Resultado = SelectCliente();
                }

            }
            catch (Exception ex)
            {
                B_Results.Error = true;
                B_Results.Mensaje = "Error: " + ex.Message;
                B_Results.Resultado = null;

            }
            return B_Results;


        }


        /// <summary>
        /// Description: Metodo para actualizar los datos de un clientes
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Cliente"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateCliente")]
        public Bugs UpdateCliente(Cliente TP_Cliente)
        {
            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_ClienteActualizar(TP_Cliente.IdCliente, TP_Cliente.Nombre, TP_Cliente.Apellidos, TP_Cliente.Identificacion, TP_Cliente.Correo, TP_Cliente.Direccion, TP_Cliente.Telefono, TP_Cliente.Estado, TP_Cliente.FechaCreacion, TP_Cliente.FechaModificacion, TP_Cliente.UsuarioCreacion, TP_Cliente.UsuarioModificacion);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se actualizo el cliente satisfactoriamente";
                    B_Results.Resultado = SelectCliente();
                }

            }
            catch (Exception ex)
            {
                B_Results.Error = true;
                B_Results.Mensaje = "Error: " + ex.Message;
                B_Results.Resultado = null;

            }
            return B_Results;


        }

        /// <summary>
        /// Description: Metodo para eliminar un clientes
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Cliente"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteCliente")]
        public Bugs DeleteCliente(Cliente TP_Cliente)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_ClienteEliminar(TP_Cliente.IdCliente);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se elimino el cliente satisfactoriamente";
                    B_Results.Resultado = SelectCliente();
                }

            }
            catch (Exception ex)
            {
                B_Results.Error = true;
                B_Results.Mensaje = "Error: " + ex.Message;
                B_Results.Resultado = null;

            }
            return B_Results;


        }

    }
}
