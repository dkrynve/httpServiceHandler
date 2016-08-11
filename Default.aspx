<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>ARGPRINT01</h1>
    </div>
    <div>
        <h1>Restart Services - LatSAO Console</h1>
    </div>
    <div>
        <h2>Restart Print Service</h2>
    <asp:Button runat="server" ID="btnStart" Text="Start Service" 
            onclick="btnStart_Click" />
    <asp:Button runat="server" ID="btnStop" Text="Stop Service" 
            onclick="btnStop_Click" />
    </div>
    <div>
        <h2>Equitrac Core Accounting Server</h2>
        <asp:Button runat="server" ID="btnStartequi" Text="Start Service" 
            onclick="btnStart_Click1" />
        <asp:Button runat="server" ID="btnStopequi2" Text="Stop Service" 
            onclick="btnStop_Click1" />
        <br />
    </div>
    <div>
        <h2>Equitrac Device Control Engine&nbsp;&nbsp;&nbsp; </h2>
        <asp:Button runat="server" ID="btnStartequi0" Text="Start Service" 
            onclick="btnStart_Click2" />
        <asp:Button runat="server" ID="btnStopequi3" Text="Stop Service" 
            onclick="btnStop_Click2" />
    </div>
    <div>
        <h2>Equitrac Device Monitoring Engine</h2>
        <asp:Button runat="server" ID="btnStartequi1" Text="Start Service" 
            onclick="btnStart_Click3" />
        <asp:Button runat="server" ID="btnStopequi4" Text="Stop Service" 
            onclick="btnStop_Click3" />
        <br />
    </div>
    <div>
        <h2>Equitrac Document Routing Engine</h2>
        <asp:Button runat="server" ID="btnStartequi2" Text="Start Service" 
            onclick="btnStart_Click4" />
        <asp:Button runat="server" ID="btnStopequi5" Text="Stop Service" 
            onclick="btnStop_Click4" />
    </div>
    <div>
        <h2>Equitrac Scheduler</h2>
        <asp:Button runat="server" ID="btnStartequi3" Text="Start Service" 
            onclick="btnStart_Click5" />
        <asp:Button runat="server" ID="btnStopequi6" Text="Stop Service" 
            onclick="btnStop_Click5" />
    </div>
    <div>
        <h2>Equitrac Scan Processing Engine</h2>
        <asp:Button runat="server" ID="btnStartequi4" Text="Start Service" 
            onclick="btnStart_Click6" />
        <asp:Button runat="server" ID="btnStopequi7" Text="Stop Service" 
            onclick="btnStop_Click6" />
    </div>
    </form>
</body>
</html>
