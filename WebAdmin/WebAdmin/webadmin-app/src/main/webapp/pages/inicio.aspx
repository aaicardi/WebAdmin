<%@ Page Title="" Language="C#" MasterPageFile="~/webadmin-app/src/main/webapp/pages/home.Master" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="WebAdmin.webadmin_app.src.main.webapp.pages.inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Seccion de inicio</title>
    <link type="text/css" href="../js/notifIt/css/notifIt.css" rel="stylesheet" />
    <link href="../style/configuracion/general.css" rel="stylesheet" />
    <script src="../js/jquery-1.10.2.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <div class="row">
        <div class="col-lg-12">
            <h1 class="page-header">Tablero inicial</h1>
        </div>
    </div>
    <%-- Tablero inicial --%>
    <div class="row">
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-file-text-o fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">Factura</div>
                            <div></div>
                        </div>
                    </div>
                </div>
                <a href="#" onclick="objInicio.mostrarPopup('POST');">
                    <div class="panel-footer">
                        <span class="pull-left">View Details</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-green">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-tasks fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">12</div>
                            <div>New Tasks!</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">View Details</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-yellow">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-shopping-cart fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">124</div>
                            <div>New Orders!</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">View Details</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
        <div class="col-lg-3 col-md-6">
            <div class="panel panel-red">
                <div class="panel-heading">
                    <div class="row">
                        <div class="col-xs-3">
                            <i class="fa fa-support fa-5x"></i>
                        </div>
                        <div class="col-xs-9 text-right">
                            <div class="huge">13</div>
                            <div>Support Tickets!</div>
                        </div>
                    </div>
                </div>
                <a href="#">
                    <div class="panel-footer">
                        <span class="pull-left">View Details</span>
                        <span class="pull-right"><i class="fa fa-arrow-circle-right"></i></span>
                        <div class="clearfix"></div>
                    </div>
                </a>
            </div>
        </div>
    </div>
    <%-- --- --%>
    </div>
    <%-- Ventana de factura --%>
    <div id="popup_Factura" class="modal fade" role="dialog">
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
                            <span>Fecha:</span>
                            <input id="input_Fecha"  readonly="readonly"/>
                        </div>
                        <div class="col-md-12">
                            <span>Tipo Servicio:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_TipoServicio" class="comboFactura"/>
                        </div>
                        <div class="col-md-12">
                            <span>Empleado:</span>
                            <span class="CampoRequerido">*</span>
                            <input id="input_Empleado" class="comboFactura"/>
                        </div>
                        <div class="col-md-12">                      
                            <span>Nombre del cliente:</span>
                            <input id="input_Nombre" class="k-textbox textInput" type="text" />
                            <span>Cedula  del cliente:</span>
                            <input id="input_Cedula" class="k-textbox textInput" type="text" />
                        </div>
                        <div class="col-md-12">
                            <span>Valor Servicio:</span>
                            <input id="input_ValorServicio" class="k-textbox textInput" type="text" readonly="readonly" />
                        </div>
                    </div>
                    &nbsp;
                    <div class="row">
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                        </div>
                        <div class="col-md-4">
                            <button id="Button_GuardarFactura" type="button" class="k-button" style="float: right;">
                                &nbsp;&nbsp;<span> Guardar</span>&nbsp;&nbsp;
                            </button>
                        </div>
                    </div>

                </div>

            </div>

        </div>
    </div>
    <%--  --%>
    <script type="text/javascript" src="../js/notifIt/js/notifIt.js"></script>
    <script src="../js/Administracion/inicio.js"></script>
    <script src="../js/jquery-1.10.2.min.js"></script>
</asp:Content>
