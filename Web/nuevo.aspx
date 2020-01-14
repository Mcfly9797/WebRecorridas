<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="nuevo.aspx.cs" Inherits="Web.nuevo" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

                               <!--Formulario-->
                <div class="container login-container">
                    <div class="row justify-content-center">
                        <div class="col-md-6 login-form">
                            <h2>Nuevo prestamo</h2>

                                <div class="form-group">
                                    <input type="text" class="form-control" placeholder="Marca *" value="" />
                                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" PlaceHolder="Marca *"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <input type="text" class="form-control" placeholder="Modelo *" value="" />
                                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <input type="password" class="form-control" placeholder="Serial *" value="" />
                                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <input type="password" class="form-control" placeholder="Nombres usuario a prestar *" value="" />
                                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                
                                </div>
                                <div class="form-group">
                                    <input type="password" class="form-control" placeholder="Legajo *" value="" />
                                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <a style="color: cornsilk;"> <strong>Fecha devolucion</strong></a>
                                    <input type="date" class="form-control"  value="" />
                                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>

                                </div>
                                <div class="form-group">
                                    <input type="submit" class="btnSubmit" value="Crear prestamo" />
                                    <asp:Button ID="Button1" runat="server" Text="Button" />

                                </div>


                            </div>
                        </div>
                    </div>




</asp:Content>
