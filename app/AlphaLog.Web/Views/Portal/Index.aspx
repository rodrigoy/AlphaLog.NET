<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<AlphaLog.Core.Carga>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

    <h2>Simulador de Entrada de Cargas no Portal</h2>

    <table>
        <tr>
            <th>
                Id
            </th>
            <th>
                Pallet
            </th>
            <th>
                Produto
            </th>
            <th>
                Quantidade
            </th>
            <th>
                Peso Calculado
            </th>
            <th>
                Peso Real
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%= Html.Encode(item.Id) %>
            </td>
            <td>
                <%= Html.Encode(item.Pallet) %>
            </td>
            <td>
                <%= Html.Encode(item.Produto.Nome) %>
            </td>
            <td>
                <%= Html.Encode(item.Quantidade) %>
            </td>
            <td>
                <%= Html.Encode(item.PesoCalculado) %>
            </td>
            <td>
                TODO!!!
            </td>
        </tr>
    
    <% } %>

    </table>
    
    <hr />

    <p>
        <%= Html.ActionLink("Criar Carga", "Index", "Carga") %>
    </p>
    
    <% using (Html.BeginForm("Carga", "Portal")) { %>
           
            <fieldset>
            <legend>Simule a entrada de uma Carga</legend>
            <p>
                <label for="pallet">Pallet:</label>
                <%= Html.TextBox("pallet") %>
                <%= Html.ValidationMessage("Pallet") %>
            </p>
            <p>
                <label for="pesoReal">Peso Real (Kg):</label>
                <%= Html.TextBox("pesoReal") %>
                <%= Html.ValidationMessage("pesoReal") %>
            </p>
            <p>
                <input type="submit" value="Entrar Carga" />
            </p>
        </fieldset>

           
    <% } %>

    <p>
        <%= Html.ActionLink("Criar Carga", "Index", "Carga") %>
    </p>

</asp:Content>

