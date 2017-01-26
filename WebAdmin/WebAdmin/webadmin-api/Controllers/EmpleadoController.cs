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
    public class EmpleadoController : ApiController
    {
        DB_A0BB07_babersoftdbEntities DB_EntityModel = new DB_A0BB07_babersoftdbEntities();
        Bugs B_Results = new Bugs();

        /// <summary>
        /// Description: Metodo para seleccionar todos los Empleados
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>       
        /// <returns></returns>
        [HttpGet]
        [Route("SelectEmpleado")]
        public List<usp_EmpleadoSeleccionarTodos_Result> SelectEmpleado()
        {
            List<usp_EmpleadoSeleccionarTodos_Result> result = new List<usp_EmpleadoSeleccionarTodos_Result>();
            using (DB_EntityModel)
            {
                result = DB_EntityModel.usp_EmpleadoSeleccionarTodos().ToList();
            }
            return result;
        }


        /// <summary>
        /// Description: Metodo para insertar los Empleados
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Empleado"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertEmpleado")]
        public Bugs InsertEmpleado(Empleado TP_Empleado)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_EmpleadoInsertar(TP_Empleado.Nombre, TP_Empleado.Apellidos, TP_Empleado.Identificacion, TP_Empleado.Correo, TP_Empleado.Direccion, TP_Empleado.Telefono, TP_Empleado.Estado, null, null, TP_Empleado.UsuarioCreacion, TP_Empleado.UsuarioModificacion, TP_Empleado.Cargo);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se ingreso el Empleado satisfactoriamente";
                    B_Results.Resultado = SelectEmpleado();
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
        /// Description: Metodo para actualizar los datos de un Empleados
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Empleado"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateEmpleado")]
        public Bugs UpdateEmpleado(Empleado TP_Empleado)
        {
            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_EmpleadoActualizar(TP_Empleado.IdEmpleado, TP_Empleado.Nombre, TP_Empleado.Apellidos, TP_Empleado.Identificacion, TP_Empleado.Correo, TP_Empleado.Direccion, TP_Empleado.Telefono, TP_Empleado.Estado, TP_Empleado.FechaCreacion, TP_Empleado.FechaModificacion, TP_Empleado.UsuarioCreacion, TP_Empleado.UsuarioModificacion, TP_Empleado.Cargo);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se actualizo el Empleado satisfactoriamente";
                    B_Results.Resultado = SelectEmpleado();
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
        /// Description: Metodo para eliminar un Empleados
        /// Developer: Tec. Juan Canencia
        /// Date: 10/09/2016
        /// </summary>
        /// <param name="TP_Empleado"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteEmpleado")]
        public Bugs DeleteEmpleado(Empleado TP_Empleado)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_EmpleadoEliminar(TP_Empleado.IdEmpleado);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se elimino el Empleado satisfactoriamente";
                    B_Results.Resultado = SelectEmpleado();
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
