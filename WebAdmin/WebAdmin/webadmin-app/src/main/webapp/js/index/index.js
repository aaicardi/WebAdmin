//***********************************************************
// Author           : Ing. Alex Aicardi
// Created          : 26/08/2016
// Description      : index
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************

$(document).ready(function () {
    try {
        //Validar sesión
    objFuncionesGlobales.validarSesion();
    } catch (e) {
        notif({
            msg: "<b>¡Error! </b>" + e.message,
            type: "error",
            position: "right"
        });
    }

   
});

function index() {

    this.clientes = function () {

    }
}
objIndex = new index();