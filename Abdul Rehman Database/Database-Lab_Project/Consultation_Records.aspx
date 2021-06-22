<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="Consultation_Records.aspx.cs" Inherits="shope_wise.Consultation_Records" %>
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
                            <th>Request no.</th>
                            <th>Consulter_Id</th>
                            <th>Consultant_Id</th>
                            <th>Product_Id</th>
                            <th>Status</th>
                            <th>Recommended_Product_Id</th>
                            <th>Consultant_rating</th>
                            <th>Consulter_rating</th>
                            <th>Date</th>
                        </tr>

                        <% foreach (var log in rec_list) { %>
                        <tr>
                            <td><%=log.Request_Id%></td>
                            <td><%=log.Consulter_Id%></td>
                            <td><%=log.Consultant_Id%></td>
                            <td><%=log.Product_Id%></td>
                            <td><%=log.Status%></td>
                            <td><%=log.Recommended_Product_Id%></td>
                            <td><%=log.Consultant_rating%></td>
                            <td><%=log.Consulter_rating%></td>
                            <td><%=log.Date%></td>
                        </tr>   
                    
					    <%} %>

                    </table>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
