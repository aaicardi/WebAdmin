//***********************************************************
// Author           : Alex Aicardi
// Created          : 21/08/2016
// Description      : Bugs
// Last Modified By : 
// Last Modified On : 
// Copyright © 2016 Barbersoft. All right reserved 
//************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAdmin.webadmin_model.Model
{
    /// <summary>
    /// Description: Bugs Class
    /// Developer: Ing. Alex Aicardi 
    /// Date: 21/08/2016
    /// </summary>
    public class Bugs
    {
        public string Mensaje { get; set; }
        public bool Error { get; set; }
        public object Resultado { get; set; }

        //Constructor
        public Bugs()
        {
        }
    }
}