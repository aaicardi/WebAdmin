using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    public class Cliente
    {
        private int idCliente;
        private string nombre;
        private string apellidos;
        private string identificacion;
        private string correo;
        private string direccion;
        private string telefono;
        private Boolean estado;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string usuarioCreacion;
        private string usuarioModificacion;

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
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

        public string Apellidos
        {
            get
            {
                return apellidos;
            }

            set
            {
                apellidos = value;
            }
        }

        public string Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
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

        public Cliente()
        {

        }
    }
}