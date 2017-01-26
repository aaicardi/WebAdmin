$(document).ready(function () {
    try {

        objEmpleado.consultarEmpleado();

    } catch (ex) {
        alert(ex.message);
    }
});


function Empleado() {
    //Variables globales

    var iIdEmpleado
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
   , sCargo
    var jsonEmpleado = {
        IdEmpleado: 0
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
       , Cargo: ""
    }
    var oServicesApiRest = {
        sSolicitudRest: "",
        sMetodoApi: ""
    }


    this.crearGrilla = function (jsonDatos) {

        try {

            $("#Grid_Empleados").empty();
            $("#Grid_Empleados").kendoGrid({

                dataSource: {

                    data: jsonDatos,
                    pageSize: 6
                },
                schema: {

                    model: {

                        fields: {
                            Identificacion: { type: "string" },
                            Nombre: { type: "string" },
                            Apellidos: { type: "string" },
                            Correo: { type: "string" },
                            Direccion: { type: "string" },
                            Telefono: { type: "string" },
                            Cargo: { type: "string" },
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

                            { width: "5%", title: " ", template: "<div title=\"Editar\"  style=\"text-align:center;cursor:pointer;\" onclick='objEmpleado.editarEmpleado(\"#=Nombre#\", \"#=Apellidos#\",\"#=Identificacion#\",\"#=Correo#\",\"#=Direccion#\",\"#=Telefono#\",\"#=Estado#\",\"#=Cargo#\");'><i class=\"fa fa-pencil fa-2x\"></i></div>" },
                            { field: "Nombre", title: "Nombre", width: "15%", filterable: { cell: { operator: "contains" } } },
                            { field: "Apellidos", title: "Apellidos", width: "15%", filterable: { cell: { operator: "contains" } } },
                            { field: "Identificacion", title: "Identificación", width: "18%", filterable: { cell: { operator: "contains" } } },
                            { field: "Correo", title: "Correo", width: "15%", filterable: { cell: { operator: "contains" } } },
                            { field: "Cargo", title: "Cargo", width: "10%", filterable: { cell: { operator: "contains" } } },
                            { field: "Telefono", title: "Teléfono", width: "10%", filterable: { cell: { operator: "contains" } } },
                            { title: " ", width: "5%", template: "<div title=\"Eliminar\" style=\"text-align:center;cursor:pointer;\" onclick='objEmpleado.eliminarEmpleado(\"#=IdEmpleado#\");'> <i class=\"fa fa-trash-o fa-2x\"></i></div>" }

                ]
            });

        } catch (ex) {
            alert(ex.message);
        }
    }

    this.eliminarEmpleado = function (iIdEmpleado) {
        jsonEmpleado.IdEmpleado = iIdEmpleado;
        oServicesApiRest.sMetodoApi = "DeleteEmpleado";
        oServicesApiRest.sSolicitudRest = "DELETE";
        objEmpleado.crudEmpleado("DELETE");
    }

    //Editar
    this.editarEmpleado = function (sNombre, sApellidos, sIdentificacion, sCorreo, sDireccion, sTelefono, sEstado, sCargo) {
        jsonEmpleado.Nombre = sNombre;
        jsonEmpleado.Apellidos = sApellidos;
        jsonEmpleado.Identificacion = sIdentificacion;
        jsonEmpleado.Correo = sCorreo;
        jsonEmpleado.Direccion = sDireccion;
        jsonEmpleado.Telefono = sTelefono;
        jsonEmpleado.Cargo = sCargo;
        objEmpleado.mostrarPopup('PUT');
    }

    this.consultarEmpleado = function () {
        var jsonResponse;

        $.ajax({
            type: "GET",
            url: "/SelectEmpleado",
            dataType: "json",
            success: function (data) {
                jsonResponse = data;
                objEmpleado.crearGrilla(jsonResponse);
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
        $('#popup_Empleado').modal({
            backdrop: "static",
            keyboard: false,
            width: "100%"
        });

        $(".modal-title").text(sNombreVentana);
        $("#input_Estado").kendoComboBox({
            dataTextField: "text",
            dataValueField: "value",
            dataSource: [
                { text: "Activo", value: "1" },
                { text: "Inactivo", value: "0" }
            ],
            filter: "contains",
            suggest: true,
            index: 0
        });
    }

    this.cerrarVentana = function () {
        $("#popup_Empleado").modal("hide");
    }

    this.mostrarPopup = function (sOperacion, oTipoServicio) {

        var sTituloVentana;
        var ObjBoton;
        var ObjTextBoton;

        try {

            ObjBoton = $("#Button_GuardarEmpleado");
            ObjTextBoton = $("#Button_GuardarEmpleado").find("span");
            //Validar Operacion a realizar: POST,
            if (sOperacion == "POST") {
                sTituloVentana = "Nuevo Empleado";
                $(ObjTextBoton).text("Guardar");
                oServicesApiRest.sSolicitudRest = sOperacion;
                oServicesApiRest.sMetodoApi = "InsertEmpleado";
                ObjBoton.attr("onclick", "javascript:objEmpleado.validarCampo('POST');");

            }
            if (sOperacion == "PUT") {
                sTituloVentana = "Editar empleado";
                $(ObjTextBoton).text("Editar");
                oServicesApiRest.sSolicitudRest = sOperacion;
                oServicesApiRest.sMetodoApi = "UpdateEmpleado";
                ObjBoton.attr("onclick", "javascript:objEmpleado.validarCampo('PUT');");
                $("#input_Nombre").val(jsonEmpleado.Nombre);
                $("#input_Apellidos").val(jsonEmpleado.Apellidos);
                $("#input_Direccion").val(jsonEmpleado.Direccion);
                $("#input_Correo").val(jsonEmpleado.Correo);
                $("#input_Identificacion").val(jsonEmpleado.Identificacion);
                $("#input_Telefono").val(jsonEmpleado.Telefono);
                $("#input_Estado").val(jsonEmpleado.Estado);
            }
            var ObjTd = ObjBoton.parent();
            var sHtmlTd = ObjTd.html();
            ObjTd.html(sHtmlTd);

            objEmpleado.mostrarVentana(sTituloVentana);

        } catch (ex) {
            alert(ex.message);
        }

    }

    this.validarCampo = function (sOperacion) {
        //Validar
        var cControl = "", sControl = "";
        sIdEmpleado = 1;
        sNombre = $("#input_Nombre").val();
        sApellidos = $("#input_Apellidos").val();
        sIdentificacion = $("#input_Identificacion").val();
        sCorreo = $("#input_Correo").val();
        sDireccion = $("#input_Direccion").val();
        sTelefono = $("#input_Telefono").val();
        bEstado = $("#input_Estado").val();
        sFechaCreacion = $("#hdn_fecha").val();
        sFechaModificacion = $("#hdn_fecha").val();
        sUsuarioCreacion = parent.$("#span_NombreUsuario").text();
        sUsuarioModificacion = parent.$("#span_NombreUsuario").text();

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
                msg: "<b>¡Atento!</b> Por favor ingrese '" + sControl + "' del Empleado",
                type: "info",
                position: "right"
            });
            cControl.focus();
            cControl.css("background-color", "#FBE5E0");
        } else {
            jsonEmpleado.Nombre = sNombre;
            jsonEmpleado.Apellidos = sApellidos;
            jsonEmpleado.Identificacion = sIdentificacion;
            jsonEmpleado.Correo = sCorreo;
            jsonEmpleado.Direccion = sDireccion;
            jsonEmpleado.Telefono = sTelefono;
            jsonEmpleado.Estado = bEstado;
            jsonEmpleado.FechaCreacion = sFechaCreacion;
            jsonEmpleado.FechaModificacion = sFechaModificacion;
            jsonEmpleado.UsuarioCreacion = sUsuarioCreacion;
            jsonEmpleado.UsuarioModificacion = sUsuarioModificacion;
            objEmpleado.crudEmpleado("POST");
        }
    }

    this.limpiarComponentes = function () {
        $("#input_Nombre, #input_Apellidos, #input_Identificacion, #input_Correo, #input_Direccion, #input_Estado, #input_Telefono").val("");
        $("#input_Nombre, #input_Apellidos, #input_Identificacion, #input_Correo, #input_Direccion, #input_Estado, #input_Telefono").css("background-color", "");
    }

    this.crudEmpleado = function (sOperacion) {
        //Petición ajax al ControllerLogin
        var jsonResponse
        $.ajax({
            type: oServicesApiRest.sSolicitudRest,
            url: "/" + oServicesApiRest.sMetodoApi,
            dataType: "json",
            data: jsonEmpleado,
            success: function (data) {
                jsonResponse = data;
                if (!jsonResponse.Error) {

                    notif({
                        msg: "<b>¡Bien hecho! </b>" + jsonResponse.Mensaje,
                        type: "success",
                        position: "right"
                    });
                    if (sOperacion != "DELETE")
                        objEmpleado.cerrarVentana();

                    objEmpleado.limpiarComponentes();
                    objEmpleado.crearGrilla(jsonResponse.Resultado);
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

objEmpleado = new Empleado();