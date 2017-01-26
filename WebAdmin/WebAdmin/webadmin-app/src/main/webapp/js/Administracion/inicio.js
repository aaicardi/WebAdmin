var datePicker;

$(document).ready(function () {
    try {
        //Inicializar componente de fecha
           datePicker =   $("#input_Fecha").kendoDateTimePicker({
                    format: "yyyy/MM/dd hh:mm tt",
                    value: new Date()
                });
       
           datePicker = $("#input_Fecha").data("kendoDateTimePicker");
        //Inicializar combox
        objInicio.inicializarComboTipoServicio();
        objInicio.inicializarComboEmpleados();
     
        $("#input_TipoServicio").change(function () {
            var IdTipoServicio = "";
            var tipoServicio = {
                IdTipoServicio: ""
            }

            IdTipoServicio = $("#input_TipoServicio").val();
         
            if (IdTipoServicio != "") {
                tipoServicio.IdTipoServicio = IdTipoServicio;
                $.ajax({
                    type: "POST",
                    url: "/SelectIdTipoServicio",
                    dataType: "json",
                    data: tipoServicio,
                    success: function (data) {
                        var jsonResponse = data;

                        if (!jsonResponse.Error) {
                            var precio = jsonResponse.Resultado[0].Precio;
                            $("#input_ValorServicio").val(precio);
                        } else {
                            notif({
                                msg: "<b>¡Error! </b>" + "No fue posible cargar el precio del tipo de servicio",
                                type: "error",
                                position: "right"
                            });
                        }
                    
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
        
        });    
    
        $("#input_Nombre").change(function () {
            alert("HOla");
        });

        $("#input_Cedula").change(function () {
            alert("HOla");
        });
    } catch (ex) {
        alert(ex.message);
    }
});


function Inicio() {

    this.inicializarComboTipoServicio = function () {
        //Inicializar el comboTipoServicio
        $.ajax({
            type: "GET",
            url: "/SelectTipoServicio",
            dataType: "json",
            async: false,
            success: function (data) {
                var jsonResponse = data;
                $("#input_TipoServicio").kendoComboBox({
                    dataTextField: "Nombre",
                    dataValueField: "IdTipoServicio",
                    dataSource: jsonResponse
                });
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

    this.inicializarComboEmpleados = function () {
        //Inicializar comboEmpleados
        $.ajax({
            type: "GET",
            url: "/SelectEmpleado",
            dataType: "json",
            async: false,
            success: function (data) {
                var jsonResponse = data;
                $("#input_Empleado").kendoComboBox({
                    dataTextField: "Nombre",
                    dataValueField: "IdEmpleado",
                    dataSource: jsonResponse
                });
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
        $('#popup_Factura').modal({
            backdrop: "static",
            keyboard: false,
            width: "100%"
        });
        $(".modal-title").text(sNombreVentana);
    }

    this.mostrarPopup = function (sOperacion, oTipoServicio) {
      
        var sTituloVentana;
        var ObjBoton;
        var ObjTextBoton;
 

        try {
            datePicker.value(new Date());    
      
            ObjBoton = $("#Button_GuardarFactura");
            ObjTextBoton = $("#Button_GuardarFactura").find("span");
            //Validar Operacion a realizar: POST,
            if (sOperacion == "POST") {
                sTituloVentana ="FACTURA DE SERVICIO";
                $(ObjTextBoton).text("Guardar");
                //oServicesApiRest.sSolicitudRest = sOperacion;
                //oServicesApiRest.sMetodoApi = "InsertEmpleado";
                ObjBoton.attr("onclick", "javascript:objInicio.validarCampo('POST');");

            }

            var ObjTd = ObjBoton.parent();
            var sHtmlTd = ObjTd.html();
            ObjTd.html(sHtmlTd);      
            objInicio.mostrarVentana(sTituloVentana);

        } catch (ex) {
            alert(ex.message);
        }

    }

    this.validarCampo = function (sOperacion) {
        
    }
    this.limpiarComponentes = function () {
        $("#input_Empleado, #input_Nombre, #input_Cedula, #input_ValorServicio").val("");
        $("#input_Empleado, #input_Nombre, #input_Cedula, #input_ValorServicio").css("background-color", "");
    }

    this.change = function () {

     
    }
}
objInicio = new Inicio();
