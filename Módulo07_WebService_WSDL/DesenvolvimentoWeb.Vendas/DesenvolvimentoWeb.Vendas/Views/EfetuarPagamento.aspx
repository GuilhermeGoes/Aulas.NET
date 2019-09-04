<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="EfetuarPagamento.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.EfetuarPagamento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
     <div class="container">
         <h2 class="text-center" style="color:#d52303">Selecionar um item para pagar</h2>

         <%--Pedido + Cliente--%>
         <div class="form-group">
             <asp:label ID="pedidoLabel" runat="server" text="Pedido:"></asp:label>
             <asp:DropDownList ID="pedidosDropDownList" 
                 runat="server" CssClass="form-control">
             </asp:DropDownList>
         </div>
         <hr />

         <div class="form-group">
             <asp:label ID="cartaoLabel" runat="server" 
                 text="Número do Cartão:"></asp:label>
             <asp:TextBox ID="cartaoTextBox" runat="server"
                 MaxLength="16"
                 CssClass="form-control"></asp:TextBox>
             <asp:RequiredFieldValidator
                 ID="RequiredFieldValidator1" 
                 runat="server" 
                 ErrorMessage="Fornecer o numero do cartão"
                 ControlToValidate="cartaotextBox"
                 Display="Dynamic"
                 CssClass="text text-danger"></asp:RequiredFieldValidator>
         </div>

         <div class="form-group">
             <asp:Button 
                 ID="pagamentoButton" 
                 runat="server" 
                 Text="Efetuar Pagamento"
                 CssClass="btn btn-primary" 
                 OnClick="pagamentoButton_Click"/>
         </div>

         <div class="form-group">
             <asp:Label 
                 ID="mensagemLabel" 
                 runat="server" 
                 Text=""></asp:Label>
         </div>
     </div>
    
</asp:Content>
