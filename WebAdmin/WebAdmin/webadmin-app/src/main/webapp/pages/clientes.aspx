<%@ Page Title="" Language="C#" MasterPageFile="~/webadmin-app/src/main/webapp/pages/home.Master" AutoEventWireup="true" CodeBehind="clientes.aspx.cs" Inherits="WebAdmin.webadmin_app.src.main.webapp.pages.clientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>clientes</title>
    <link href="../style/configuracion/general.css" rel="stylesheet" />
    <link type="text/css" href="../js/notifIt/css/notifIt.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <div style="background-color: rgb(248, 250, 253);">
            <table style="width: 99%;">
                <tr>
                    <td style="text-align: center;">
                        <span style="color: #848484; font-size: large;">Clientes
                        </span>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; padding-bottom: 5px;">
                        <button class="k-button" id="Button_nuevo" type="button" onclick="objCliente.mostrarPopup('POST');">
                            <span class="fa fa-floppy-o"></span><span>&nbsp;Nuevo</span>
                        </button>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="Grid_Clientes" style="width: 100%"></div>
                    </td>
                </tr>
            </table>
        </div>
    </fieldset>
    <div id="popup_tiposervicio" class="modal fade" role="dialog">
        <div class="modal-dialog modal-md">

            <div class="modal-content">
                <%-- Cabecera --%>
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h4 class="modal-title"></h4>
                </div>
                <%-- Cuerpo --%>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-12">
                            <span>Nombre:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_Nombre" class="k-textbox textInput" type="text" maxlength="1000" />
                        </div>
                        <div class="col-md-12">
                            <span>Apellidos:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_Apellidos" class="k-textbox textInput" type="text" maxlength="1000" />
                        </div>
                        <div class="col-md-12">
                            <span>Identificación:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_Identificacion" class="k-textbox textInput" type="text" maxlength="1000" />
                        </div>
                        <div class="col-md-12">
                            <span>Correo:</span>
                            <span class="CampoRequerido"></span>
                            <input id="input_Correo" class="k-textbox textInput" type="text" maxlength="1000" />
                        </div>
                        &nbsp;
                    <div class="row">
                        <div class="col-md-4">
                            <div class="col-md-12">
                                <span>Dirección:</span>
                                <span class="CampoRequerido"></span>
                                <input id="input_Direccion" class="k-textbox textInput" type="text" maxlength="1000" />
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="col-md-12">
                                <span>Teléfono:</span>
                                <span class="CampoRequerido"></span>
                                <input id="input_Telefono" class="k-textbox textInput" type="text" maxlength="1000" />
                            </div>
                        </div>
                         <div class="col-md-4">
                            <div class="col-md-12">
                                <span>Estado:</span>
                                <span class="CampoRequerido">*</span>
                                <input type="checkbox" id="input_Estado" class="k-checkbox"/>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="col-md-12">
                                <button id="Button_GuardarCliente" type="button" class="k-button" style="float: right;">
                                    &nbsp;&nbsp;<span> Guardar</span>&nbsp;&nbsp;
                                </button>
                            </div>
                        </div>
                    </div>

                    </div>

                </div>

            </div>
        </div>
    </div>

    <script type="text/javascript" src="../js/notifIt/js/notifIt.js"></script>
    <script src="../js/jquery-1.10.2.min.js"></script>
    <script src="../js/Administracion/Cliente.js"></script>

</asp:Content>
