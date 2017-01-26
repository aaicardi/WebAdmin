using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    public class Empresa
    {

        private int idEmpresa;
        private int idPais;
        private string nombre;
        private string descripcion;
        private string nit;
        private string direccion;
        private string telefono;
        private string mision;
        private string vision;
        private string objetivos;
        private string imageUrl;
        private int idDepartamento;
        private int idMunicipio;
        private string email;
        private string paginaWeb;
        private string telefonoCelular;

        public int IdEmpresa
        {
            get
            {
                return idEmpresa;
            }

            set
            {
                idEmpresa = value;
            }
        }

        public int IdPais
        {
            get
            {
                return idPais;
            }

            set
            {
                idPais = value;
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

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
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

        public string Mision
        {
            get
            {
                return mision;
            }

            set
            {
                mision = value;
            }
        }

        public string Vision
        {
            get
            {
                return vision;
            }

            set
            {
                vision = value;
            }
        }

        public string Objetivos
        {
            get
            {
                return objetivos;
            }

            set
            {
                objetivos = value;
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

        public int IdDepartamento
        {
            get
            {
                return idDepartamento;
            }

            set
            {
                idDepartamento = value;
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

        public string PaginaWeb
        {
            get
            {
                return paginaWeb;
            }

            set
            {
                paginaWeb = value;
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

        public Empresa()
        {

        }
    }
}