/// <reference path="login.js" />
//***********************************************************
// Author           : Ing. Alex Aicardi
// Created          : 21/08/2016
// Description      : Login
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************

$(document).ready(function () {
    try {
        $('#input_Usuario').validCampoFranz('abcdefghijklmnñopqrstuvwxy0123456789');
        var session = objSession.consultarSession();
        //Validar si existe información de sesión
        if (session != null) {
            objFuncionesGlobales.redireccionar("inicio.aspx");
        } 
    } catch (e) {
        notif({
            msg: "<b>¡Error! </b>" + e.message,
            type: "error",
            position: "right"
        });
    }


});

//Funcion para limitar el ingreso de cualquier caracter.
(function (a) {
    a.fn.validCampoFranz = function (b) {
        a(this).on({
            keypress: function (a) {
                var c = a.which,
                    d = a.keyCode,
                    e = String.fromCharCode(c).toLowerCase(),
                    f = b; (-1 != f.indexOf(e) || 9 == d || 37 != c && 37 == d || 39 == d && 39 != c || 8 == d || 46 == d && 46 != c) && 161 != c || a.preventDefault()
            }
        })
    }
})(jQuery);

/// <summary>
/// Description: function login
/// Developer: Ing. Alex Aicardi
/// </summary>
function Login() {

    //Validar
    this.validar = function () {
        var User = "";
        var Password = "";
        User = $("#input_Usuario").val();
        Password = $("#input_Password").val();

        if (User == "") {
            notif({
                msg: "<b>¡Atento!</b> Ingrese nombre de usuario",
                type: "info",
                position: "center"
            });
            $("#input_Usuario").focus();
            $("#input_Usuario").css("background-color", "#FBE5E0");
        } else if (Password == "") {
            notif({
                msg: "<b>¡Atento!</b> Ingrese contraseña",
                type: "info",
                position: "center"
            });
            $("#input_Password").focus();
            $("#input_Password").css("background-color", "#FBE5E0");
        } else {

            var jsonUser = {
                Nombre: User,
                Clave: Password,
            }
            //Petición ajax al ControllerLogin
            $.ajax({
                type: "POST",
                url: "/Login",
                dataType: "json",
                data: jsonUser,
                beforeSend: function (e) {
                    $("#ajax_loader").show();
                },
                success: function (data) {
                    jsonResponse = data;
                    if (!jsonResponse.Error) {
                        //Almacenar datos de la sesión en localstorage
                        objSession.iniciarSession(jsonResponse.Resultado[0]);
                        //Limpiar entrada de texto
                        $("#input_Usuario, #input_Password").val("");
                        //Cerrar GIF
                        $("#ajax_loader").hide();
                        //Redireccionar página
                        objFuncionesGlobales.redireccionar("inicio.aspx");
                    } else {
                        //Cerrar GIF
                        $("#ajax_loader").hide();
                        //Notificar mensaje de error 
                        notif({
                            msg: "<b>¡Oh! </b>" + jsonResponse.Mensaje,
                            type: "error",
                            position: "right"
                        });
                    }
                },
                error: function (data) {
                    //Cerrar GIF
                    $("#ajax_loader").hide();
                    //Notificar mensaje de error 
                    notif({
                        msg: "<b>¡Error! </b>" + data.statusText,
                        type: "error",
                        position: "right"
                    });
                }
            });
        }
    }
}
objLogin = new Login();