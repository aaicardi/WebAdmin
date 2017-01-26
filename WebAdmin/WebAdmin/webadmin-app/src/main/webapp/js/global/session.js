//***********************************************************
// Author           : Alex Aicardi
// Created          : 19/08/2016
// Description      : Session
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//**********************************************************

/// <summary>
/// Session
/// </summary>
function Session() {

    var storage = localStorage;

    //Iniciar sesión    
    this.iniciarSession = function (oUser) {
        storage.setItem("User", JSON.stringify(oUser));
    }

    //Eliminar la sesión
    this.eliminarSession = function () {
        storage.removeItem("User");
    }

    //Consultar sesión
    this.consultarSession = function () {
        return storage.getItem("User");
    }
}
objSession = new Session();

