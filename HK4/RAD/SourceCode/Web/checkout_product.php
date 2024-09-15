<?php
require_once ('database/config.php');
require_once ('database/dbhelper.php');
require_once ('utils/utility.php');
require_once ('api/checkout-form.php');
$cart = [];
if (isset($_COOKIE['cart'])) {
    $json = $_COOKIE['cart'];
    $cart = json_decode($json, true);
}
$idList = [];
foreach ($cart as $item) {
    $idList[] = $item['id'];
}
if (count($idList) > 0) {
    $idList = implode(',', $idList); // chuyeern
    //[2, 5, 6] => 2,5,6

    $sql = "select * from product where id in ($idList)";
    $cartList = executeResult($sql);
} else {
    $cartList = [];
}
?>
<?php
include ("Layout/header.php");
?>
<!-- pages-title-start -->
<section class="contact-img-area">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="con-text">
                    <h2 class="page-title">CHECK OUT </h2>
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

<body>
    <form action="" method="POST">
        <div class="checkout-area">
            <div class="container">
                <div class="container1">
                    <div class="row">
                        <div class="col-md-7 col-sm-12">
                            <div class="text">
                                <!-- Nav tabs -->
                                <!-- Tab panes -->
                                <div class="tab-content">
                                    <div role="tabpanel" class="tab-pane active" id="home">
                                        <div class="row">
                                            <form action="#">
                                                <div class="checkbox-form">
                                                    <div class="col-md-12">
                                                        <h3 class="checkbox9">CONTACT INFORMATION</h3>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <div class="di-na bs">
                                                            <label class="l-contact">
                                                                Full Name
                                                                <em>*</em>
                                                            </label>
                                                            <input class="form-control" type="text" required="" id="usr"
                                                                name="fullname" placeholder="Your fullname">
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="di-na bs">
                                                            <label class="l-contact">
                                                                Email Address
                                                                <em>*</em>
                                                            </label>
                                                            <input class="form-control" type="email" required=""
                                                                id="email" name="email"
                                                                placeholder="Your email address">
                                                        </div>
                                                    </div>
                                                    <div class="col-md-6">
                                                        <div class="di-na bs">
                                                            <label class="l-contact">
                                                                Phone
                                                                <em>*</em>
                                                            </label>
                                                            <input class="form-control" type="tel" required=""
                                                                id="phone_number" name="phone_number"
                                                                placeholder="Your phone number">
                                                        </div>
                                                    </div>
                                                    <div class="col-md-12">
                                                        <label class="l-contact">
                                                            Address
                                                            <em>*</em>
                                                        </label>
                                                        <div class="di-na bs">
                                                            <input class="form-control" type="text" required=""
                                                                id="address" name="address" placeholder="Your address">
                                                        </div>
                                                    </div>
                                                </div>
                                            </form>
                                        </div>

                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="di-na bs">
                                                    <label class="l-contact">
                                                        Note
                                                    </label>
                                                    <textarea style="color: black;" class="input-text "
                                                        placeholder="Please leave a message" name="note"
                                                        id="note"></textarea>
                                                </div>
                                            </div>
                                            <div class="col-md-12 text-center">
                                                <p class="checkout-coupon">
                                                    <a href=""><input type="submit" value="CONTINUE"></a>
                                                </p>
                                            </div>

                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-5 col-sm-12">
                            <div class="ro-checkout-summary">
                                <div class="ro-title">
                                    <h3 class="checkbox9">ORDER SUMMARY</h3>
                                </div>
                                <?php

                                $count = 0;
                                $total = 0;
                                foreach ($cartList as $item) {
                                    $num = 0;
                                    foreach ($cart as $value) {
                                        if ($value['id'] == $item['id']) {
                                            $num = $value['num'];
                                            break;
                                        }
                                    }
                                    $total += $num * $item['price'];
                                    echo '
                                            
                                            <div class="ro-body">
                                                <div class="ro-item">
                                                    <div class="ro-image">
                                                        <a href="#">
                                                            <img src="admin/product/' . $item['thumbnail'] . '" alt="">
                                                        </a>
                                                    </div>
                                                    <div>
                                                        <div class="tb-beg">
                                                            <a href="#">' . $item['title'] . '</a>
                                                        </div>
                                                    </div>
                                                    <div>
                                                        <div class="ro-price">
                                                            <span class="amount">' . $item['price'] . '</span>
                                                        </div>
                                                        <div class="ro-quantity">
<strong class="product-quantity"> x ' . $num . '</strong>
                                                        </div>
                                                        <div class="product-total">
                                                            <span style="" class="amount">' . number_format($num * $item['price'], 0, ',', '.') . '<span> VNĐ</span></span>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            
                                        
                                     ';
                                }
                                ?>
                                <div class="ro-footer">
                                    <div>
                                        <p>
                                            Subtotal
                                            <span>
                                                <span class="amount"><?= number_format($total, 0, ',', '.') ?>
                                                </span>
                                        </p>
                                        <div class="ro-divide"></div>
                                    </div>
                                    <div class="shipping">
                                        <p> Shipping </p>
                                        <div class="ro-shipping-method">
                                            <p>
                                                Free
                                            </p>
                                        </div>
                                        <div class="clearfix"></div>
                                        <div class="ro-divide"></div>
                                    </div>
                                    <div class="order-total">
                                        <p>
                                            Total
                                            <span>
                                                <strong>
                                                    <span class="amount"><?= number_format($total, 0, ',', '.') ?>
                                                    </span>
                                                </strong>
                                            </span>
                                        </p>
                                    </div>
                                    <div>
                                        <p>
                                            Total order
                                            <span>
                                                <strong>
                                                    <span class="amount"><?= number_format($total, 0, ',', '.') ?><span>
                                                            VNĐ</span></span>
                                                </strong>
                                            </span>
                                        </p>
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
<style>



</style>
<script src="https://code.jquery.com/jquery-3.6.4.min.js"></script>

<hr class="opacity-20">
<?php require_once ('Layout/footer.php'); ?>