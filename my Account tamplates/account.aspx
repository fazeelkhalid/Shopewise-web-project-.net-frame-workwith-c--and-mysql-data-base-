<%@ Page Title="" Language="C#" MasterPageFile="~/UserMasterPage.Master" AutoEventWireup="true" CodeBehind="account.aspx.cs" Inherits="shopewise.account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <!-- START MAIN CONTENT -->
    <div class="main_content">
	    <!-- START SECTION SHOP -->
	    <div class="section">
		    <div class="container">
			    <div class="row">
				    <div class="col-lg-3 col-md-4">
					    <div class="dashboard_menu">
						    <ul class="nav nav-tabs flex-column" role="tablist">
						      <li class="nav-item">
							    <a class="nav-link active" id="dashboard-tab" data-toggle="tab" href="#dashboard" role="tab" aria-controls="dashboard" aria-selected="false"><i class="ti-layout-grid2"></i>Account details</a>
						      </li>
						      <li class="nav-item">
							    <a class="nav-link" id="account-detail-tab" data-toggle="tab" href="#account-detail" role="tab" aria-controls="account-detail" aria-selected="true"><i class="ti-id-badge"></i>Update account</a>
						      </li>
						      <li class="nav-item">
							    <a class="nav-link" href="login.html"><i class="ti-lock"></i>Logout</a>
						      </li>
						    </ul>
					    </div>
				    </div>
				    <div class="col-lg-9 col-md-8">
					    <div class="tab-content dashboard_content">
						    <div class="tab-pane fade active show" id="dashboard" role="tabpanel" aria-labelledby="dashboard-tab">
							    <div class="card">
								    <div class="card-header">
									    <h3>Account information</h3>
								    </div>
                                    <div class="row">
									    <div class="form-group col-md-6">
										    <label>User Name</label>
                                            <asp:Label  readonly="" ID="Label1" class="form-control" name="name" type="text" runat="server"></asp:Label>
										</div>
										
                                        <div class="form-group col-md-6">
										    <label>Email</label>
										    <asp:Label ID="Label2" readonly=""  class="form-control" name="name" type="text" runat="server"></asp:Label>
									    </div>

                                        <div class="form-group col-md-6">
										    <label>City</label>
                                            <asp:Label ID="Label3" readonly=""  class="form-control" name="name" type="text" runat="server"></asp:Label>
										</div>
										
                                        <div class="form-group col-md-6">
										    <label>Address</label>
                                            <asp:Label ID="Label4" readonly="" class="form-control" name="name" type="text" runat="server"></asp:Label>
										</div>

                                        <div class="form-group col-md-6">
										    <label>Phone number</label>
                                            <asp:Label ID="Label5" readonly="" class="form-control" name="name" type="text" runat="server"></asp:Label>
										</div>
                                    </div>
							    </div>
						    </div>
						    <div class="tab-pane fade" id="account-detail" role="tabpanel" aria-labelledby="account-detail-tab">
							    <div class="card">
								    <div class="card-header">
									    <h3>Update Account</h3>
								    </div>
								    <div class="card-body">
									    <form method="post" name="enq">
										    <div class="row">
											    <div class="form-group col-md-6">
												    <label>Change name</label>
                                                    <asp:TextBox ID="Text1" class="form-control" name="name" type="text" runat="server" MaxLength="35"></asp:TextBox>
											     </div>

                                                
											    <div class="form-group col-md-6">
												    <label>Change Phone Number</label>
                                                    <asp:TextBox ID="Text2" class="form-control" name="name" type="text" runat="server" minLength="11" MaxLength="11"></asp:TextBox>
											     </div>

                                                <div class="form-group col-md-6">
												    <label>Change City</label>
                                                    <asp:TextBox ID="Text3" class="form-control" name="name" type="text" runat="server" MaxLength="35"></asp:TextBox>
											     </div>

                                                <div class="form-group col-md-6">
												    <label>Change Address</label>
                                                    <asp:TextBox ID="Text4" class="form-control" name="name" type="text" runat="server" MaxLength="35"></asp:TextBox>
											     </div>

											    <div class="form-group col-md-6">
												    <label>Old Password</label>
                                                    <asp:TextBox ID="Text5" class="form-control" name="name" type="password" runat="server" MaxLength="35"></asp:TextBox>
                                                </div>

                                                <div class="form-group col-md-6">
												    <label>New Password</label>
                                                    <asp:TextBox ID="Text6" class="form-control" name="name" type="password" runat="server" MaxLength="35"></asp:TextBox>
                                                </div>

                                                
                                                <div class="form-group col-md-6">
												    <label>Reenter Password</label>
                                                    <asp:TextBox ID="Text7" class="form-control" name="name" type="password" runat="server" MaxLength="35"></asp:TextBox>
                                                </div>
                                                <div class="col-md-12">
                                                    <asp:label id="Label6" runat="server"></asp:label>
                                                    <asp:LinkButton type="submit" Text="Save" class="btn btn-fill-out" name="submit" value="Submit" runat="server" onclick="updateButton"></asp:LinkButton>
												    
											    </div>
										    </div>
									    </form>
								    </div>
							    </div>
						    </div>
					    </div>
				    </div>
			    </div>
		    </div>
	    </div>
	    <!-- END SECTION SHOP -->
    </div>
    <!-- END MAIN CONTENT -->





</asp:Content>
