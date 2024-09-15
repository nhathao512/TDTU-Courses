<?php require_once('database/config.php');
require_once('database/dbhelper.php');?>
<?php 
 include("Layout/header.php");
?>

<body>
<!-- <img src="images/shopping-1165437.jpg" alt="Overlay Image" id="overlay-image"> -->

<!--------------------BANNER --------------------------- -->
<sectionx class="slider-main-area">
            <div class="main-slider an-si">
                <div class="bend niceties preview-2 hm-ver-1">
                    <div id="ensign-nivoslider-2" class="slides">	
                        <img src="/Web/images/banner_main1.jpg" alt="" title="#slider-direction-3"  />
                        <img src="/Web/images/banner_main2.jpg" alt="" title="#slider-direction-1"  />
                    </div>
                    <!-- direction 1 -->
                    <div id="slider-direction-3" class="t-cn slider-direction Builder">
                        <div class="slide-all">
                            <!-- layer 1 -->
                            <div class="layer-1">
                                <h2 class="title5">Discover Your Shopping</h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-2">
                                <h2 class="title6">Paradise Online</h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-2">
                                <p class="title0">Amazingly Discounted Prices!</p>
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-3">
                                <a class="min1" href="shop.php?id_category=1">Shop Now</a>
                            </div>
                        </div>
                    </div>
                    <div id="slider-direction-1" class="t-cn slider-direction Builder">
                        <div class="slide-all slide2">
                            <!-- layer 1 -->
                            <div class="layer-1">
                                <h2 class="title5">Discover Your Shopping</h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-2">
                                <h2 class="title6">Paradise Online</h2>
                            </div>
                            <!-- layer 2 -->
                            <div class="layer-2">
                                <p class="title0">Amazingly Discounted Prices!</p>
                            </div>
                            <!-- layer 3 -->
                            <div class="layer-3">
                                <a class="min1" href="shop.php?id_category=3">Shop Now</a>
                            </div>
                        </div>
                    </div>
			    </div>
            </div>
        </sectionx>

        <?php
// Assume you have a function executeResult() to execute SQL queries and get results

// Fetch categories
$sql_categories = "SELECT * FROM Category";
$categories = executeResult($sql_categories);

// Loop through categories
foreach ($categories as $category) {
    $category_id = $category['id'];
    $category_name = $category['name'];

    // Fetch products for current category
    $sql_products = "SELECT * FROM product WHERE id_category = $category_id";
    $products = executeResult($sql_products);

    // Check if there are products in this category
    if ($products) {
        // Start section for current category
        echo '
        <!-- '.$category_name.' Section -->
        <section class="featured-products single-products section-padding-top" style="margin-bottom: 20px;">
            <div class="container">
                <div class="row">
                    <div class="col-xs-12">
                        <div class="section-title">
                            <h3>'.$category_name.'</h3>
                            <div class="section-icon">
                                <i class="fa fa-dot-circle-o" aria-hidden="true"></i>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="row tab-content">
                    <div class="tab-pane fade in active" id="all">
                        <div id="tab-carousel-1" class="re-owl-carousel owl-carousel product-slider owl-theme">';
                        
        // Loop through products
        foreach ($products as $product) {
            echo '
                            <div class="col-xs-12">
                                <div class="single-product">
                                    <div class="product-img">
                                        <div class="pro-type">
                                            
                                        </div>
                                        <a href="single_product.php?id='.$product['id'].'"> 
                                            <img class="thumbnail" src="admin/product/'.$product['thumbnail'].'" alt="'.$product['title'].'" />
                                            <img class="secondary-image" alt="'.$product['title'].'" src="admin/product/'.$product['thumbnail'].'">
                                        </a>
                                    </div>
                                    <div class="product-dsc">
                                        <h3><a href="#">'.$product['title'].'</a></h3>
                                        <div class="star-price">
                                            <span class="price-left">'.number_format($product['price'], 0, ',', '.').' VNĐ</span>
                                        </div>
                                    </div>
                                    <div class="actions-btn">
</div>
                                </div>
                            </div>';
        }
        
        // Close section for current category
        echo '
                        </div>
                    </div>
                </div>
            </div>
        </section>';
    }
}
?>

<section class="new-products single-products section-padding-top">
			<div class="container">
				<div class="row">
					<div class="col-xs-12">
						<div class="section-title">
							<h3>Most purchased product</h3>
							<div class="section-icon">
							    <i class="fa fa-dot-circle-o" aria-hidden="true"></i>
							</div>
						</div>
					</div>
				</div>
				<div class="row">
                    <div id="new-products" class="owl-carousel product-slider owl-theme">
                    <?php
                    $sql = 'SELECT * from product, order_details where order_details.product_id=product.id order by order_details.num DESC limit 6';
                    $productList = executeResult($sql);
                    $index = 1;
                    $used_products = array ();
                    foreach ($productList as $item) {
                        if (!in_array ($item ['thumbnail'], $used_products)) {  //check if the product id is not in the new array
                            array_push ($used_products, $item ['thumbnail']); //add the product id to the new array
                            echo '
                    <div class="col-xs-12">
                        <div class="single-product">
                            <div class="product-img">
                                <div class="pro-type">
                                </div>
                                <a href="single_product.php?id=' . $item['product_id'] . '">
                                    <img class="thumbnail" src="admin/product/' . $item['thumbnail'] . '" alt="' . $item['title'] . '" />
                                    <img class="secondary-image" alt="' . $item['title'] . '" src="admin/product/' . $item['thumbnail'] . '">
                                </a>
                            </div>
                            <div class="product-dsc">
                                <h3><a href="#">' . $item['title'] . '</a></h3>
                                <div class="star-price">
                                    <span class="price-left">' . number_format($item['price'], 0, ',', '.') . ' VNĐ</span>
                                </div>
                            </div>
                            <div class="actions-btn">
                               
                            </div>
                        </div>
                    </div>';
                            $index++;
                            if ($index > 6) {
                                break;
                            }
                            }
                    }
                    ?>
                    </div>
            </div>

			</div>

		</section>
<!--------------------BANNER SALE--------------------------- -->
    <div id="banner4"><!--banner4 banner sale off  -->
        <div class="box-left" >
            <a href="signup.php"><button>SIGN UP FOR FREE →</button><!--nút đăng ký --></a>
        </div>
    </div>
    
   </section>
   <script src="js/vendor/jquery-1.12.0.min.js"></script>
    <!-- bootstrap js -->
    <script src="js/bootstrap.min.js"></script>
    <!-- parallax js -->
    <script src="js/parallax.min.js"></script>
    <!-- owl.carousel js -->
    <script src="js/owl.carousel.min.js"></script>
    <!-- Img Zoom js -->
    <script src="js/img-zoom/jquery.simpleLens.min.js"></script>
    <!-- meanmenu js -->
    <script src="js/jquery.meanmenu.js"></script>
    <!-- jquery.countdown js -->
    <script src="js/jquery.countdown.min.js"></script>
    <!-- Nivo slider js
    ============================================ --> 		
    <script src="lib/js/jquery.nivo.slider.js" type="text/javascript"></script>
    <script src="lib/home.js" type="text/javascript"></script>
    <!-- jquery-ui js -->
    <script src="js/jquery-ui.min.js"></script>
    <!-- sticky js -->
    <script src="js/sticky.js"></script>
    <!-- plugins js -->
    <script src="js/plugins.js"></script>
    <!-- main js -->
    <script src="js/main.js"></script>
</body>

<style>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* ------------------------NEW ARRIVALS------------------------------*/
section.main {
    padding: 0 0;
    width: 100%;
    margin: 0px auto;
}
section.main a {
    text-decoration: none;
}
section.main section.recently {
    padding-bottom: 3rem;
    padding-left: 3rem;
    padding-right: 3rem;
}
section.main section.recently .link a {
    text-decoration: none;
    color: black;
    font-size: 20px;
}
section.main section.recently .title h1 {
    font-size: 35px;
    margin: 0px;
    padding: 30px;
    color: black;
    text-align: center;
}
section.main section.recently .product-recently {
    padding-top: 2rem;
}
section.main section.recently .product-recently .row {
    display: grid;
    grid-template-columns: auto auto auto auto;
    grid-column-gap: 30px;
    grid-row-gap: 30px;
}
section.main section.recently .product-recently .row .col img {
    width: 100%;
    border-radius: 10px;
}
section.main section.recently .product-recently .row .col img.thumbnail {
    border: 1px solid rgb(76, 78, 85);
    transition: 0.1s;
}
section.main section.recently .product-recently .row .col img.thumbnail:hover {
    box-shadow: 0px 0px 5px 0px grey;
}
section.main section.recently .product-recently .row .col .title p {
    font-size: 20px;
    font-weight: 600;
    padding: 0px;
    margin: 5px 0;
    color: black;
    font-family: "Encode Sans SC", sans-serif;
}
section.main section.recently .product-recently .row .col .price span {
    padding: 10px 0;
    color: #676767;
    font-size: 20px;
    font-weight: 600;
    color: rgba(207, 16, 16, 0.815);
font-family: "Bebas Neue", cursive;
}
section.main section.recently .product-recently .row .col .dish span {
    padding: 10px 0;
    color: #676767;
}
section.main section.recently .product-recently .row .col .more {
    display: flex;
    color: #676767;
    padding: 5px 0;
    font-size: 18px;
}
section.main section.recently .product-recently .row .col .more .star {
    display: flex;
    align-items: center;
    justify-content: center;
}
section.main section.recently .product-recently .row .col .more .star img {
    width: 25px;
    height: 25px;
}
section.main section.recently .product-recently .row .col .more .time {
    display: flex;
    padding: 0 10px;
}
section.main section.recently .product-recently .row .col .more .time img {
    width: 24px;
    height: 24px;
}
#wp-products {
    padding-top: 130px;
    padding-bottom: 78px;
    padding-left: 0px;
    padding-right: 0px;
}
#wp-products h2 {
    text-align: center;
    margin-bottom: 76px;
    font-size: 5x;
    color: black;
    margin-left: 40px;
}
#list-products {
    font-size: 17px;
    display: flex;
    list-style: none;
    justify-content: space-around;
    align-items: center;
    flex-wrap: wrap;
}
#list-products .item {
    width: 100%px;
    height: 0px;
    background: #fafafa;
    border-radius: 0px;
    margin-bottom: 460px;
}
#list-products .item .name {
    text-align: center;
    color: rgb(10, 10, 10);
    font-weight: bold;
    margin-top: 0px;
}
#list-products .item .price {
    text-align: center;
    color: #090909;
    font-weight: bold;
    margin-top: 0px;
}
.list-page {
    width: 50%;
    margin: 0px auto;
}
.list-page {
    display: flex;
    list-style: none;
    justify-content: center;
    align-items: center;
}
/* ------------------------WHAT'S HOT------------------------------*/
#new {
    padding-top: 50px;
    padding-bottom: 78px;
    padding-left: 0px;
    padding-right: 160px;
}
#new h2 {
    padding-left: 175px;
    text-align: center;
    margin-bottom: 50px;
    font-size: 5x;
    color: black;
}
#list-new {
    font-size: 13px;
    display: flex;
    list-style: none;
    justify-content: space-around;
    align-items: center;
    flex-wrap: wrap;
}
#list-new .item {
    width: 100%px;
    height: 0px;
    background: #fafafa;
    border-radius: 0px;
    margin-bottom: 460px;
}
#list-new .item .name {
    text-align: center;
    color: rgb(10, 10, 10);
    font-weight: bold;
    margin-top: 20px;
}
.list-page {
    width: 50%;
    margin: 0px auto;
}
.list-page {
    display: flex;
    list-style: none;
    justify-content: center;
    align-items: center;
}
/* ------------------------Banner 4------------------------------*/
#banner4 {
    width: 100%;
    background-image: url("/Web/images/banner saleoff2.jpg");
    background-size: cover;
    height: 113px;
    margin-top: -20px;
    margin-left: 0px;
    display: flex;
    padding: 0px 133px;
    position: relative;
}
#banner4 .box-left, #banner .box-right {
    width: 50%;
}
#banner4 .box-left button {
    font-size: 15px;
    width: 190px;
    height: 55px;
    margin-top: 27px;
    margin-left: 670px;
    background: #1d1a1a;
    border: none;
    outline: none;
    color: #fff;
    font-weight: bold;
    border-radius: 200px;
    transition: 0.4s;
}
#banner4 .box-left button:hover {
    background: orange;
}
@media screen and (max-width: 870px) and (min-width: 300px) {
    body {
        width: 1600px;
    }
}
#overlay-image {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    z-index: -1;
}
.single-product {
    position: relative;
}
.product-img {
    position: relative;
}
.product-img .thumbnail {
    width: 350px;
    height: auto
}

</style>


<?php require_once('Layout/footer.php'); ?>