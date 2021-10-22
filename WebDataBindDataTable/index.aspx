<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebDataBindDataTable.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DataBinding-DataSet</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            text-decoration: underline;
        }
        .auto-style3 {
            text-decoration: underline;
            height: 24px;
        }
        .auto-style4 {
            width: 250px;
        }
        .auto-style5 {
            height: 25px;
        }
        .auto-style6 {
            width: 100px;
        }
        .auto-style7 {
            height: 25px;
            width: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <h1 class="auto-style2">DATA BIND WITH DATASET &amp; DATATABLE  </h1>
            <p class ="auto-style3"> &nbsp;  </p>
        </div>

        <asp:Label ID="lblCourses" runat="server" Text="Select a Course"></asp:Label>
        <br />
        <br />

        <asp:ListBox ID="lstCourses" runat="server" AutoPostBack="true" OnSelectedIndexChanged="lstCourses_SelectedIndexChanged"></asp:ListBox>


        <table align="center" class="auto-style4">
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblNumber" runat="server" Text="Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblCourses1" runat="server" Text="Title"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblCourses2" runat="server" Text="Duration"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDuration" runat="server" ReadOnly="true" Width="20px"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td class="auto-style6">
                    <asp:Label ID="lblCourses3" runat="server" Text="Teacher"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTeacher" runat="server" ReadOnly="true"></asp:TextBox>
                </td>
            </tr>
        </table>

        <br />


        <asp:Label ID="lblCourses4" runat="server" Text="Select a Teacher "></asp:Label>

        <asp:DropDownList ID="cboTeachers" runat="server" AutoPostBack="true"  OnSelectedIndexChanged="cboTeachers_SelectedIndexChanged" ></asp:DropDownList>


        <asp:GridView ID="gridResults" runat="server" OnSelectedIndexChanged="gridResults_SelectedIndexChanged"></asp:GridView>


    </form>
</body>
</html>