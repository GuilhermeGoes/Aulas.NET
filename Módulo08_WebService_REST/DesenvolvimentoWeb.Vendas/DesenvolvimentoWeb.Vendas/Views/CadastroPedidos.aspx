<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroPedidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroPedidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center" style="color:#d52303">Inclusão de Pedidos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados</h3>

                <%--Cliente--%>
                <div class="form-group">
                    <asp:label id="clienteLabel" runat="server" text="Cliente:"></asp:label>
                    <asp:DropDownList ID="clienteDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <%--Data--%>
                <div class="form-group">
                    <asp:label id="dataLabel" runat="server" text="Data:"></asp:label>
                    <asp:textbox id="dataTextBox" cssclass="form-control" runat="server" TextMode="Date"></asp:textbox>
                </div>

                <%--Numero Pedido--%>
                <div class="form-group">
                    <asp:label id="pedidoLabel" runat="server" text="Num. Pedido:"></asp:label>
                    <asp:textbox id="pedidoTextBox" cssclass="form-control" runat="server" MaxLength="20"></asp:textbox>
                </div>

                <asp:button id="enviarButton" runat="server" Text="Incluir Produto" 
                    Cssclass="btn btn-primary" OnClick="enviarButton_Click" />

                <div>
                    <asp:label id="mensagemLabel" runat="server"></asp:label>
                </div>

            </div>
           <%--<div class="col-md-7">
                <h3>Lista de Clientes</h3>
                <asp:Repeater ID="clientesRepeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <td>Cpf</td>
                                    <td>Nome</td>
                                    <td>Telefone</td>
                                    <td>Email</td>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                        
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Documento") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Nome") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Telefone") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>

                    <FooterTemplate>
                            </tbody>
                        </table>
                    </FooterTemplate>
                    
                </asp:Repeater>--%>
            </div>
        </div>
</asp:Content>
