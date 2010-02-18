<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" %>
<%@ Import Namespace="AlphaLog.Core" %>
<%@ Import Namespace="AlphaLog.Web.Controllers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h2>Criar uma Carga</h2>
        <% using (Html.BeginForm("Criar", "Carga")) {%>

        <fieldset>
            <legend>Entre com os dados</legend>
            <p>
                <label for="pallet">Pallet:</label>
                <%= Html.TextBox("pallet") %>
                <%= Html.ValidationMessage("Pallet") %>
            </p>
            <p>
                <label for="produto">Produto:</label>
                <%= Html.DropDownList("produtoId", ((SelectList)((Dictionary<string, SelectList>)Model)["produtos"])) %>
                <%= Html.ValidationMessage("Produto") %>
            </p>
             <p>
                <label for="quantidade">Quantidade:</label>
                <%= Html.DropDownList("quantidade", ((SelectList)((Dictionary<string, SelectList>)Model)["padraoQuant"])) %>
                <%= Html.ValidationMessage("Quantidade") %>
            </p>
            <p>
                <input type="submit" value="Criar Carga" />
            </p>
        </fieldset>

    <% } %>


    
</asp:Content>