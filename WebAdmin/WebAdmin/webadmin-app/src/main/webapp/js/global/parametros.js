//***********************************************************
// Author           : Alex Aicardi
// Created          : 19/08/2016
// Description      : Parametros
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//**********************************************************

/// <summary>
/// Description: Parametros globales
/// </summary>
function Parametros() {

    var storage = localStorage;

    //Insertar parametros
    this.insertarParametros = function (lstParametros) {
        storage.setItem("Parametros", lstParametros);
    }

    //Eliminar parametros
    this.eliminarParametros = function () {
        storage.removeItem("Parametros");
    }

    //Consultar parametros
    this.consultarParametros = function () {
        return storage.getItem("Parametros");
    }
}
objParametros = new Parametros();