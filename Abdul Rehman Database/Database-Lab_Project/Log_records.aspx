<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Log_records.aspx.cs" Inherits="shope_wise.Log_records" %>
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
                <div class="table-responsive ">
                    <table id="customers">
                        <tr>
                            <th>Log_no.</th>
                            <th>Account_ID</th>
                            <th>Name</th>
                            <th>Email</th>
                            <th>Location</th>
                            <th>Device</th>
                            <th>Time</th>
                        </tr>

                        <% foreach (var log in log_list) { %>
                        <tr>
                            <td><%=log.logs_Id%></td>
                            <td><%=log.logs_Account_Id%></td>
                            <td><%=log.logs_Account_Name%></td>
                            <td><%=log.logs_Account_email%></td>
                            <td><%=log.logs_Location%></td>
                            <td><%=log.logs_Device%></td>
                            <td><%=log.logs_Time%></td>
                        </tr>   
                    
					    <%} %>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
