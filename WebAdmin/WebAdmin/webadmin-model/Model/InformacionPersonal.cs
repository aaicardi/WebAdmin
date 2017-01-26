using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    public class InformacionPersonal
    {
        private int idUsuario;
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string nombre;
        private string codigoGenero;
        private string genero;
        private DateTime fechaNacimiento;
        private string idTipoDocumento;
        private string numeroDocumento;
        private string email;
        private string telefonoFijo;
        private string telefonoCelular;
        private string imageUrl;
        private int idMunicipio;
        private string direccion;
        private string idUsuarioOperacion;
        private DateTime fechaOperacion;

        public int IdUsuario
        {
            get
            {
                return idUsuario;
            }

            set
            {
                idUsuario = value;
            }
        }

        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }

            set
            {
                primerNombre = value;
            }
        }

        public string SegundoNombre
        {
            get
            {
                return segundoNombre;
            }

            set
            {
                segundoNombre = value;
            }
        }

        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }

            set
            {
                primerApellido = value;
            }
        }

        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }

            set
            {
                segundoApellido = value;
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

        public string CodigoGenero
        {
            get
            {
                return codigoGenero;
            }

            set
            {
                codigoGenero = value;
            }
        }

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

        public string IdTipoDocumento
        {
            get
            {
                return idTipoDocumento;
            }

            set
            {
                idTipoDocumento = value;
            }
        }

        public string NumeroDocumento
        {
            get
            {
                return numeroDocumento;
            }

            set
            {
                numeroDocumento = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string TelefonoFijo
        {
            get
            {
                return telefonoFijo;
            }

            set
            {
                telefonoFijo = value;
            }
        }

        public string TelefonoCelular
        {
            get
            {
                return telefonoCelular;
            }

            set
            {
                telefonoCelular = value;
            }
        }

        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }

            set
            {
                imageUrl = value;
            }
        }

        public int IdMunicipio
        {
            get
            {
                return idMunicipio;
            }

            set
            {
                idMunicipio = value;
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

        public string IdUsuarioOperacion
        {
            get
            {
                return idUsuarioOperacion;
            }

            set
            {
                idUsuarioOperacion = value;
            }
        }

        public DateTime FechaOperacion
        {
            get
            {
                return fechaOperacion;
            }

            set
            {
                fechaOperacion = value;
            }
        }

        public InformacionPersonal()
        {

        }
    }
}