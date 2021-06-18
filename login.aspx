<%@ Page Title="" Language="C#" MasterPageFile="~/loginSignupMaster.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="abdulrehman.login" %>
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
                                <h3>Login</h3>
                            </div>
                            <form method="post">
                                <div class="form-group">
                                    <asp:TextBox id="Text1" type="text"  class="form-control" name="email" placeholder="Your Email" runat="server" required="" ></asp:TextBox>
                                </div>
                                <div class="form-group">
                                    <asp:TextBox id="Text2" class="form-control" type="password" name="password" placeholder="Password" runat="server" required=""></asp:TextBox>
                                </div>
                                <div class="login_footer form-group">
                                    <div class="chek-form">
                                        <div class="custome-checkbox">
                                            <input class="form-check-input" type="checkbox" name="checkbox" id="exampleCheckbox1" value="">
                                            <label class="form-check-label" for="exampleCheckbox1"><span>Remember me</span></label>
                                        </div>
                                    </div>
                                    <a href="#">Forgot password?</a>
                                </div>
                                <div class="form-group">
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                    <asp:LinkButton type="submit" class="btn btn-fill-out btn-block" name="login" onclick="LoginButton" runat="server">Log in</asp:LinkButton>

                                </div>
                            </form>
                            <div class="different_login">
                                <span> or</span>
                            </div>
                            <ul class="btn-login list_none text-center">
                                <li><a href="#" class="btn btn-facebook"><i class="ion-social-facebook"></i>Facebook</a></li>
                                <li><a href="#" class="btn btn-google"><i class="ion-social-googleplus"></i>Google</a></li>
                            </ul>
                            <div class="form-note text-center">Don't Have an Account? <a href="signup.aspx">Sign up now</a></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- END LOGIN SECTION -->

</asp:Content>
