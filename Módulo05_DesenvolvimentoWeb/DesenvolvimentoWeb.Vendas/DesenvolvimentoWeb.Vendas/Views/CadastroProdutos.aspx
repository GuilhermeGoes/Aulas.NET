<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroProdutos.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroProdutos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container">
        <h2 class="text-center" style="color:#d52303">Cadastro de Produtos</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados</h3>

                <%--Categoria--%>
                <div class="form-group">
                    <asp:label id="categoriaLabel" runat="server" text="Categoria:"></asp:label>
                    <asp:DropDownList ID="categoriaDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <%--Descrição--%>
                <div class="form-group">
                    <asp:label id="descricaoLabel" runat="server" text="Descrição:"></asp:label>
                    <asp:textbox id="descricaoTextBox" cssclass="form-control" runat="server"></asp:textbox>
                </div>

                <%--Unidade--%>
                <div class="form-group">
                    <asp:label id="unidadeLabel" runat="server" text="Unidade:"></asp:label>
                    <asp:DropDownList ID="unidadeDropDownList" runat="server" CssClass="form-control"></asp:DropDownList>
                </div>

                <%--Preço--%>
                <div class="form-group">
                    <asp:label id="precoLabel" runat="server" text="Preço:"></asp:label>
                    <asp:textbox id="precoTextBox" cssclass="form-control" runat="server"></asp:textbox>
                    <asp:RequiredFieldValidator 
                        ID="precoRequiredFieldValidator" 
                        runat="server" 
                        CssClass="text-danger"
                        ControlToValidate="precoTextBox"
                        ErrorMessage="O Preço deve ser informado" 
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator 
                        ID="RangeValidator1" 
                        runat="server" 
                        CssClass="text-danger"
                        ErrorMessage="O Valor deve ser entre 1 e 10000 reais"
                        ControlToValidate="precoTextBox"
                        Display="Dynamic" MinimumValue="1" MaximumValue="10000" Type="Double"></asp:RangeValidator>


                </div>

                <%--Figura--%>
                <div class="form-group">
                    <asp:label id="figuraLabel" runat="server" text="Figura:"></asp:label>
                    <asp:FileUpload ID="figuraFileUpload" runat="server" CssClass="form-control"/>
                </div>

                <asp:button id="enviarButton" runat="server" Text="Incluir Produto" 
                    Cssclass="btn btn-primary" OnClick="enviarButton_Click" />

                <div>
                    <asp:label id="mensagemLabel" runat="server"></asp:label>
                </div>

            </div>
           <div class="col-md-7">
                <h3 class="text-center">Lista de Produtos</h3>
                <asp:Repeater ID="produtosRepeater" runat="server" OnItemDataBound="produtosRepeater_ItemDataBound">
                    <HeaderTemplate>
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <td>Id</td>
                                    <td>Descrição</td>
                                    <td>Preço</td>
                                    <td>Imagem</td>
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
                                <asp:Label runat="server" Text='<%# Eval("Descricao") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:Label runat="server" Text='<%# Eval("Preco") %>'></asp:Label>
                            </td>
                            <td>
                                <asp:HiddenField runat="server" ID="idHiddenField" Value='<%# Eval("Id") %>' />
                                <asp:Image ID="produtoImage" runat="server" Width="100" />
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
