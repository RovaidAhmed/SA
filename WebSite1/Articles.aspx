<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Articles.aspx.cs" Inherits="Articles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>SA</title>
    <meta charset="UTF-8"/>
    <meta name="description" content=""/>
    <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
      <!-- Favicon -->
    <link rel="icon" href="img/core-img/favicon.ico"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <!-- jQuery library -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>

     <style>
      body{
          direction:rtl;
      }
      #social-links{
          height:45px !important;
      }
    </style>
<!-- Latest compiled JavaScript -->
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>

    <!-- Core Stylesheet -->
    <link rel="stylesheet" href="style.css"/>
</head>


<body>
    <form id="form1" runat="server">
     <!-- ##### Header Area Start ##### -->
    <header class="header-area">

        <!-- Top Header Area -->
        <div class="top-header-area" style=" ">
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <div class="top-header-content d-flex align-items-center justify-content-between" style=" ">
                            <!-- Logo -->
                            <div class="logo">
                                <a href="Home.aspx"><img src="img/bg-img/sa.png" alt=""></a>
                            </div>

                            <!-- Login Search Area -->
                            <div class="login-search-area d-flex align-items-center">
                                <!-- Login
                                <div class="login d-flex">
                                    <a href="#">Login</a>
                                    <a href="#">Register</a>
                                </div>
                                     -->
                                <!-- Search Form 
                                <div class="search-form">
                                    <form action="#" method="post">
                                        <input type="search" name="search" class="form-control" placeholder="Search">
                                        <button type="submit"><i class="fa fa-search" aria-hidden="true"></i></button>
                                    </form>
                                </div>
                                    -->
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Navbar Area -->
        <div class="newspaper-main-menu" id="stickyMenu">
            <div class="classy-nav-container breakpoint-off">
                <div class="container">
                    <!-- Menu -->
                    <nav class="classy-navbar justify-content-between" id="newspaperNav">

                        <!-- Logo -->
                        <div class="logo">
                            <a href="Home.aspx"><img src="img/bg-img/sa.png" alt=""></a>
                        </div>

                        <!-- Navbar Toggler -->
                        <div class="classy-navbar-toggler">
                            <span class="navbarToggler"><span></span><span></span><span></span></span>
                        </div>

                        <!-- Menu -->
                        <div class="classy-menu">

                            <!-- close btn -->
                            <div class="classycloseIcon">
                                <div class="cross-wrap"><span class="top"></span><span class="bottom"></span></div>
                            </div>

                            <!-- Nav Start -->
                            <div class="classynav">
                                <ul>
                                    <li class="active"><a href="Home.aspx">صفحۂ اول </a></li>                                  
                                  <li><a href="politics.aspx">سیاست</a></li>
                                    <li><a href="Amazing.aspx">حیرت انگیز</a></li>
                                    <li><a href="weird.aspx">عجیب و غریب</a></li>
                                    <li><a href="pakistan.aspx">پاکستان</a></li>
                                    <li><a href="world.aspx">دنیا سے</a></li>
                                    <li><a href="levlihoods.aspx">معیشت</a></li>
                                   <li><a href="#">مزید </a>
                                        <ul class="dropdown">
                                            <li><a href="Health.aspx">صحت</a></li>
                                            <li><a href="Articles.aspx">تمام آرٹیکلز</a></li>
                                            <li><a href="contact.aspx">رابطہ</a></li>
                                            <li><a href="about.aspx">ہمارے بارے میں</a></li>

                                                                                       
                                        </ul>
                                    </li>
                                </ul>
                            </div>
                            <!-- Nav End -->
                        </div>
                    </nav>
                </div>
            </div>
        </div>
    </header>
    <!-- ##### Header Area End ##### -->

    </form>
</body>
</html>
