<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="contacto.aspx.cs" Inherits="Web.contacto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container cuerpo">
        <div class="row contacto">
            <div class="col-md-12">
                <h1>Formulario de Contacto</h1>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="AllValidators" CssClass="validar"/>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Nombres: "></asp:Label><asp:TextBox ID="txtnombres" runat="server" CssClass="form-control"></asp:TextBox><br /><asp:RequiredFieldValidator ControlToValidate="txtnombres" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Los nombres son requeridos" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Los nombres solo deben contener letras" Text="Los nombres solo deben contener letras" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txtnombres" ValidationExpression="[A-Za-z ]*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Apellidos: "></asp:Label><asp:TextBox ID="txtapellidos" runat="server" CssClass="form-control"></asp:TextBox><br /><asp:RequiredFieldValidator ControlToValidate="txtapellidos" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Los apellidos son requeridos" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="Los apellidos solo deben contener letras" Text="Los apellidos solo deben contener letras" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txtapellidos" ValidationExpression="[A-Za-z ]*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Email: "></asp:Label><asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox><br /><asp:RequiredFieldValidator ControlToValidate="txtemail" ID="RequiredFieldValidator3" runat="server" ErrorMessage="El email es requerido" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Las direcciones de correo electrónico deben estar en el formato nombre@dominio.xyz." ControlToValidate="txtemail" Display="Dynamic" Text="Formato no válido" ValidationGroup="All Validators" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label4" runat="server" Text="Telefono: "></asp:Label><asp:TextBox ID="txttelefono" runat="server" CssClass="form-control"></asp:TextBox><br /><asp:RequiredFieldValidator ControlToValidate="txttelefono" ID="RequiredFieldValidator4" runat="server" ErrorMessage="El telefono es requerido" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator><asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="El telefono sólo debe contener números" Text="El telefono sólo debe contener números" Display="Dynamic" ValidationGroup="AllValidators" ControlToValidate="txttelefono" ValidationExpression="\d+" CssClass="validar"></asp:RegularExpressionValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label5" runat="server" Text="Mensaje: "></asp:Label><asp:TextBox ID="txtmensaje" runat="server" CssClass="form-control" Height="160px"></asp:TextBox><br /><asp:RequiredFieldValidator ControlToValidate="txtmensaje" ID="RequiredFieldValidator5" runat="server" ErrorMessage="El mensaje es requerido" Display="Dynamic" Text="*" ValidationGroup="AllValidators" CssClass="validar"></asp:RequiredFieldValidator>
                    
                </div>
                <asp:Button ID="enviar" runat="server" Text="Enviar" cssClass="btn btn-default" ValidationGroup="AllValidators" OnClick="enviar_Click"/>
         </div>
            <asp:Label ID="message" runat="server" Text="Label" CssClass="mensaje"></asp:Label><br />
            
        </div>
</asp:Content>
