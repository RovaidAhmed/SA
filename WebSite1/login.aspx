<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="true" CodeFile="login.aspx.cs"  Inherits="login"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>SA Times Login</title>
  <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet"/>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
  <link href="css/login.css" rel="stylesheet" />

 <style>
        body{
            background-color:cadetblue;
        }
    </style>
<!------ Include the above in your HEAD tag ---------->
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div class="container">
    	<div class="row">
			<div class="col-md-6 col-md-offset-3">
				<div class="panel panel-login">
					<div class="panel-heading">
						<div class="row">
							<div class="col-xs-6">
								<a href="#" class="active" id="login-form-link">Login</a>
							</div>
							
						    <asp:Label ID="lblerror" runat="server"></asp:Label>
							
						</div>
						<hr>
					</div>
					<div class="panel-body">
						<div class="row">
							<div class="col-lg-12">
								<form id="login-form" action=" " method="post" role="form" style="display: block;">
									<div class="form-group">
                                        <asp:TextBox ID="Txtusername" runat="server" CssClass="form-control" placeholder="username"></asp:TextBox>
									</div>
									<div class="form-group">
                                        <asp:TextBox ID="txtpassword" runat="server" CssClass="form-control" placeholder="password" TextMode="Password"></asp:TextBox>
									</div>
									
									<div class="form-group">
										<div class="row">
											<div class="col-sm-6 col-sm-offset-3">
                                          <asp:Button ID="Btnlogin" runat="server" Text="Login"  CssClass="btn btn-primary" Width="208px" OnClick="Btnlogin_Click1" />

											</div>
										</div>
									</div>
									<div class="form-group">
										<div class="row">
											<div class="col-lg-12">
												<div class="text-center">
												</div>
											</div>
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
    </form>
</body>
</html>
