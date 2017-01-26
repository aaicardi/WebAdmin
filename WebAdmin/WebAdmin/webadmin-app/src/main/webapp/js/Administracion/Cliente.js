$(document).ready(function () {
    try {

        objCliente.consultarCliente();

    } catch (ex) {
        alert(ex.message);
    }
});


function Cliente() {
    //Variables globales

    var iIdCliente
   , sNombre = ""
   , sApellidos = ""
   , sIdentificacion = ""
   , sCorreo = ""
   , sDireccion = ""
   , sTelefono = ""
   , bEstado
   , dFechaCreacion = ""
   , dFechaModificacion = ""
   , sUsuarioCreacion = ""
   , sUsuarioModificacion = ""
    var jsonCliente = {
        IdCliente: 0
       , Nombre: ""
       , Apellidos: ""
       , Identificacion: ""
       , Correo: ""
       , Direccion: ""
       , Telefono: ""
       , Estado: 0
       , FechaCreacion: ""
       , FechaModificacion: ""
       , UsuarioCreacion: ""
       , UsuarioModificacion: ""
    }
    var oServicesApiRest = {
        sSolicitudRest: "",
        sMetodoApi: ""
    }


    this.crearGrilla = function (jsonDatos) {

        try {

            $("#Grid_Clientes").empty();
            $("#Grid_Clientes").kendoGrid({

                dataSource: {

                    data: jsonDatos,
                    pageSize: 6
                },
                schema: {

                    model: {

                        fields: {
                            Identificacion: { type: "string" },
                            Nombre: { type: "string" },
                            Correo: { type: "string" },
                            Direccion: { type: "string" },
                            Telefono: { type: "string" }
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

                            { width: "5%", title: " ", template: "<div title=\"Editar\"  style=\"text-align:center;cursor:pointer;\" ><i class=\"fa fa-pencil fa-2x\"></i></div>" },
                            { field: "Nombre", title: "Nombre", width: "20%", filterable: { cell: { operator: "contains" } } },
                            { field: "Identificacion", title: "Identificación", width: "18%", filterable: { cell: { operator: "contains" } } },
                            { field: "Correo", title: "Correo", width: "25%", filterable: { cell: { operator: "contains" } } },
                            { field: "Direccion", title: "Dirección", width: "20%", filterable: { cell: { operator: "contains" } } },
                            { field: "Telefono", title: "Teléfono", width: "8%", filterable: { cell: { operator: "contains" } } },
                            { title: " ", width: "5%", template: "<div title=\"Eliminar\" style=\"text-align:center;cursor:pointer;\" onclick='objCliente.eliminarCliente(\"#=IdCliente#\");'> <i class=\"fa fa-trash-o fa-2x\"></i></div>" }

                ]
            });

        } catch (ex) {
            alert(ex.message);
        }
    }

    this.eliminarCliente = function (iIdCliente) {
        jsonCliente.IdCliente = iIdCliente;
        oServicesApiRest.sMetodoApi = "DeleteCliente";
        oServicesApiRest.sSolicitudRest = "DELETE";
        objCliente.crudTipoServicio("DELETE");
    }

    this.consultarCliente = function () {
        var jsonResponse;

        $.ajax({
            type: "GET",
            url: "/SelectCliente",
            dataType: "json",
            success: function (data) {
                jsonResponse = data;
                objCliente.crearGrilla(jsonResponse);
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

    }

    this.mostrarVentana = function (sNombreVentana) {
        $('#popup_tiposervicio').modal({
            backdrop: "static",
            keyboard: false,
            width: "100%"
        });

        $(".modal-title").text(sNombreVentana);
    }

    this.cerrarVentana = function () {
        $("#popup_tiposervicio").modal("hide");
    }

    this.mostrarPopup = function (sOperacion, oTipoServicio) {

        var sTituloVentana;
        var ObjBoton;
        var ObjTextBoton;

        try {

            ObjBoton = $("#Button_GuardarCliente");
            ObjTextBoton = $("#Button_GuardarCliente").find("span");
            //Validar Operacion a realizar: POST,
            if (sOperacion == "POST") {
                sTituloVentana = "Nuevo cliente";
                $(ObjTextBoton).text("Guardar");
                oServicesApiRest.sSolicitudRest = sOperacion;
                oServicesApiRest.sMetodoApi = "InsertCliente";
                ObjBoton.attr("onclick", "javascript:objCliente.validarCampo('POST');");

            }

            var ObjTd = ObjBoton.parent();
            var sHtmlTd = ObjTd.html();
            ObjTd.html(sHtmlTd);

            objCliente.mostrarVentana(sTituloVentana);

        } catch (ex) {
            alert(ex.message);
        }

    }

    this.validarCampo = function (sOperacion) {
        //Validar
        var cControl = "", sControl = "";
        sIdCliente = 1;
        sNombre = $("#input_Nombre").val();
        sApellidos = $("#input_Apellidos").val();
        sIdentificacion = $("#input_Identificacion").val();
        sCorreo = $("#input_Correo").val();
        sDireccion = $("#input_Direccion").val();
        sTelefono = $("#input_Telefono").val();
        bEstado = true;
        sFechaCreacion = null;
        sFechaModificacion = null;
        sUsuarioCreacion = "admin";
        sUsuarioModificacion = "admin";

        if (sNombre == "") {
            cControl = $("#input_Nombre");
            sControl = "nombre";
        }
        if (sApellidos == "") {
            cControl = $("#input_Apellidos");
            sControl = "Apellidos";
        }
        if (sIdentificacion == "") {
            cControl = $("#input_Identificacion");
            sControl = "Identificación";
        }
        if (cControl != "") {
            notif({
                msg: "<b>¡Atento!</b> Por favor ingrese '" + sControl + "' del cliente",
                type: "info",
                position: "right"
            });
            cControl.focus();
            cControl.css("background-color", "#FBE5E0");
        } else {
            jsonCliente.Nombre = sNombre;
            jsonCliente.Apellidos = sApellidos;
            jsonCliente.Identificacion = sIdentificacion;
            jsonCliente.Correo = sCorreo;
            jsonCliente.Direccion = sDireccion;
            jsonCliente.Telefono = sTelefono;
            jsonCliente.Estado = bEstado;
            jsonCliente.FechaCreacion = sFechaCreacion;
            jsonCliente.FechaModificacion = sFechaModificacion;
            jsonCliente.UsuarioCreacion = sUsuarioCreacion;
            jsonCliente.UsuarioModificacion = sUsuarioModificacion;
            objCliente.crudCliente("POST");
        }
    }

    this.limpiarComponentes = function () {
        $("#input_Nombre, #input_Apellidos, #input_Identificacion, #input_Correo, #input_Direccion, #input_Estado, #input_Telefono").val("");
        $("#input_Nombre, #input_Apellidos, #input_Identificacion, #input_Correo, #input_Direccion, #input_Estado, #input_Telefono").css("background-color", "");
    }

    this.crudCliente = function (sOperacion) {
        //Petición ajax al ControllerLogin
        var jsonResponse
        $.ajax({
            type: oServicesApiRest.sSolicitudRest,
            url: "/" + oServicesApiRest.sMetodoApi,
            dataType: "json",
            data: jsonCliente,
            success: function (data) {
                jsonResponse = data;
                if (!jsonResponse.Error) {

                    notif({
                        msg: "<b>¡Bien hecho! </b>" + jsonResponse.Mensaje,
                        type: "success",
                        position: "right"
                    });
                    if (sOperacion != "DELETE")
                        objCliente.cerrarVentana();

                    objCliente.limpiarComponentes();
                    objCliente.crearGrilla(jsonResponse.Resultado);
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


}

objCliente = new Cliente();