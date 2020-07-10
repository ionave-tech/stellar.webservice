<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gettoken.aspx.cs" Inherits="ROKUWEBAPI.gettoken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stellar Web API</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;<table>
                <tr>
                    <td>Username:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled" MaxLength="20"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Username is required." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled" MaxLength="20" TextMode="Password"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Password is required." ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
            </table>
            &nbsp;<asp:Button ID="Button1" runat="server" Text="Get Token" OnClick="Button1_Click" />

            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" ShowSummary="False" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
