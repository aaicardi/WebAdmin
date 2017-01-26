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

    public class TipoServicioController : ApiController
    {
        DB_A0BB07_babersoftdbEntities DB_EntityModel = new DB_A0BB07_babersoftdbEntities();
        Bugs B_Results = new Bugs();

        /// <summary>
        /// Description: Metodo para seleccionar todos los tipo de servicios
        /// Developer: Ing. Alex Aicardi
        /// Date: 07/09/2016
        /// </summary>       
        /// <returns></returns>
        [HttpGet]
        [Route("SelectTipoServicio")]
        public List<usp_TipoServicioSeleccionarTodos_Result> SelectTipoServicio()
        {
            List<usp_TipoServicioSeleccionarTodos_Result> result = new List<usp_TipoServicioSeleccionarTodos_Result>();
            using (DB_EntityModel)
            {
                result = DB_EntityModel.usp_TipoServicioSeleccionarTodos().ToList();
            }
            return result;
        }

        /// <summary>
        /// Description: Metodo para seleccionar tipo de servicio
        /// Developer: Ing. Alex Aicardi
        /// Date: 22/09/2016
        /// </summary>
        /// <param name="TP_TipoServicio"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("SelectIdTipoServicio")]
        public Bugs SelectIdTipoServicio(TipoServicio TP_TipoServicio)
        {

            try
            {
                using (DB_EntityModel)
                {
                    List<usp_TipoServicioSeleccionar_Result> result = new List<usp_TipoServicioSeleccionar_Result>();
                    result = DB_EntityModel.usp_TipoServicioSeleccionar(TP_TipoServicio.IdTipoServicio).ToList();
                    B_Results.Error = false;
                    B_Results.Resultado = result;
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
        /// Description: Metodo para insertar los tipo de servicios
        /// Developer: Ing. Alex Aicardi
        /// Date: 09/09/2016
        /// </summary>
        /// <param name="TP_TipoServicio"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("InsertTipoServicio")]
        public Bugs InsertTipoServicio(TipoServicio TP_TipoServicio)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_TipoServicioInsertar(TP_TipoServicio.Nombre, TP_TipoServicio.Descripcion, TP_TipoServicio.Precio);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se ingreso el tipo de servicio satisfactoriamente";
                    B_Results.Resultado = SelectTipoServicio();
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


        [HttpPut]
        [Route("UpdateTipoServicio")]
        public Bugs UpdateTipoServicio(TipoServicio TP_TipoServicio)
        {
            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_TipoServicioActualizar(TP_TipoServicio.IdTipoServicio, TP_TipoServicio.Nombre, TP_TipoServicio.Descripcion, TP_TipoServicio.Precio);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se actualizo el tipo de servicio satisfactoriamente";
                    B_Results.Resultado = SelectTipoServicio();
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


        [HttpDelete]
        [Route("DeleteTipoServicio")]
        public Bugs DeleteTipoServicio(TipoServicio TP_TipoServicio)
        {

            try
            {
                using (DB_EntityModel)
                {
                    DB_EntityModel.usp_TipoServicioEliminar(TP_TipoServicio.IdTipoServicio);
                    B_Results.Error = false;
                    B_Results.Mensaje = "Se elimino el tipo de servicio satisfactoriamente";
                    B_Results.Resultado = SelectTipoServicio();
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
