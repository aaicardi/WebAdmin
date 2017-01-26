<%@ Page Title="" Language="C#" MasterPageFile="~/webadmin-app/src/main/webapp/pages/home.Master" AutoEventWireup="true" CodeBehind="tipoServicio.aspx.cs" Inherits="WebAdmin.webadmin_app.src.main.webapp.pages.tipoServicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Tipo Servicio</title>
    <link href="../style/configuracion/general.css" rel="stylesheet" />
    <link type="text/css" href="../js/notifIt/css/notifIt.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <div style="background-color: rgb(248, 250, 253);">
            <table style="width: 99%;">
                <tr>
                    <td style="text-align: center;">
                        <span style="color: #848484; font-size: large;">TIPO DE SERVICIO
                        </span>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right; padding-bottom: 5px;">
                        <button class="k-button" id="Button_nuevo" type="button" onclick="objTipoServicio.mostrarPopup('POST');">
                            <span class="fa fa-floppy-o"></span><span>&nbsp;Nuevo</span>
                        </button>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div id="Grid_TipoServicio" style="width: 100%"></div>
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
                            <span>Precio:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_Precio" class="k-textbox textInput" type="number"/>
                        </div>
                        <div class="col-md-12">
                            <span>Descripción:</span>
                            <textarea id="Textarea_Mision" class="k-textbox textarea" maxlength="900"></textarea>
                        </div>
                    </div>
                    &nbsp;
                    <div class="row">
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <button id="Button_GuardarUsuario" type="button" class="k-button" style="float: right;">
                                &nbsp;&nbsp;<span> Guardar</span>&nbsp;&nbsp;
                            </button>
                        </div>
                    </div>

                </div>

            </div>

        </div>
    </div>

    <script type="text/javascript" src="../js/notifIt/js/notifIt.js"></script>
    <script src="../js/jquery-1.10.2.min.js"></script>
    <script src="../js/Administracion/tipoServicio.js"></script>
</asp:Content>
