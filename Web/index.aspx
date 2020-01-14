<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!--Formulario-->
    <div class="container login-container">
        <div class="row justify-content-center">
            <div class="col-md-6 login-form">

                <h2>Bienvenido</h2>
                <div class="form-check">
                    <a><strong>Selecione personal IT:</strong></a>
                </div>


                <br />


                <div class="form-check">
                    <asp:DropDownList ID="SoportistaDropDownList" runat="server" CssClass="form-control selcls"></asp:DropDownList>
                </div>

                <br />
                <br />


                <div class="form-check">

                    <a><strong>Selecione lugares recorridos:</strong></a>
                </div>


                <br />


                <div class="form-check">
                    <%--<asp:Label ID="Label1" runat="server" />--%>
                    <asp:CheckBoxList ID="Salones" runat="server"></asp:CheckBoxList>
                </div>


                <div class="form-check">
                    <asp:TextBox ID="Txtdetalles" runat="server" CssClass="form-control" PlaceHolder="Observaciones opcionales *"></asp:TextBox>
                </div>


                <br />

                <div class="form-group">
                    <asp:Button ID="BtnNuevaRecorrida" runat="server" Text="Ingresar" CssClass="btnSubmit" OnClick="BtnNuevaRecorrida_Click" />
                </div>


            </div>
        </div>
    </div>



</asp:Content>
