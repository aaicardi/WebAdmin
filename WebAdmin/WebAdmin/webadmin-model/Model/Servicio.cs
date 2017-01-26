using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    public class Servicio
    {
        private int idServicio;
        private int idTipoServicio;
        private double valor;
        private Boolean estado;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string usuarioCreacion;
        private string usuarioModificacion;
        private int idEmpleado;
        private DateTime fecha;

        public int IdServicio
        {
            get
            {
                return idServicio;
            }

            set
            {
                idServicio = value;
            }
        }

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

        public double Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }

        public Boolean Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public DateTime FechaCreacion
        {
            get
            {
                return fechaCreacion;
            }

            set
            {
                fechaCreacion = value;
            }
        }

        public DateTime FechaModificacion
        {
            get
            {
                return fechaModificacion;
            }

            set
            {
                fechaModificacion = value;
            }
        }

        public string UsuarioCreacion
        {
            get
            {
                return usuarioCreacion;
            }

            set
            {
                usuarioCreacion = value;
            }
        }

        public string UsuarioModificacion
        {
            get
            {
                return usuarioModificacion;
            }

            set
            {
                usuarioModificacion = value;
            }
        }

        public int IdEmpleado
        {
            get
            {
                return idEmpleado;
            }

            set
            {
                idEmpleado = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                fecha = value;
            }
        }

        public Servicio()
        {

        }
    }
}