/// <reference path="tipoServicio.js" />
//***********************************************************
// Author           : Ing. Alex Aicardi
// Created          : 21/08/2016
// Description      : CRUD Tipo servicio
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************

$(document).ready(function () {
    try {   
        objTipoServicio.consultarTipoServicio();
    } catch (ex) {
        alert(ex.message);
    }
});

function TipoServicio() {
    //Variables globales

    var iId;
    var sNombre = "";
    var iPrecio;
    var sDescripcion = "";

    var jsonTipoServicio = {
        IdTipoServicio: 0,
        Nombre: "",
        Precio: null,
        Descripcion: ""
    }
    var oServicesApiRest = {
        sSolicitudRest: "",
        sMetodoApi:""
    }

    //Crear grila
    this.crearGrilla = function (jsonDatos) {

        try {

            $("#Grid_TipoServicio").empty();
            $("#Grid_TipoServicio").kendoGrid({

                dataSource: {

                    data: jsonDatos,
                    pageSize: 6
                },
                schema: {

                    model: {

                        fields: {
                            IdTipoServicio: { type: "int" },
                            Nombre: { type: "string" },
                            Precio: { type: "int" },                            
                            Descripcion: { type: "string" }
                        }
                    },
                    serverPaging: false,
                    serverFiltering: false
                },
                height: 400,
                filterable: {

                    mode: "row"
                },
                pageable: true,     
                columns: [
                            { title: " ", width: "5%", template: "<div title=\"Editar\" style=\"text-align:center;cursor:pointer;\" onclick='objTipoServicio.editarTipoServicio(\"#=IdTipoServicio#\", \"#=Nombre#\", \"#=Precio#\",\"#=Descripcion#\");'> <i class=\"fa fa-pencil fa-2x\"></i></div>" },
                            { field: "Nombre", title: "Nombre", width: "30%",  filterable: { cell: { operator: "contains" } } },
                            { field: "Precio", title: "Precio", width: "30%", filterable: { cell: { operator: "contains" } } },
                            { field: "Descripcion", title: "Descripción", width: "30%", filterable: { cell: { operator: "contains" } } },
                            { title: " ", width: "5%", template: "<div title=\"Eliminar\" style=\"text-align:center;cursor:pointer;\" onclick='objTipoServicio.eliminarTipoServicio(\"#=IdTipoServicio#\");'> <i class=\"fa fa-trash-o fa-2x\"></i></div>" }
    
            ]
            });

        } catch (ex) {
            alert(ex.message);
        }
    }

    //Consultar tipo de servicio
    this.consultarTipoServicio = function () {
        var jsonResponse;
        try {
            $.ajax({
                type: "GET",
                url: "/SelectTipoServicio",
                dataType: "json",
                success: function (data) {
                    jsonResponse = data;
                    objTipoServicio.crearGrilla(jsonResponse);
                },
                error: function (data) {
                    //Notificar mensaje de error 
                    notif({
                        msg: "<b>¡Error! </b>" + data.statusText,
                        type: "error",
                        position: "right"
                    });
                }
            });
        } catch (e) {
            notif({
                msg: "<b>¡Error! </b>" + e.message,
                type: "error",
                position: "right"
            });
        }


    }

    //Eliminar
    this.eliminarTipoServicio = function (iIdTipoServicio) {
        jsonTipoServicio.IdTipoServicio = iIdTipoServicio;
        oServicesApiRest.sMetodoApi = "DeleteTipoServicio";
        oServicesApiRest.sSolicitudRest = "DELETE";
        objTipoServicio.crudTipoServicio("DELETE");
    }

    //Editar
    this.editarTipoServicio = function (iIdTipoServicio, sNombre, Precio, sDescripcion) {

        jsonTipoServicio.IdTipoServicio = iIdTipoServicio;
        jsonTipoServicio.Nombre = sNombre;
        jsonTipoServicio.Precio = Precio;
        jsonTipoServicio.Descripcion = sDescripcion;

        objTipoServicio.mostrarPopup("PUT");
    }

    //Abrir ventana
    this.abrirVentana = function (sNombreVentana) {
        try {
            $('#popup_tiposervicio').modal({
                backdrop: "static",
                keyboard: false,
                width: "100%"
            });

            $(".modal-title").text(sNombreVentana);
        } catch (e) {
            notif({
                msg: "<b>¡Error! </b>" + e.message,
                type: "error",
                position: "right"
            });
        }
     
    }

    //Cerrar Ventana
    this.cerrarVentana = function () {
        try {
            $("#popup_tiposervicio").modal("hide");
        } catch (e) {
            notif({
                msg: "<b>¡Error! </b>" + e.message,
                type: "error",
                position: "right"
            });
        }
         
    }

    //Mostrar ventana
    this.mostrarPopup = function (sOperacion) {
        //Variables
        var sTituloVentana;   
        var ObjBoton;
        var ObjTextBoton;
        try {
            //Limpiar formulario
            objTipoServicio.limpiarComponentes();
            ObjBoton = $("#Button_GuardarUsuario");
            ObjTextBoton = $("#Button_GuardarUsuario").find("span");
            //Validar si es nuevo registro.
            if (sOperacion == "POST") {
                sTituloVentana = "Nuevo tipo de servicio";
                $(ObjTextBoton).text("Guardar");
                oServicesApiRest.sSolicitudRest = sOperacion;
                oServicesApiRest.sMetodoApi = "InsertTipoServicio";
                ObjBoton.attr("onclick", "javascript:objTipoServicio.validarCampo('POST');");

            }
            //Validar si es actualizar
            if (sOperacion == "PUT") {
                sTituloVentana = "Editar tipo de servicio";
                $(ObjTextBoton).text("Editar");
                oServicesApiRest.sSolicitudRest = sOperacion;
                oServicesApiRest.sMetodoApi = "UpdateTipoServicio";
                ObjBoton.attr("onclick", "javascript:objTipoServicio.validarCampo('PUT');");
                $("#input_Nombre").val(jsonTipoServicio.Nombre);
                $("#input_Precio").val(jsonTipoServicio.Precio);
                $("#Textarea_Mision").val(jsonTipoServicio.Descripcion);
            }

            var ObjTd = ObjBoton.parent();
            var sHtmlTd = ObjTd.html();
            ObjTd.html(sHtmlTd);
            //Abrir ventana emergente
            objTipoServicio.abrirVentana(sTituloVentana);

        } catch (ex) {
            alert(ex.message);
        }

    }
    
    //Método para validar campos del formulario
    this.validarCampo = function (sOperacion) {
       //Validar
        sNombre = $("#input_Nombre").val();
        iPrecio = $("#input_Precio").val();
        sDescripcion = $("#Textarea_Mision").val();
        if (sNombre == "") {
            notif({
                msg: "<b>¡Atento!</b> Por favor ingrese nombre del tipo de servicio",
                type: "info",
                position: "right"
            });
            $("#input_Nombre").focus();
            $("#input_Nombre").css("background-color", "#FBE5E0");
        } else if (iPrecio == "") {
            notif({
                msg: "<b>¡Atento!</b> Por favor ingrese el precio del tipo de servicio",
                type: "info",
                position: "right"
            });
            $("#input_Nombre").focus();
            $("#input_Nombre").css("background-color", "#FBE5E0");
        }

        else {
            jsonTipoServicio.Nombre = sNombre;
            jsonTipoServicio.Descripcion = sDescripcion;
            jsonTipoServicio.Precio = iPrecio;
            objTipoServicio.crudTipoServicio(sOperacion);
        }
        
    }   

    //Método para realizar el CRUD de tipo de servicio
    this.crudTipoServicio = function (sOperacion) {
        //Petición ajax al ControllerLogin
        var jsonResponse
        $.ajax({
            type: oServicesApiRest.sSolicitudRest,
            url: "/" + oServicesApiRest.sMetodoApi,
            dataType: "json",
            data: jsonTipoServicio,          
            success: function (data) {
                jsonResponse = data;
                //Validar si no hay error
                if (!jsonResponse.Error) {               
                      //Mensaje de satisfactorio
                      notif({
                          msg: "<b>¡Bien hecho! </b>" + jsonResponse.Mensaje,
                          type: "success",
                          position: "right"
                      });
                      if (sOperacion != "DELETE")
                          objTipoServicio.cerrarVentana();
                     //Limpiar componentes
                      objTipoServicio.limpiarComponentes();
                    //Actualizar grilla
                      objTipoServicio.crearGrilla(jsonResponse.Resultado);
                 }
                else {    
           
                    notif({
                        msg: "<b>¡Oh! </b>" + jsonResponse.Mensaje,
                        type: "error",
                        position: "right"
                    });
                }
            },
            error: function (data) {           
                notif({
                    msg: "<b>¡Error! </b>" + data.statusText,
                    type: "error",
                    position: "right"
                });
            }
        });
        

    }

    //Limpiar componentes
    this.limpiarComponentes = function () {
        $("#input_Nombre,#input_Precio, #Textarea_Mision").val("");
        $("#input_Nombre, #input_Precio, #Textarea_Mision").css("background-color", "");
    }
}

objTipoServicio = new TipoServicio();