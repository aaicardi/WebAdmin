//***********************************************************
// Author           : Ing. Alex Aicardi
// Created          : 21/08/2016
// Description      : Logout
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************

function Logout() {

    this.inicializar = function () {
        objSession.eliminarSession();
        window.location.href = "login.html";
    }
}
objLogout = new Logout();