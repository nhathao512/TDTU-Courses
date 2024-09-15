
<?php
	require_once('config.php');
    require_once('database/dbhelper.php');
	if(isset($_POST['submit'])){
		$tendangnhap = $_POST['tendangnhap'];
		$matkhau = $_POST['matkhau'];
        $sql = "SELECT * FROM user WHERE tendangnhap='".$tendangnhap."' AND matkhau='".$matkhau."' LIMIT 1";
		$row = mysqli_query($mysqli,$sql);
		$count = mysqli_num_rows($row);
		if($count > 0){
            $user = mysqli_fetch_assoc($row);
            if ($user['role'] == 'admin'){
                // $_SESSION['submit'] = $tendangnhap;
                echo '<script>alert("Hi Admin ^^");
                window.location.href="index.php";
                </script>';
                $tendangnhap = trim(strip_tags($_POST['tendangnhap']));
                $matkhau = trim(strip_tags($_POST['matkhau']));
                session_start();
                setcookie("tendangnhap", $tendangnhap, time() + 30 * 24 * 60 * 60, '/');
                setcookie("matkhau", $matkhau, time() + 30 * 24 * 60 * 60, '/');
                
            }
            else {
                // $_SESSION['submit'] = $tendangnhap;
                echo '<script>alert("Sign in success");
                    window.location.href="index.php";
                    </script>';
                session_start();
                setcookie("tendangnhap", $tendangnhap, time() + 30 * 24 * 60 * 60, '/');
                setcookie("matkhau", $matkhau, time() + 30 * 24 * 60 * 60, '/');
            }
			
		}
        else{
			echo '<script>alert("Account not exists or your password is wrong. Please re-enter information!");</script>';
			
		}
    }
?>

<?php 
 include("Layout/header.php");
?>
<!-- pages-title-start -->
<section class="contact-img-area">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="con-text">
                    <h2 class="page-title">Sign In</h2>
                    <p><a href="index.php">Home</a> | shop</p>
                </div>
            </div>
        </div>
    </div>
</section>
<style>
    .contact-img-area {
        background-image: url('/Web/images/banner_main1.jpg');
        /* Specify the path to your image */
        background-size: cover;
        background-position: center;
    }
</style>
<!-- login content section start -->
<div class="login-area">
            <div class="container">
                <div class="row">
                    <div class="col-md-12 col-xs-12">
                        <div class="tb-login-form ">
                            <h5 class="tb-title">Sign In</h5>
                            <p>Log in to your account to experience shopping at PrimeMart</p>
                            <!-- <div class="tb-social-login">
                                <a class="tb-facebook-login" href="#">
                                    <i class="fa fa-facebook"></i>
                                    Sign In With Facebook
                                </a>
                                <a class="tb-twitter-login res" href="#">
                                    <i class="fa fa-twitter"></i>
                                    Sign In With Twitter
                                </a>
                            </div> -->
                            <form action="#" method="POST">
                                <p class="checkout-coupon top log a-an">
                                    <label class="l-contact">
                                        Username
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="tendangnhap" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                        Password
                                        <em>*</em>
                                    </label>
                                    <input type="password" name="matkhau" required>
                                </p>
                                
                                
                                <p class="login-submit5">
                                    <input class="button-primary" type="submit" name="submit" value="Sign in">
                                </p>
                            </form>
                        </div>
                    </div>
                   
                </div>
            </div>
        </div>
		<!-- login  content section end -->
        <hr class="opacity-20">
        <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js"></script>
<?php require_once('Layout/footer.php'); ?>