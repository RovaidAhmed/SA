﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

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

    <!-- ##### Hero Area Start ##### -->
    <div class="hero-area">
        <div class="container">
            <div class="row align-items-center">
                <div class="col-12 col-lg-8">
                    <!-- Breaking News Widget -->
                    <div class="breaking-news-area d-flex align-items-center">
                        <div class="news-title">
                            <p style="font-weight:bold;font-size:18px;">تازہ ترین</p>
                        </div>
                        <div id="breakingNewsTicker" class="ticker">
                            <ul>
                                <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a></li>
                                <li><a href="#">Welcome to Colorlib Family.</a></li>
                                <li><a href="#">Nam eu metus sitsit amet, consec!</a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- Breaking News Widget -->
                    <div class="breaking-news-area d-flex align-items-center mt-15">
                        <div class="news-title title2">
                            <p style="font-weight:bold;font-size:18px;">بین اقوامی</p>
                        </div>
                        <div id="internationalTicker" class="ticker">
                            <ul>
                                <li><a href="#">Lorem ipsum dolor sit amet, consectetur adipiscing elit.</a></li>
                                <li><a href="https://www.facebook.com">Testing.</a></li>
                                <li><a href="#">Nam eu metus sitsit amet, consec!</a></li>
                            </ul>
                        </div>
                    </div>
                </div>

                <!-- Hero Add -->
                <div class="col-12 col-lg-4">
                    <div class="hero-add">
                    <%--    <a href="#"><img src="img/bg-img/hero-add.gif" alt=""></a>--%>
                        <amp-auto-ads type="adsense"
                      data-ad-client="ca-pub-2752878675643182">
                    </amp-auto-ads>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ##### Hero Area End ##### -->

    <!-- ##### Featured Post Area Start ##### -->
    <div class="featured-post-area">
        <div class="container">
            <div class="row">
                <div class="col-12 col-md-6 col-lg-8">
                    <div class="row">

                        <!-- Single Featured Post -->
                        <div class="col-12 col-lg-7">
                            <div class="single-blog-post featured-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/25.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="politics.aspx" class="post-catagory" style="margin-left:200px;">سیاست سے</a>
                                    <a href="#" class="post-title">
                                       <div style="margin-left:85px;"><h6>ھاشا ڈیم قومی معاملہ ہے</h6></div>
                                    </a>
                                    <div class="post-meta">
                                        <p class="post-author" style="text-align:right;"> <a href="#">حمزہ شہباز شریف</a></p>
                                        <p class="post-excerp">
                                            مسلم لیگ ن کے رہنما حمزہ شہباز شریف نے کہا ہے کہ دیامر بھاشا ڈیم قومی معاملہ ہے، کالا باغ کی طرح سیاست کی نذر نہیں ہونا چاہیے، پاکستان اور ڈیمز کے معاملے پر ہم سب اکٹھے ہیں۔

یہ بات انہوں نے اسلام آباد میں سپریم کورٹ کے واٹر سمپوزیم میں شرکت کے موقع پر میڈیا سے گفتگو کرتے ہوئے کہی، حمزہ شہباز شریف نے کہا کہ سابق وزیر اعظم نوازشریف نے دیامربھاشا ڈیم کی48ہزار ایکڑ زمین خریدی، بھاشاڈیم سے16ہزار میگاواٹ بجلی بنے گی، یہ ڈیم 12ارب ڈالر کا منصوبہ ہے۔
ان کا مزید کہنا تھا کہ کالا باغ ڈیم سیاست کی نذر ہوگیا، کالاباغ بن جاتا تو سستی بجلی پیدا ہوتی، دشمن ملک کہتا ہے کہ پاکستان کو پیاسا ماریں گے، دشمن جان لے کہ پاکستان اور ڈیمز کے معاملے پر ہم سب اکٹھے ہیں، سپریم کورٹ کا ڈیمز کی تعمیر کا اقدام خوش آئند ہے۔
دیامربھاشا اور مہمند ڈیم کیلئے فنڈ کی تعمیر ضروری ہے، پانی کا مسئلہ اہم ہے، آئندہ نسلوں کیلئے پانی کے ذخائر بہت ضروری ہیں۔ پانی ایک انمول تحفہ ہے اس کی قدر کرنی ہے، ہم سب نے مل کر پانی کو ضائع ہونے سے بچانا ہے اور ڈیم بنانا ہے۔
ان کا مزید کہنا تھا کہ میرے والد شہباز شریف کی کمر میں تکلیف تھی جس کی وجہ سے انہوں نے مجھے بھیجا، مجھے بطور قائد حزب اختلاف پنجاب اسمبلی شرکت کی دعوت بھی دی گئی تھی۔
ایک سوال کے جواب میں ان کا کہنا تھا کہ دیامر بھاشا ڈیم قومی معاملہ ہے، سیاست کی نذرنہیں ہونا چاہیے، ن لیگ کے دور میں ملک سے اندھیرے دور ہوئے، نواز شریف نے اپنے دور میں ہزاروں ایکڑ زمین ڈیم کی تعمیر کیلئے خریدی۔
 .
                                        </p>
                                        <!-- Post Like & Post Comment -->
                                        <%--<div class="d-flex align-items-center">
                                            <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                            <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                        </div>--%>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="col-12 col-lg-5">
                            <!-- Single Featured Post -->
                            <div class="single-blog-post featured-post-2">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/amaz.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory"> </a>
                                    <div class="post-meta">
                                        <a href="#" class="post-title">
                                            <div style="margin-left:50px;"><h6>بھارت کی کشمیر میں جارہیت جاری</h6></div>
                                        </a>
                                        <%--<!-- Post Like & Post Comment -->
                                        <div class="d-flex align-items-center">
                                            <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                            <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                        </div>--%>
                                    </div>
                                </div>
                            </div>

                            <!-- Single Featured Post -->
                            <div class="single-blog-post featured-post-2">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/33.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory"> </a>
                                    <div class="post-meta">
                                        <a href="#" class="post-title">
                                           <div><h6>بیرون ملک جائیدادیں رکھنے والوں پر مقدمہ نہیں کرسکتے</h6></div>
                                        </a>
                                        <!-- Post Like & Post Comment -->
                                        <%--<div class="d-flex align-items-center">
                                            <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                            <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                        </div>--%>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-6 col-lg-4">
                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/38.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="politics.aspx" class="post-catagory">سیاست</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>سیاستدانوں میں اکثر مجرم ہیں</h6>
                                </a>
                                <%--<p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/39.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="Amazing.aspx" class="post-catagory"> حیرت انگیز</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>آخر میں کرکٹ دو قوموں کو آپس میں جوڑ دیتی ہے</h6>
                                </a>
<%--                                <p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/40.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="weird.aspx" class="post-catagory">عجیب و غریب</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>بہو نے سسرالیوں کو کھانے میں کیا ملا کر دیا.</h6>
                                </a>
<%--                                <p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/41.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="pakistan.aspx" class="post-catagory">پاکستان</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>پاکستانی گلوکار فخرعالم کوروسی ایئرپورٹ پر نظربندکردیاگیا</h6>
                                </a>
<%--                                <p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/42.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="world.aspx" class="post-catagory">دنیا سے</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>نجی ایئرلائن کا مسافر طیارہ سمندر میں گر کر تباہ</h6>
                                </a>
<%--                                <p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Featured Post -->
                    <div class="single-blog-post small-featured-post d-flex">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/43.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="levlihoods.aspx" class="post-catagory">معیشت</a>
                            <div class="post-meta">
                                <a href="#" class="post-title">
                                    <h6>واٹس ایپ نے دو اہم فیچرز پر کام شروع کردیا</h6>
                                </a>
<%--                                <p class="post-date"><span>7:00 AM</span> | <span>April 14</span></p>--%>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ##### Featured Post Area End ##### -->

    <!-- ##### Popular News Area Start ##### -->
    <div class="popular-news-area section-padding-80-50">
        <div class="container">
            <div class="row">
                <div class="col-12 col-lg-8">
                    <div class="section-heading">
                        <h6>حیرت انگیز</h6>
                    </div>

                    <div class="row">

                        <!-- Single Post -->
                        <div class="col-12 col-md-6">
                            <div class="single-blog-post style-3">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/34.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory" style="margin-left:50px;">بین الاقوامی بینک کا معمولی سا کیشیر</a>
                                    <a href="#" class="post-title">
                                        <h6>ہ نوجوان لندن کے ایک بین الاقوامی بینک میں معمولی سا کیشیر تھا‘* *اس نے بینک کے ساتھ ایک ایسا فراڈ کیا جس کی وجہ سے وہ بیسویں صدی کا سب سے بڑا فراڈیا ثابت ہوا‘**وہ کمپیوٹر کی مدد سے بینک کے لاکھوں کلائنٹس کے اکاؤنٹس سے ایک‘ ایک پینی نکالتا تھا</h6>
                                    </a>
                                    <%--<div class="post-meta d-flex align-items-center">
                                        <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                        <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-md-6">
                            <div class="single-blog-post style-3">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/35.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory"> </a>
                                    <a href="#" class="post-title">
                                        <h6>ماحولیاتی اور سمندری آلودگی کی بڑی وجہ، شاپنگ بیگز</h6>
                                    </a>
                                   <%-- <div class="post-meta d-flex align-items-center">
                                        <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                        <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-md-6">
                            <div class="single-blog-post style-3">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/36.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory"> </a>
                                    <a href="#" class="post-title">
                                        <h6>اجلاس کے دوران زلزلہ: وزیراعظم درخواست کے باوجود دفتر سے باہر نہ نکلے</h6>
                                    </a>
                                   <%-- <div class="post-meta d-flex align-items-center">
                                        <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                        <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-md-6">
                            <div class="single-blog-post style-3">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/37.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-catagory"> </a>
                                    <a href="#" class="post-title">
                                        <h6>کینیڈا میں بھنگ کی خریدوفروخت اور استعمال کو قانونی قرار دے دیا گیا</h6>
                                    </a>
                                    <%--<div class="post-meta d-flex align-items-center">
                                        <a href="#" class="post-like"><img src="img/core-img/like.png" alt=""> <span>392</span></a>
                                        <a href="#" class="post-comment"><img src="img/core-img/chat.png" alt=""> <span>10</span></a>
                                    </div>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="col-12 col-lg-4">
                    <div class="section-heading">
                        <h6>فیس بک کے صفحے کی معلومات</h6>
                    </div>
                    <!--embed facebook plugin-->

                    <div class="fb-page" data-href="https://www.facebook.com/SareAam" data-tabs="timeline" data-small-header="false" data-adapt-container-width="true" data-hide-cover="false" data-show-facepile="true">
                        <blockquote cite="https://www.facebook.com/SareAam" class="fb-xfbml-parse-ignore"><a href="https://www.facebook.com/SareAam">SareAam Times</a></blockquote>
                    </div>

                    <div id="fb-root"></div>
                    <script>
                        (function (d, s, id) {
                           var js, fjs = d.getElementsByTagName(s)[0];
                                if (d.getElementById(id)) return;
                                  js = d.createElement(s); js.id = id;
                               js.src = 'https://connect.facebook.net/en_US/sdk.js#xfbml=1&version=v3.2';
                                   fjs.parentNode.insertBefore(js, fjs);
                        }(document, 'script', 'facebook-jssdk'));

                    </script>

                      <!--embed facebook plugin-->

                   
                   
                </div>
            </div>
        </div>
    </div>
    <!-- ##### Popular News Area End ##### -->

    <!-- ##### Video Post Area Start ##### -->
    <div class="video-post-area bg-img bg-overlay" style="background-image: url(img/bg-img/bg1.jpg);">
        <div class="container">
            <div class="row justify-content-center">
                <!-- Single Video Post -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single-video-post">
                        <img src="img/bg-img/vid.jpg" alt="">
                        <!-- Video Button -->
                       <iframe frameborder="0" width="480" height="270" src="https://www.dailymotion.com/embed/video/x6ehz1m" allowfullscreen allow="autoplay"></iframe>
                    </div>
                </div>

                <!-- Single Video Post -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single-video-post">
                        <img src="img/bg-img/video.jpg" alt="">
                        <!-- Video Button -->


                        <iframe frameborder="0" height="250"
                            src="//www.dailymotion.com/embed/video/x6dd6pg"
                            allowfullscreen allow="autoplay"></iframe>
                    </div>

                </div>

                <!-- Single Video Post -->
                <div class="col-12 col-sm-6 col-md-4">
                    <div class="single-video-post">
                        <img src="img/bg-img/video3.jpg" alt="">
                        <!-- Video Button -->
                        <div class="videobtn">
                            <a href="https://www.youtube.com/watch?v=5BQr-j3BBzU" class="videoPlayer"><i class="fa fa-play" aria-hidden="true"></i></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ##### Video Post Area End ##### -->

    <!-- ##### Editorial Post Area Start ##### -->
    <div class="editors-pick-post-area section-padding-80-50">
        <div class="container">
            <div class="row">
                <!-- Editors Pick -->
                <div class="col-12 col-md-7 col-lg-9">
                    <div class="section-heading">
                        <h6>Editor’s Pick</h6>
                    </div>

                    <div class="row">

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/1.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/2.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/3.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/4.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/5.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <!-- Single Post -->
                        <div class="col-12 col-lg-4">
                            <div class="single-blog-post">
                                <div class="post-thumb">
                                    <a href="#"><img src="img/bg-img/6.jpg" alt=""></a>
                                </div>
                                <div class="post-data">
                                    <a href="#" class="post-title">
                                        <h6>Orci varius natoque penatibus et magnis dis parturient montes.</h6>
                                    </a>
                                    <div class="post-meta">
                                        <div class="post-date"><a href="#">February 11, 2018</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <!-- World News -->
                <div class="col-12 col-md-5 col-lg-3">
                    <div class="section-heading">
                        <h6>دنیا</h6>
                    </div>

                    <!-- Single Post -->
                    <div class="single-blog-post style-2">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/44.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="world.aspx" class="post-title">
                                <h6>یہودی عبادت گاہ پر حملہ</h6>
                            </a>
                            <div class="post-meta">
<%--                                <div class="post-date"><a href="#">February 11, 2018</a></div>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Post -->
                    <div class="single-blog-post style-2">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/45.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="world.aspx" class="post-title">
                                <h6>ایک سزا ہے اور ایک قیمت ہے جو ادا کرنی ہو گی</h6>
                            </a>
                            <div class="post-meta">
                            </div>
                        </div>
                    </div>

                    <!-- Single Post -->
                    <div class="single-blog-post style-2">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/46.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="world.aspx" class="post-title">
                                <h6>ہم روس کوایٹمی معاہدے کی خلاف ورزی نہیں کرنے دیں گے</h6>
                            </a>
                            <div class="post-meta">
                               <%-- <div class="post-date"><a href="#">February 11, 2018</a></div>--%>
                            </div>
                        </div>
                    </div>

                    <!-- Single Post -->
                    <div class="single-blog-post style-2">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/47.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="#" class="post-title">
                                <h6>پولیس چیف کی ہلاکت کے بعد پولنگ ملتوی</h6>
                            </a>
                            <div class="post-meta">
                           
                            </div>
                        </div>
                    </div>

                    <!-- Single Post -->
                    <div class="single-blog-post style-2">
                        <div class="post-thumb">
                            <a href="#"><img src="img/bg-img/48.jpg" alt=""></a>
                        </div>
                        <div class="post-data">
                            <a href="#" class="post-title">
                                <h6>فٹبال ایسوسی ایشن اور شاہد خان کے درمیان 900 ملین پاؤنڈ پر معاملات طے پاگئے۔</h6>
                            </a>
                            <div class="post-meta">
                              
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
    <!-- ##### Editorial Post Area End ##### -->

    <!-- ##### Footer Add Area Start ##### -->
    <div class="footer-add-area">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="footer-add">
                        <%--<a href="#"><img src="img/bg-img/footer-add.gif" alt=""></a>--%>
                        <amp-auto-ads type="adsense"
                            data-ad-client="ca-pub-2752878675643182">
                          </amp-auto-ads>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- ##### Footer Add Area End ##### -->

    <!-- ##### Footer Area Start ##### -->
    <footer class="footer-area">

        <!-- Main Footer Area -->
        <div class="main-footer-area">
            <div class="container">
                <div class="row">

                    <!-- Footer Widget Area -->
                    <div class="col-12 col-sm-6 col-lg-4">
                        <div class="footer-widget-area mt-80">
                            <!-- Footer Logo -->
                            <div class="footer-logo">
                                <a href="Home.aspx"><img src="img/bg-img/sa.png" alt=""></a>
                            </div>
                            <!-- List -->
                            <ul class="list">
                                <li><a href="mailto:contact@youremail.com">sareaamofficial@gmail.com</a></li>
                                <li><a href=" "> 02137180802</a></li>
                                <li><a href="http://satimes.com.pk">satimes.com.pk</a></li>
                            </ul>
                        </div>
                    </div>

               

             
                    <!-- Footer Widget Area -->
                    <div class="col-12 col-sm-4 col-lg-2">
                        <div class="footer-widget-area mt-80">
                            <!-- Title -->
                            <h4 class="widget-title"> </h4>
                            <!-- List -->
                            <ul class="list" >
                              
                         <img src="img/bg-img/fb.png" alt=" " id="social-links"/>   
                         <img src="img/bg-img/insta.png" alt=" " id="social-links"/> 
                          <img src="img/bg-img/twitter.png" alt=" " id="social-links"/> 



                                
                                
                            </ul>
                        </div>
                    </div>

                   
                </div>
            </div>
        </div>

        <!-- Bottom Footer Area -->
        <div class="bottom-footer-area">
            <div class="container h-100">
                <div class="row h-100 align-items-center">
                    <div class="col-12">
                        <!-- Copywrite -->
                        <p><!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->

                    </div>
                </div>
            </div>
        </div>
    </footer>
    <!-- ##### Footer Area Start ##### -->
  <!-- ##### All Javascript Files ##### -->
    <!-- jQuery-2.2.4 js -->
    <script src="js/jquery/jquery-2.2.4.min.js"></script>
    <!-- Popper js -->
    <script src="js/bootstrap/popper.min.js"></script>
    <!-- Bootstrap js -->
    <script src="js/bootstrap/bootstrap.min.js"></script>
    <!-- All Plugins js -->
    <script src="js/plugins/plugins.js"></script>
    <!-- Active js -->
    <script src="js/active.js"></script>

          <!-- adds -->
        <script async custom-element="amp-auto-ads"
        src="https://cdn.ampproject.org/v0/amp-auto-ads-0.1.js">
</script>
    </form>
</body>
</html>
