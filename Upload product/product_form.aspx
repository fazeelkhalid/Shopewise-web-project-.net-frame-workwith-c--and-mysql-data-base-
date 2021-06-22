<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="product_form.aspx.cs" Inherits="shope_wise.product_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


<style>
    body {
      margin: 0;
      padding: 0;
      background-color: white;
      height: 100vh;
    }
    #login .container #login-row #login-column #login-box {
      margin-top: 50px;
      max-width: 700px;
      height: 900px;
      background-color: #EAEAEA;
    }
    #login .container #login-row #login-column #login-box #login-form {
      padding: 20px;
    }
    #login .container #login-row #login-column #login-box #login-form #register-link {
      margin-top: -85px;
    }


</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    
    
    <div id="login">
        <div class="container">
            <div id="login-row" class="row justify-content-center align-items-center">
                <div id="login-column" class="col-md-6" style=" background-color: #ff324d;">
                    <div id="login-box" class="col-md-12" style=" background-color: #ff324d;">
                        <form id="login-form" class="form" action="" method="post">
                            <h3 class="text-center text-info text-dark font-weight-bold">Upload product</h3>
                            <div class="form-group">
                                <label for="username" class="text-info text-dark">Name:</label><br/>
                                <asp:TextBox ID="Text1" type="text" name="username" class="form-control" runat="server" required="required" MaxLength="35"></asp:TextBox>
                            </div>
                            
                            <div class="form-group">
                                <label for="username" class="text-info text-dark">Price:</label><br/>
                                <asp:TextBox ID="Text2" type="text" name="username" class="form-control" runat="server" required="required" MaxLength="35"></asp:TextBox>
                            </div>

                            
                            <div class="form-group">
                                <label for="username" class="text-info text-dark">Seller Id:</label><br/>
                                <asp:TextBox ID="Text3" type="text" name="username" class="form-control" runat="server" required="required" MaxLength="35"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label for="username" class="text-info text-dark">Shop location:</label><br/>
                                <asp:TextBox ID="Text4" type="text" name="username" class="form-control" runat="server" required="required" MaxLength="35" ></asp:TextBox>
                            </div>

                            

                            <div class="form-group">
                                <label for="username" class="text-info text-dark">Description:</label><br/>
                                <asp:TextBox ID="Text5" type="text" name="username" class="form-control" runat="server" required="required" MaxLength="35"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <div class="row">
                                    <div class="col-md-6">
									    <div class="form-group"> 
										     <asp:FileUpload ID="productProfile" runat="server" accept="image/*" style="visibility:hidden;"></asp:FileUpload>
                                             <Button type="button" onclick="document.getElementById('ContentPlaceHolder1_productProfile').click();" class="btn btn-dark btn-block btn--radius">Product profile</Button>
									    </div>
								    </div>
                                    
                                    <div class="col-md-6">
									    <div class="form-group"> 
										     <asp:FileUpload ID="DemoFile" runat="server" accept="image/*" style="visibility:hidden;"></asp:FileUpload>
                                             <Button type="button" onclick="document.getElementById('ContentPlaceHolder1_DemoFile').click();" class="btn btn-dark  btn-block btn--radius">   Demo Image</Button>
									    </div>
								    </div>
								</div>
                                <br/>
                                <asp:Label id="warningLabel" class="text-center" runat="server"></asp:Label>
                                 <asp:button ID="Button1" OnClick="addProduct" class="btn btn-dark  btn-block btn--radius" runat="server" Text="Place order"/>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>




</asp:Content>
