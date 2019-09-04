<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroClientes.aspx.cs" Inherits="DesenvolvimentoWeb.Vendas.Views.CadastroClientes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="container" style="margin-top:25px">
        <h2 class="text-center" style="color:#d52303">Cadastro de Clientes</h2>
        <div class="row">
            <div class="col-md-5">
                <h3 class="text-center">Forneça os dados</h3>

                <%--Documento--%>
                <div class="form-group">
                    <asp:label id="documentoLabel" runat="server" text="Documento:"></asp:label>
                    <asp:textbox id="documentoTextBox" cssclass="form-control" runat="server"></asp:textbox>
                    <asp:RequiredFieldValidator 
                        ID="documentoRequiredFieldValidator" 
                        runat="server" 
                        CssClass="text-danger"
                        ControlToValidate="documentoTextBox"
                        ErrorMessage="O Documento deve ser informado" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                </div>

                <%--Nome--%>
                <div class="form-group">
                    <asp:label id="nomeLabel" runat="server" text="Nome:"></asp:label>
                    <asp:textbox id="nomeTextBox" cssclass="form-control" runat="server"></asp:textbox>
                    <asp:RequiredFieldValidator 
                        ID="nomeRequiredFieldValidator" 
                        runat="server" 
                        CssClass="text-danger"
                        ControlToValidate="nomeTextBox"
                        ErrorMessage="O Nome deve ser informado" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                </div>

                <%--Telefone--%>
                <div class="form-group">
                    <asp:label id="telefoneLabel" runat="server" text="Telefone:"></asp:label>
                    <asp:textbox id="telefoneTextBox" cssclass="form-control" runat="server"></asp:textbox>
                    <asp:RequiredFieldValidator 
                        ID="telefoneRequiredFieldValidator" 
                        runat="server" 
                        CssClass="text-danger"
                        ControlToValidate="telefoneTextBox"
                        ErrorMessage="O Telefone deve ser informado" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                </div>

                <%--Email--%>
                <div class="form-group">
                    <asp:label id="emailLabel" runat="server" text="Email:"></asp:label>
                    <asp:textbox id="emailTextBox" cssclass="form-control" TextMode="Email" runat="server"></asp:textbox>
                    <asp:RequiredFieldValidator 
                        ID="emailRequiredFieldValidator" 
                        runat="server" 
                        CssClass="text-danger"
                        ControlToValidate="emailTextBox"
                        ErrorMessage="O Email deve ser informado" Display="Dynamic">
                    </asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator 
                        ID="RegularExpressionValidator1" 
                        runat="server" 
                        CssClass="text-danger"
                        ErrorMessage="Email Inválido" 
                        ControlToValidate="emailTextBox" 
                        Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                    </asp:RegularExpressionValidator>
                </div>

                <div class="form-group">
                    <asp:button id="enviarButton" runat="server" Text="Incluir Cliente" 
                    Cssclass="btn btn-primary" OnClick="enviarButton_Click" />
                </div>

                <div class="form-group">
                    <asp:label id="mensagemLabel" runat="server"></asp:label>
                </div>

            </div>
            <div class="col-md-7">
                <h3 class="text-center">Lista de Clientes</h3>
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
                    
                </asp:Repeater>
            </div>
        </div>

    </div>
</asp:Content>
