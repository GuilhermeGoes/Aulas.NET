<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ResponderChamado.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ResponderChamado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center" style="color:#d52303">Abertura de Chamado</h2>
        <div class="row">
            <div class="col-md-7">
                
                <%--Chamado--%>
                <div class="form-group">
                    <asp:label id="chamadoLabel" runat="server" text="Chamado:"></asp:label>
                    <asp:DropDownList ID="chamadoDropDownList" 
                        runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:button id="buscarButton" runat="server" Text="Buscar Chamado" 
                    Cssclass="btn btn-info" OnClick="buscarButton_Click" />
                 
                    <asp:button id="removerButton" runat="server" Text="Remover Chamado" 
                    Cssclass="btn btn-danger" OnClick="removerButton_Click" />
                </div>

                <%--Buscar Chamado--%>
                <div class="form-group">
                    <asp:label id="buscarLabel" runat="server" text="Descrição:"></asp:label>
                    <asp:textbox id="descricaoTextBox" ReadOnly="true"
                        TextMode="MultiLine"
                        cssclass="form-control text-primary" 
                        runat="server"></asp:textbox>
                </div>

                 <%--Responder Chamado--%>
                <div class="form-group">
                    <asp:label id="responderLabel" runat="server" text="Responder:"></asp:label>
                    <asp:textbox id="responderTextbox" TextMode="MultiLine"
                        cssclass="form-control" 
                        runat="server"></asp:textbox>
                </div>

                <div class="form-group">
                    <asp:button id="enviarButton" runat="server" Text="Responder Chamado" 
                        Cssclass="btn btn-primary" OnClick="enviarButton_Click" />
                </div>

                <div class="form-group">
                    <asp:label id="mensagemLabel" runat="server"></asp:label>
                </div>
                
            </div>    
        </div>
     </div>
    
</asp:Content>
