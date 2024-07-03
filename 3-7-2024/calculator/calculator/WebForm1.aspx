<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


</head>
<body>
    <form id="form1" runat="server">
        <div>

            <p>Result: 
                <asp:Literal ID="result" runat="server"></asp:Literal>
            </p>

            <div>
                <label>NUM1:&nbsp;</label>
                <asp:TextBox runat="server" type="number" ID="num1" />
            </div>

            <div>
                <label>NUM2:&nbsp;</label>
                <asp:TextBox runat="server" type="number" ID="num2" />
            </div>

            <div>


                <asp:Button ID="sum" runat="server" BackColor="Green" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large" Height="100px" Text="+" Width="350px" OnClick="sum_Click" />
                <asp:Button ID="subtract" runat="server" BackColor="Orange" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large" Height="100px" Text="-" Width="350px" OnClick="subtract_Click" />
                <asp:Button ID="multiply" runat="server" BackColor="Green" Font-Bold="True" Font-Names="Arial Black" Font-Size="XX-Large" Height="100px" Text="*" Width="350px" OnClick="multiply_Click" />


            </div>
        </div>
    </form>
</body>
</html>
