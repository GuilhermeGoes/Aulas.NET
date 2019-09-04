<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ListaItensAjax.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ListaItensAjax" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div class="container">
        <h2 class="text-center" style="color:#d52303">Lista de Itens</h2>

         <%--Pedido + Cliente--%>
         <div class="form-group">
             <asp:label id="pedidoLabel" runat="server" text="Pedido:"></asp:label>
             <asp:DropDownList ID="pedidosDropDownList" 
                 runat="server" CssClass="form-control"
                 AutoPostBack="true"
                 OnSelectedIndexChanged="pedidosDropDownList_SelectedIndexChanged"></asp:DropDownList>
         </div>
         <hr />

        <asp:Repeater ID="itensRepeater" runat="server">
            <HeaderTemplate></HeaderTemplate>
            
            <ItemTemplate>
                <div class =" alert alert-secondary">
                    
                    <div style="float: right;">
                        <asp:LinkButton 
                            ID="excluirLinkButton" 
                            runat="server"
                            OnClientClick="javascript:return confirm('Tem Certeza?');"
                            OnClick="excluirLinkButton_Click"
                            CommandArgument='<%# Eval("IdItem")%>'>
                            [x]

                        </asp:LinkButton>
                        
                    </div>
                    
                    <strong>Produto:</strong>
                    <asp:Label ID="produtoLabel" runat="server" Text='<%# Eval("DescricaoProduto")%>'></asp:Label> <br />

                    <strong>Num. Pedido:</strong>
                    <asp:Label ID="pedidoLabel" runat="server" Text='<%# Eval("NumeroPedido")%>'></asp:Label> <br />

                    <strong>Data Pedido:</strong>
                    <asp:Label ID="dataLabel" runat="server" Text='<%# Eval("DataPedido")%>'></asp:Label> <br />

                    <strong>Valor Pedido:</strong>
                    <asp:Label ID="valorLabel" runat="server" Text='<%# Eval("ValorTotalItem")%>'></asp:Label> <br />
                </div>
            </ItemTemplate>
            
            <FooterTemplate></FooterTemplate>

        </asp:Repeater>

    </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
