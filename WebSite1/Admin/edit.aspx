﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="WebSite1_Admin_Default"  ValidateRequest="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   <title>SA Times </title>
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/custom.css" />
    <link rel="stylesheet" href="css/sidebar.css" />
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/sidebarjs.js"></script>
    <link href='https://fonts.googleapis.com/css?family=Passion+One' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Oxygen' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="../ckeditor/ckeditor.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<body>
    <form id="form1" runat="server">
    <div id="top-nav" class="navbar navbar-inverse navbar-static-top box-shadow">
            <div class="container-fluid">
                <div class="navbar-header">


                    <asp:Label ID="Label1" runat="server" BackColor="White" ForeColor="#990000" Font-Size="Medium"></asp:Label>


                </div>
                <div class="navbar-collapse collapse">
                </div>
            </div>
            <!-- /container -->
        </div>
        <!-- /Header -->
        <!-- Main -->
        <div class="container-fluid">
            <div class="row">
                <div class="col-sm-3">
                    <!-- Left column -->
                    <img src="../img/bg-img/sa.png" />
                    <hr>


                    <ul class="nav nav-stacked">
                        <ul class="nav nav-stacked collapse" id="menu">
                        </ul>
                        </li>
            

               
				<li class="nav-header">


                    <a href="#" data-toggle="collapse" data-target="#menu3"><strong>SA times </strong><i class="glyphicon glyphicon-chevron-down pull-right"></i></a>
                    <ul class="nav nav-stacked collapse" id="menu3">
                        <li><a href="add.aspx"><i class="glyphicon glyphicon-circle"></i>Create New  </a></li>
                        <li><a href="view.aspx"><i class="glyphicon glyphicon-circle"></i>View </a></li>
                        <li><a href="edit.aspx"><i class="glyphicon glyphicon-circle"></i>Update </a></li>
                        <li><a href=""><i class="glyphicon glyphicon-circle"></i>

                        </a></li>
                    </ul>
                </li>

                        <hr>
                    </ul>



                </div>
                <!-- /col-3 -->
                <div class="col-sm-9 border-left">





                    <div class="row">
                        <!-- center left-->
                        <div class="col-md-6">
                        </div>
                        <!--/col-->
                        <div class="col-md-12">
                        </div>


                        <div class="form-group">

                        <div class="form-group">
                            <label for="exampleInputPassword1">Write post_id</label>
                            <asp:TextBox ID="Txtpostid" runat="server" CssClass="form-control" placeholder="id"></asp:TextBox>
                            <br />
                            <asp:Button ID="Btngetdata" runat="server" Text="GeT Data" OnClick="Button1_Click" />
                              <asp:Label ID="lblerror" runat="server" Text="."></asp:Label>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Cancel" />
                        </div>
                        
                        <div class="form-group">
                            <label for="exampleInputPassword1">Title</label>
                            <asp:TextBox ID="Txtupdatetitle" runat="server" CssClass="form-control" placeholder="title"></asp:TextBox>
                        </div>
                             <div class="form-group">
                            <label for="exampleInputPassword1">Disclaimer</label>
                            <asp:TextBox ID="Txtdisclaimer" runat="server" CssClass="form-control" placeholder="title"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <%-- <asp:TextBox ID="editor1" runat="server" TextMode="MultiLine"   class="editor1" name="editor1"></asp:TextBox>--%>
                            <textarea runat="server" cols="20" rows="2" class="editor1" name="editor1" id="editor1" ></textarea>
                        </div>
                           
                        

                                      
                            <asp:Button ID="Btnupdate" runat="server" Text="Update"  CssClass="btn btn-primary" OnClick="Btnupdate_Click"/>
                    </div>
                    <br>
                    <!--/col-span-6-->

                </div>
                <!--/row-->

                <hr>
                <hr>
            </div>
            <!--/col-span-9-->
        </div>
        </div>
        <!-- /Main -->


        <div class="modal" id="addWidgetModal">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-hidden="true">×</button>
                        <h4 class="modal-title">Add Widget</h4>
                    </div>
                    <div class="modal-body">
                        <p>Add a widget stuff here..</p>
                    </div>
                    <div class="modal-footer">
                        <a href="#" data-dismiss="modal" class="btn">Close</a>
                        <a href="#" class="btn btn-primary">Save changes</a>
                    </div>
                </div>
                <!-- /.modal-content -->
            </div>
            <!-- /.modal-dalog -->
        </div>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:sareAamConnectionString %>" SelectCommand="SELECT * FROM [post]"></asp:SqlDataSource>
    </form>
    <!-- /.modal -->
    <script src="js/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    </form>
       
</body>


<script>

    var editor = CKEDITOR.replace('editor1');  //editor

</script>

</html>
