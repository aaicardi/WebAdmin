using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebAdmin.webadmin_model.Entity;

namespace WebAdmin.webadmin_model.Model
{
 
    /// <summary>
    /// Clase tipo servicio
    /// Ing. Alex Aicardi
    /// </summary>
    public class TipoServicio
    { 

        private int idTipoServicio;
        private string nombre;
        private string descripcion;
        private int precio;

        #region Encapsulación
        public int IdTipoServicio
        {
            get
            {
                return idTipoServicio;
            }

            set
            {
                idTipoServicio = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }
        #endregion

        //Constructor
        public TipoServicio()
        {

        }
    }
}