<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Seller_List.aspx.cs" Inherits="shope_wise.Seller_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


<style>
    #customers {
      font-family: Arial, Helvetica, sans-serif;
      border-collapse: collapse;
      width: 100%;
    }
    #customers td, #customers th {
      border: 1px solid red;
      padding: 8px;
    }
    #customers tr:nth-child(even){background-color: white;}
    #customers tr:hover {background-color: #fff1f1;}
    #customers th {
      padding-top: 12px;
      padding-bottom: 12px;
      text-align: center;
      background-color: #ff324d;
      color: white;
    }
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="mt-5 ml-5 mr-5 mb-5">
        <div class="mt-5 ml-5 mr-5 mb-5">  
            <div class="mt-5 ml-5 mr-5 mb-5 " >
                <table id="customers">
                    <tr>
                        <th>product name</th>
                        <th>image </th>
                        <th>Country</th>

                    </tr>
                    <%-- for loop start from here --%>
                    <tr>
                        <td>Alfreds Futterkiste</td>
                        <td>Maria Anders</td>
                        <td>Germany</td>
                    </tr>   
                    <%--ending fpor loop --%>
                </table>
            </div>
        </div>
    </div>





</asp:Content>
