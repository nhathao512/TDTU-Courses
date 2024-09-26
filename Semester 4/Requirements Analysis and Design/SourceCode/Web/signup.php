<?php 
 include("Layout/header.php");
?>
<?php
    include('config.php');
	if(isset($_POST['dangky'])) {
		$fullname= $_POST['hovaten'];
        $tendangnhap  = $_POST['tendangnhap'];
		$email = $_POST['email'];
        $diachi = $_POST['diachi'];
        $matkhau = $_POST['matkhau'];
		$dienthoai = $_POST['dienthoai'];
		$sql_dangky = mysqli_query($mysqli, "INSERT INTO user(fullname, tendangnhap, email, diachi, matkhau, dienthoai, role) VALUES ('".$fullname."', '".$tendangnhap."', '".$email."', '".$diachi."', '".$matkhau."', '".$dienthoai."', 'user')");
		if($sql_dangky){
			if($fullname!="" && $tendangnhap!="" && $email!="" && $diachi!="" && $dienthoai!="" && $matkhau!=""){
                echo '<script>alert("Sign up success");
                window.location.href="login.php";
                </script>';
                
			} 
		
		}
	}
?>

<!-- pages-title-start -->
<section class="contact-img-area">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="con-text">
                    <h2 class="page-title">Sign Up</h2>
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
                            <h5 class="tb-title">Sign Up</h5>
                            <p>Sign up to be able to shop at PrimeMart </p>
                            
                            <form action="#" method="POST">
                                <p class="checkout-coupon top log a-an">
                                    <label class="l-contact">
                                        Fullname
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="hovaten" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                        Username
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="tendangnhap" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                        Email
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="email" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                    Phone
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="dienthoai" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                        Password
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="matkhau" required>
                                </p>
                                <p class="checkout-coupon top-down log a-an">
                                    <label class="l-contact">
                                        Address
                                        <em>*</em>
                                    </label>
                                    <input type="text" name="diachi" required>
                                </p>
                               
                                <p class="login-submit5">
                                    <input class="button-primary" type="submit" name="dangky" value="Sign Up">
                                </p>
                            </form>
                        </div>
                    </div>
                    
                </div>
            </div>
        </div>
		<!-- login  content section end -->
        <hr class="opacity-20">
<?php require_once('Layout/footer.php'); ?>