//***********************************************************
// Author           : Alex Aicardi
// Created          : 19/08/2016
// Description      : Funciones globales
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//**********************************************************


/// <summary>
/// Funciones globales
/// </summary>
function FuncionesGlobales() {

    this.Demo = function () {
        alert("Hola mundo!");
    }

    /// <summary>
    /// Description: Metodo para limpiar componentes
    /// Developer: Ing. Alex Aicardi
    /// Date: 21/08/2016
    /// </summary>
    /// <param name="lstComponents">Listado de componentes a limpiar</param>
    /// <param name="numeroComponents">Numero de componentes</param>
    this.cleanComponents = function (lstComponents, numeroComponents) {
        try {
            for (var i = 0; i < numeroComponentes; i++) {
                $("#" + lstComponentes[i].Nombre + "").val("");
                $("#" + lstComponentes[i].Nombre + "").css("background-color", "");
            }
        } catch (ex) {
            notif({
                msg: "<b>Error:</b>" + ex.message,
                type: "error",
                position: "right"
            });
        }
    }


    /// <summary>
    /// Description: AJAX para las solicitudes REST API
    /// Developer: Ing. Alex Aicardi
    /// Date: 21/08/2016
    /// </summary>
    /// <param name="sType">Tipo solicitud rest: POST, GET, DELETE, PUT</param>
    /// <param name="sNameController">Nombre del controlador rest</param>
    /// <param name="jsonData">Datos</param>
    /// <param name="sDataType">Tipo de dato: json, xml, ect.</param>
    this.ajax = function (sType, sNameController, jsonData, sDataType) {
        var jsonResponse;
        try {
            $.ajax({
                type: sType,
                url: "/" + sNameController,
                dataType: sDataType != undefined && sDataType != "" && sDataType != null ? sDataType : "json",
                data: jsonData,                
                success: function (data) {
                    jsonResponse = data;
                    if (!jsonResponse.Error) {
                        notif({
                            msg: "<b>Success: </b>" + jsonResponse.Mensaje,
                            type: "success",
                            position: "right"
                        });
                    } else {
                        notif({
                            msg: "<b>Error: </b>" + jsonResponse.Mensaje,
                            type: "error",
                            position: "right"
                        });
                    }               
              
                },
                error: function (data) {
                   notif({
                        msg: "<b>Error: </b>" + data,
                        type: "error",
                        position: "right"
                    });
                }
            });
        } catch (ex) {
            notif({
                msg: "<b>Error: </b>" + ex.message,
                type: "error",
                position: "right"
            });
        }
    }

    /// <summary>
    /// Description: Redireccionar
    /// Developer: Ing. Alex Aicardi
    /// Date: 02/09/2016
    /// </summary>
    /// <param name="sPagina">Página la cual se desea redireccionar</param>
    this.redireccionar = function (sPagina) {
        window.location.href = sPagina;
    }

    /// <summary>
    /// Description: ValidarSesion
    /// Developer: Ing. Alex Aicardi
    /// Date: 02/09/2016
    /// </summary>
    this.validarSesion = function () {
        var session = null;
        var sNombreUsuario = "";
        try {
            //Obtener sesión
            session = objSession.consultarSession();
            //Validar si existe información de sesión
            if (session != null) {             
                //Convertir de json a Obj
                sNombreUsuario = jQuery.parseJSON(session);
                //Establecer nombre de usuario al span del index
                $("#span_NombreUsuario").text(" " + sNombreUsuario.Username);
            } else {
                //redireccionar página login si no existe sesión de usuario
                objFuncionesGlobales.redireccionar("login.html");
            }
        } catch (e) {       
            notif({
                msg: "<b>¡Error!</b>" + e.message,
                type: "error",
                position: "right"
            });
        }
 
    }


}
objFuncionesGlobales = new FuncionesGlobales();