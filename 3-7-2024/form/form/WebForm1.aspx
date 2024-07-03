<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="form.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        tr{
            display:inline;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="mb-3">
                <label for="name" class="form-label">Your Name: </label>
                <asp:TextBox runat="server" type="text" class="form-control" ID="name" />
            </div>
            <br />
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email address: </label>
                <asp:TextBox runat="server" type="email" class="form-control" ID="exampleInputEmail1" />
            </div>
            <br />
            <div class="mb-3">
                <label for="id" class="form-label">ID: </label>
                <asp:TextBox runat="server" type="number" class="form-control" ID="id" />
            </div>
            <br />
            <div class="mb-3">
                <label for="gender" class="form-label">Gender:</label>
                &nbsp;<asp:RadioButton ID="RadioButton1" Text="Male" runat="server" />
                &nbsp;<asp:RadioButton ID="RadioButton2" Text="Female" runat="server" />
            </div>
            <br />
            <div class="mb-3 form-check">
                <label class="form-check-label">Check programming language: </label>
                <asp:CheckBoxList ID="CheckBoxList" runat="server" EnableTheming="False" >
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>C#</asp:ListItem>
                    <asp:ListItem>C++</asp:ListItem>
                </asp:CheckBoxList>
            </div>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
        </div>
        <hr />
        <hr />
        <br />
        <br />
        <div>
            <div class="mb-3">
                <label>Your Name: </label>
                <asp:TextBox runat="server" ID="inputName" ReadOnly />
            </div>
            <br />
            <div class="mb-3">
                <label>Email address: </label>
                <asp:TextBox runat="server" ID="InputEmail" ReadOnly />
            </div>
            <br />
            <div class="mb-3">
                <label>ID: </label>
                <asp:TextBox runat="server" ID="inputId" ReadOnly />
            </div>
            <br />
            <div class="mb-3">
                <label>Gender: </label>
                <asp:TextBox runat="server" ID="inputGender" ReadOnly />
            </div>
            <br />
            <div class="mb-3">
                <label>Programming Language: </label>
                <asp:TextBox runat="server" ID="inoutLanguage" ReadOnly />
            </div>
        </div>



    </form>
</body>
</html>
