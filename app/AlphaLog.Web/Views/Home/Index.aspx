<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" AutoEventWireup="true" 
    Inherits="System.Web.Mvc.ViewPage" %>
<%@ Import Namespace="AlphaLog.Web.Controllers" %>
<%@ Import Namespace="SharpArch.Web.Areas" %>

<asp:Content ID="indexContent" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
    <h2>AlphaLog Armazens Inteligentes</h2>
    
    <p>Seja bem-vindo a aplicação exemplo do treinamento TDD e Extreme Programming da Aspercom!</p>
    
    <%= Html.Image("~/Content/Images/home.jpg") %>

    
</asp:Content>
