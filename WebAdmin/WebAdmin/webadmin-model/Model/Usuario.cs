//***********************************************************
// Author           : Alex Aicardi
// Created          : 21/08/2016
// Description      : Bugs
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    /// <summary>
    /// Description: Usuario Class
    /// Developer: Ing. Alex Aicardi 
    /// Date: 25/08/2016
    /// </summary>
    public class Usuario
    {
        private string idUsuario;
        private string nombre;
        private string clave;
        private string email;
        private string preguntaSeguridad;
        private string respuestaSeguridad;
        private Boolean aprobado;
        private Boolean bloqueado;
        private DateTime fechaCreacion;
        private DateTime ultimaIngreso;
        private string idToken;
        private int idUsuarioOperacion;
        private DateTime fechaOperacion;

        //Constructor
        public Usuario()
        {

        }

        #region Encapsulacion
        public string IdUsuario
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

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
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

        public string PreguntaSeguridad
        {
            get
            {
                return preguntaSeguridad;
            }

            set
            {
                preguntaSeguridad = value;
            }
        }

        public string RespuestaSeguridad
        {
            get
            {
                return respuestaSeguridad;
            }

            set
            {
                respuestaSeguridad = value;
            }
        }

        public bool Aprobado
        {
            get
            {
                return aprobado;
            }

            set
            {
                aprobado = value;
            }
        }

        public bool Bloqueado
        {
            get
            {
                return bloqueado;
            }

            set
            {
                bloqueado = value;
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

        public DateTime UltimaIngreso
        {
            get
            {
                return ultimaIngreso;
            }

            set
            {
                ultimaIngreso = value;
            }
        }

        public string IdToken
        {
            get
            {
                return idToken;
            }

            set
            {
                idToken = value;
            }
        }

        public int IdUsuarioOperacion
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
        #endregion
    }
}