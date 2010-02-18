<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" %>
<%@ Import Namespace="AlphaLog.Core" %>
<%@ Import Namespace="AlphaLog.Web.Controllers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h2>Situação do Armazem</h2>
    
    <div id="corredor">
        Corredor 1
        <div id="longarina">
        Longarina E
            <table class="enderecos">
                <% for (int andar = 4; andar > 0; andar--) { %>
                    <tr>
                    <% for (int ala = 1; ala <= 6; ala++) { %>
                        <td>
                            <%= ala + "." + andar %>
                            <% if (ala < 4 && andar - ala < 2) {%>
                                <div id="carga">
                                    <span class="pallet">12344</span><br />
                                    <span class="produto">Produto A</span><br/>
                                    <span class="peso">250Kg</span><br/>
                                </div>
                            <% } %>
                            
                        </td>
                    <% } %>
                    </tr>
                <% } %>
            </table>
        </div>
        <div id="transelevador">Transelevador 1</div>
        <div id="longarina">Longarina D
            <table class="enderecos">
                <% for (int andar = 1; andar <= 4; andar++) { %>
                    <tr>
                    <% for (int ala = 1; ala <= 6; ala++) { %>
                        <td>
                            <%= ala + "." + andar %>
                            <% if (ala < 4 && andar - ala < 2) {%>
                                <div id="carga">
                                    <span class="pallet">12344</span><br />
                                    <span class="produto">Produto A</span><br/>
                                    <span class="peso">250Kg</span><br/>
                                </div>
                            <% } %>
                        </td>
                    <% } %>
                    </tr>
                <% } %>
            </table>
        
        </div>
    </div>

</asp:Content>