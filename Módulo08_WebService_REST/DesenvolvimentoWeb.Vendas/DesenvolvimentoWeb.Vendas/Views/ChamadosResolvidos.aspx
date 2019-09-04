<%@ Async="true" Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="ChamadosResolvidos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.ChamadosResolvidos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">
    <div class="container">
        <h2 class="text-center" style="color:#d52303">Chamados Resolvidos</h2>
        <div class="row">

                <%--Chamados Resolvidos --%>
                <div class="col-md-7">
                <asp:Label ID="Label1" runat="server" Text="Chamados Resolvidos"></asp:Label>
                <asp:Repeater ID="resolvidosRepeater" runat="server">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <td>Id</td>
                                    <td>Assunto</td>
                                    <td>Descricao</td>
                                    <td>Resposta</td>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                        
                    <ItemTemplate>
                        <tr>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Id") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Assunto") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Descricao") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Resposta") %>'></asp:Label>
                            </td>
                        </tr>
                    </ItemTemplate>

                    <FooterTemplate>
                            </tbody>
                        </table>
                    </FooterTemplate>
                    
                </asp:Repeater>
            </div>
                    
                </div>

        </div>

</asp:Content>
