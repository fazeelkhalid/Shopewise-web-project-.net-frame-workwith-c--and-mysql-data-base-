<%@ Page Title="" Language="C#" MasterPageFile="~/loginSignupMaster.Master" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="abdulrehman.signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- START LOGIN SECTION -->
    <div class="login_register_wrap section">
        <div class="container">
            <div class="row justify-content-center">
                <div class="col-xl-6 col-md-10">
                    <div class="login_wrap">
            		    <div class="padding_eight_all bg-white">
                            <div class="heading_s1">
                                <h3>Create an Account</h3>
                            </div>
                            <form method="post">
                                <div class="form-group">
                                    <asp:TextBox ID="Text1" type="text" required="required" class="form-control" name="name" placeholder="Enter Your Name" runat="server" MinLength="4" MaxLength="32"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="Text2" type="text" required="required" class="form-control" name="email" placeholder="Enter Your Email" runat="server" MinLength="4" MaxLength="32"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="Text3" type="text" class="form-control" name="PhoneNumber" placeholder="033xxxxxxx (Optional)" runat="server" minLength="13" MaxLength="13"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="Text4" class="form-control" required="required" type="password" name="password" placeholder="Password" runat="server" minLength="8" MaxLength="32"></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox ID="Text5" class="form-control" required="required" type="password" name="password" placeholder="Confirm Password" runat="server" minLength="8" MaxLength="32"></asp:TextBox>
                                </div>
                               
                                 <div class="form-group">
                                    <asp:TextBox  ID="Text6" class="form-control" required="required" name="password" placeholder="City" runat="server"  MinLength="8" MaxLength="32"></asp:TextBox>
                                </div>

                                 <div class="form-group">
                                    <asp:TextBox  ID="Text7" class="form-control" required="required" name="password" placeholder="Address" runat="server"  MinLength="8" MaxLength="80"></asp:TextBox>
                                </div>

                               
                                <div class="login_footer form-group">
                                    <div class="chek-form">
                                        <div class="custome-checkbox">
                                            <input class="form-check-input" id="Checkbox2" name="checkbox" type="checkbox" value="myvalue"/>
                                            <%--<input  type="checkbox" name="checkbox" id="exampleCheckbox2" value="myvalue"/>--%>
                                            <label class="form-check-label" for="Checkbox2"><span>I agree to terms &amp; Policy.</span></label>
                                        </div>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                    <asp:LinkButton type="submit" class="btn btn-fill-out btn-block" onclick="SignUpButton" name="register" runat="server">Register</asp:LinkButton>    
                                </div>
                            </form>
                            <div class="different_login">
                                <span> or</span>
                            </div>
                            <ul class="btn-login list_none text-center">
                                <li><a href="#" class="btn btn-facebook"><i class="ion-social-facebook"></i>Facebook</a></li>
                                <li><a href="#" class="btn btn-google"><i class="ion-social-googleplus"></i>Google</a></li>
                            </ul>
                            <div class="form-note text-center">Already have an account? <a href="login.aspx">Log in</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- END LOGIN SECTION -->

</asp:Content>
