<%@ Page Title="Process" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Process.aspx.cs" Inherits="Process" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>   
    <div class="jumbotron">
        <h1>Work In Progress</h1>
        <p class="lead">Tests and examples</p>
    </div>
    
    <asp:Button ID="ButtonTestBatFile" runat="server" OnClick="ButtonTestBatFile_Click" Text="BritishGas Tests" />
    <asp:Button ID="ButtonTestBatFile2" runat="server" OnClick="ButtonTestBatFile2_Click" Text="BTUnitTests Tests" />

    <h3>Process exception message </h3>
    <br/>
    <asp:TextBox ID="TextBoxLog" runat="server" OnTextChanged="TextBoxLog_TextChanged"></asp:TextBox>
    <br/>
    <asp:Button ID="ProcessError" runat="server" OnClick="ProcessError_Click" Text="Process Exception Message" />
    <asp:Panel runat="server" CssClass="sxpnl" ID="pnlUserdata"></asp:Panel>

    <br/><br/><br/><br/><br/>
    <!--<asp:Button ID="BuildPlato" runat="server" OnClick="BuildPlato_Click" Text="Build Plato" />
    <br/>
    <iframe width='600px' height= '300px' src="Notes.txt"></iframe> 
    <br/>-->

</asp:Content>
