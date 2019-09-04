<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="AbrirChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.AbrirChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center" style="color:#d52303">Abertura de Chamado</h2>
        <div class="row">
            <div class="col-md-7">

                <%--Assunto--%>
                <div class="form-group">
                    <asp:label id="assuntoLabel" runat="server" text="Assunto:"></asp:label>
                    <asp:DropDownList ID="assuntoDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <%--Documento--%>
                <div class="form-group">
                    <asp:label id="documentoLabel" runat="server" text="Documento:"></asp:label>
                    <asp:textbox id="documentoTextBox" cssclass="form-control" runat="server"></asp:textbox>
                </div>

                <%--Descrição--%>
                <div class="form-group">
                    <asp:label id="descricaoLabel" runat="server" text="Descrição:"></asp:label>
                    <asp:textbox id="descricaoTextBox" 
                        TextMode="MultiLine" 
                        Rows="4" Columns="50"
                        CssClass="form-control" runat="server" MaxLength="20"></asp:textbox>
                </div>

                <asp:button id="enviarButton" runat="server" Text="Abrir Chamado" 
                    Cssclass="btn btn-primary" OnClick="enviarButton_Click" />

                <div>
                    <asp:label id="mensagemLabel" runat="server"></asp:label>
                </div>


            </div>
        </div>
    </div>
</asp:Content>
