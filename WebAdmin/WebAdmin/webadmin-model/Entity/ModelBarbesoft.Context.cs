﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAdmin.webadmin_model.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DB_A0BB07_babersoftdbEntities : DbContext
    {
        public DB_A0BB07_babersoftdbEntities()
            : base("name=DB_A0BB07_babersoftdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Nullable<System.Guid>> usp_UsuarioValidar(string usuario, string clave, ObjectParameter respuestaSql)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var claveParameter = clave != null ?
                new ObjectParameter("Clave", clave) :
                new ObjectParameter("Clave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("usp_UsuarioValidar", usuarioParameter, claveParameter, respuestaSql);
        }
    
        public virtual ObjectResult<usp_ValidarIngresoUsuario_Result1> usp_ValidarIngresoUsuario(string sUsuario, string sClave)
        {
            var sUsuarioParameter = sUsuario != null ?
                new ObjectParameter("sUsuario", sUsuario) :
                new ObjectParameter("sUsuario", typeof(string));
    
            var sClaveParameter = sClave != null ?
                new ObjectParameter("sClave", sClave) :
                new ObjectParameter("sClave", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ValidarIngresoUsuario_Result1>("usp_ValidarIngresoUsuario", sUsuarioParameter, sClaveParameter);
        }
    
        public virtual ObjectResult<string> usp_ClienteActualizar(Nullable<int> idCliente, string nombre, string apellidos, string identificacion, string correo, string direccion, string telefono, Nullable<bool> estado, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaModificacion, string usuarioCreacion, string usuarioModificacion)
        {
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaModificacionParameter = fechaModificacion.HasValue ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(System.DateTime));
    
            var usuarioCreacionParameter = usuarioCreacion != null ?
                new ObjectParameter("UsuarioCreacion", usuarioCreacion) :
                new ObjectParameter("UsuarioCreacion", typeof(string));
    
            var usuarioModificacionParameter = usuarioModificacion != null ?
                new ObjectParameter("UsuarioModificacion", usuarioModificacion) :
                new ObjectParameter("UsuarioModificacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ClienteActualizar", idClienteParameter, nombreParameter, apellidosParameter, identificacionParameter, correoParameter, direccionParameter, telefonoParameter, estadoParameter, fechaCreacionParameter, fechaModificacionParameter, usuarioCreacionParameter, usuarioModificacionParameter);
        }
    
        public virtual ObjectResult<string> usp_ClienteEliminar(Nullable<int> sIdCliente)
        {
            var sIdClienteParameter = sIdCliente.HasValue ?
                new ObjectParameter("sIdCliente", sIdCliente) :
                new ObjectParameter("sIdCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ClienteEliminar", sIdClienteParameter);
        }
    
        public virtual ObjectResult<string> usp_ClienteInsertar(string nombre, string apellidos, string identificacion, string correo, string direccion, string telefono, Nullable<bool> estado, string usuarioCreacion)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var usuarioCreacionParameter = usuarioCreacion != null ?
                new ObjectParameter("UsuarioCreacion", usuarioCreacion) :
                new ObjectParameter("UsuarioCreacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_ClienteInsertar", nombreParameter, apellidosParameter, identificacionParameter, correoParameter, direccionParameter, telefonoParameter, estadoParameter, usuarioCreacionParameter);
        }
    
        public virtual ObjectResult<string> usp_TipoServicioActualizar(Nullable<int> iIdTipoServicio, string nombre, string descripcion, Nullable<int> precio)
        {
            var iIdTipoServicioParameter = iIdTipoServicio.HasValue ?
                new ObjectParameter("iIdTipoServicio", iIdTipoServicio) :
                new ObjectParameter("iIdTipoServicio", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_TipoServicioActualizar", iIdTipoServicioParameter, nombreParameter, descripcionParameter, precioParameter);
        }
    
        public virtual ObjectResult<string> usp_TipoServicioEliminar(Nullable<int> iIdTipoServicio)
        {
            var iIdTipoServicioParameter = iIdTipoServicio.HasValue ?
                new ObjectParameter("iIdTipoServicio", iIdTipoServicio) :
                new ObjectParameter("iIdTipoServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_TipoServicioEliminar", iIdTipoServicioParameter);
        }
    
        public virtual ObjectResult<string> usp_TipoServicioInsertar(string nombre, string descripcion, Nullable<int> precio)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_TipoServicioInsertar", nombreParameter, descripcionParameter, precioParameter);
        }
    
        public virtual ObjectResult<usp_TipoServicioSeleccionar_Result> usp_TipoServicioSeleccionar(Nullable<int> iIdTipoServicio)
        {
            var iIdTipoServicioParameter = iIdTipoServicio.HasValue ?
                new ObjectParameter("iIdTipoServicio", iIdTipoServicio) :
                new ObjectParameter("iIdTipoServicio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_TipoServicioSeleccionar_Result>("usp_TipoServicioSeleccionar", iIdTipoServicioParameter);
        }
    
        public virtual ObjectResult<string> usp_EmpleadoActualizar(Nullable<int> idEmpleado, string nombre, string apellidos, string identificacion, string correo, string direccion, string telefono, Nullable<bool> estado, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaModificacion, string usuarioCreacion, string usuarioModificacion, string cargo)
        {
            var idEmpleadoParameter = idEmpleado.HasValue ?
                new ObjectParameter("IdEmpleado", idEmpleado) :
                new ObjectParameter("IdEmpleado", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaModificacionParameter = fechaModificacion.HasValue ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(System.DateTime));
    
            var usuarioCreacionParameter = usuarioCreacion != null ?
                new ObjectParameter("UsuarioCreacion", usuarioCreacion) :
                new ObjectParameter("UsuarioCreacion", typeof(string));
    
            var usuarioModificacionParameter = usuarioModificacion != null ?
                new ObjectParameter("UsuarioModificacion", usuarioModificacion) :
                new ObjectParameter("UsuarioModificacion", typeof(string));
    
            var cargoParameter = cargo != null ?
                new ObjectParameter("Cargo", cargo) :
                new ObjectParameter("Cargo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_EmpleadoActualizar", idEmpleadoParameter, nombreParameter, apellidosParameter, identificacionParameter, correoParameter, direccionParameter, telefonoParameter, estadoParameter, fechaCreacionParameter, fechaModificacionParameter, usuarioCreacionParameter, usuarioModificacionParameter, cargoParameter);
        }
    
        public virtual ObjectResult<string> usp_EmpleadoEliminar(Nullable<int> sIdEmpleado)
        {
            var sIdEmpleadoParameter = sIdEmpleado.HasValue ?
                new ObjectParameter("sIdEmpleado", sIdEmpleado) :
                new ObjectParameter("sIdEmpleado", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_EmpleadoEliminar", sIdEmpleadoParameter);
        }
    
        public virtual ObjectResult<usp_EmpleadoSeleccionarTodos_Result> usp_EmpleadoSeleccionarTodos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_EmpleadoSeleccionarTodos_Result>("usp_EmpleadoSeleccionarTodos");
        }
    
        public virtual ObjectResult<string> usp_EmpleadoInsertar(string nombre, string apellidos, string identificacion, string correo, string direccion, string telefono, Nullable<bool> estado, Nullable<System.DateTime> fechaCreacion, Nullable<System.DateTime> fechaModificacion, string usuarioCreacion, string usuarioModificacion, string cargo)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            var estadoParameter = estado.HasValue ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(bool));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("FechaCreacion", fechaCreacion) :
                new ObjectParameter("FechaCreacion", typeof(System.DateTime));
    
            var fechaModificacionParameter = fechaModificacion.HasValue ?
                new ObjectParameter("FechaModificacion", fechaModificacion) :
                new ObjectParameter("FechaModificacion", typeof(System.DateTime));
    
            var usuarioCreacionParameter = usuarioCreacion != null ?
                new ObjectParameter("UsuarioCreacion", usuarioCreacion) :
                new ObjectParameter("UsuarioCreacion", typeof(string));
    
            var usuarioModificacionParameter = usuarioModificacion != null ?
                new ObjectParameter("UsuarioModificacion", usuarioModificacion) :
                new ObjectParameter("UsuarioModificacion", typeof(string));
    
            var cargoParameter = cargo != null ?
                new ObjectParameter("Cargo", cargo) :
                new ObjectParameter("Cargo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("usp_EmpleadoInsertar", nombreParameter, apellidosParameter, identificacionParameter, correoParameter, direccionParameter, telefonoParameter, estadoParameter, fechaCreacionParameter, fechaModificacionParameter, usuarioCreacionParameter, usuarioModificacionParameter, cargoParameter);
        }
    
        public virtual ObjectResult<usp_ClienteSeleccionarTodos_Result> usp_ClienteSeleccionarTodos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_ClienteSeleccionarTodos_Result>("usp_ClienteSeleccionarTodos");
        }
    
        public virtual ObjectResult<usp_TipoServicioSeleccionarTodos_Result> usp_TipoServicioSeleccionarTodos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<usp_TipoServicioSeleccionarTodos_Result>("usp_TipoServicioSeleccionarTodos");
        }
    }
}
