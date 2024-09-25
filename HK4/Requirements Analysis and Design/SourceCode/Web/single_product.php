<?php
require_once ('database/config.php');
require_once ('database/dbhelper.php');

// Lấy id từ trang index.php truyền sang rồi hiển thị nó
if (isset($_GET['id'])) {
    $id = $_GET['id'];
    $sql = 'select product.*, collections.name as collection_name from product, collections where product.id_sanpham = collections.id and product.id=' . $id;
    $product = executeSingleResult($sql);
    // Kiểm tra nếu ko có id sp đó thì trả về index.php
    if ($product == null) {
        header('Location: index.php');
        die();
    }
}
?>
<?php
include ("Layout/header.php");
?>
<main>
    <section class="contact-img-area">
        <div class="container">
            <div class="row">
                <div class="col-md-12 text-center">
                    <div class="con-text">
                        <h2 class="page-title">Single Product</h2>
                        <p><a href="index.php">Home</a> | Single Product</p>
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
    <div class="content-wrapper">
        <div class="container">
            <!-- END LAYOUT  -->
            <section class="main section-wrapper">
                <section class="oder-product">
                    <div class="title">
                        <section class="main-order">
                            <h1><?= $product['title'] ?></h1>
                            <div class="box">
                                <div class="left">
                                    <div class="main_image_container">
                                        <button class="prev" onclick="changeImage(-1)">&#10094;</button>
                                        <div class="main_image">
                                            <img id="mainThumbnail"
                                                src="<?= 'admin/product/' . $product['thumbnail'] ?>" alt="">
                                        </div>
                                        <button class="next" onclick="changeImage(1)">&#10095;</button>
                                    </div>
                                </div>
                                <div class="about">
                                    <p style="padding-top:105px;margin-left:10px; width:300px">
                                        <?= $product['content'] ?>
                                    </p>
                                    <p style="padding-top:20px;margin-left:10px; width:300px">Brand: <span
                                            style="font-weight: 600; color:#FF6600"><?= $product['collection_name'] ?></span>
                                    </p>
                                    <div class="number" style="padding-top:10px;margin-left:10px;">
                                        <span class="number-buy">Quantity</span>
                                        <input id="num" type="number" value="1" min="1" onchange="updatePrice()">
                                    </div>
                                    <p class="price" style="padding-top:70px;margin-left:10px;">Price: <span
                                            id="price"><?= number_format($product['price'], 0, ',', '.') ?></span><span>
                                            VNĐ</span><span class="gia none"><?= $product['price'] ?></span></p>
                                    <?php
                                    if (isset($_COOKIE['tendangnhap'])) {
                                        echo '<button class="add-cart" style="margin-left:10px;" onclick="addToCart(' . $id . ')"><i class="fas fa-cart-plus"></i><a href="/cart.php"></a> Add to shopping cart</button>
                            <p></p>
<button class="buy-now" style="margin-left:10px;" onclick="buyNow(' . $id . ')"><i class="fas fa-money-check"></i> Place order</button>';
                                    } else {
                                        echo '<div class="wc-proceed-to-checkout" style="text-align: center;">
                            <p class="return-to-shop">
                                <a class="button wc-backward" href="login.php">Logined to add to shopping cart</a>
                            </p>
                            </div>';
                                    }
                                    ?>
                                    <script>
                                        function updatePrice() {
                                            var price = document.getElementById('price').innerText; // giá tiền
                                            var num = document.querySelector('#num').value; // số lượng
                                            var gia1 = document.querySelector('.gia').innerText;
                                            var gia = price.match(/\d/g);
                                            gia = gia.join("");
                                            var tong = gia1 * num;
                                            document.getElementById('price').innerHTML = tong.toLocaleString();
                                        }

                                        let currentImageIndex = 0;
                                        const images = [
                                            '<?= 'admin/product/' . $product['thumbnail'] ?>',
                                            '<?= 'admin/product/' . $product['thumbnail_1'] ?>',
                                            '<?= 'admin/product/' . $product['thumbnail_2'] ?>',
                                            '<?= 'admin/product/' . $product['thumbnail_3'] ?>',
                                            '<?= 'admin/product/' . $product['thumbnail_4'] ?>',
                                            '<?= 'admin/product/' . $product['thumbnail_5'] ?>'
                                        ];

                                        function changeImage(direction) {
                                            const mainThumbnail = document.getElementById('mainThumbnail');
                                            mainThumbnail.style.opacity = 0;

                                            currentImageIndex += direction;

                                            if (currentImageIndex >= images.length) {
                                                currentImageIndex = 0;
                                            } else if (currentImageIndex < 0) {
                                                currentImageIndex = images.length - 1;
                                            }

                                            setTimeout(() => {
                                                mainThumbnail.src = images[currentImageIndex];
                                                mainThumbnail.style.opacity = 1;
                                            }, 500); // Delay to match the CSS transition duration
                                        }
                                    </script>
                                    <script type="text/javascript">
                                        function addToCart(id) {
                                            var num = document.querySelector('#num').value; // số lượng
                                            $.post('api/cookie.php', {
                                                'action': 'add',
                                                'id': id,
                                                'num': num
                                            }, function (data) {
                                                location.reload()
                                            })
                                        }

                                        function buyNow(id) {
                                            $.post('api/cookie.php', {
                                                'action': 'add',
                                                'id': id,
                                                'num': 1
                                            }, function (data) {
                                                location.assign("checkout_product.php");
                                            })
                                        }
                                    </script>

                                </div>
                                <div class="fb-comments" data-href="http://localhost/PROJECT/details.php"
                                    data-width="750" data-numposts="5"></div>
                            </div>
                        </section>
                    </div>
                </section>
                <section class="restaurants section-wrapper blur">
                    <div class="title">
                        <h1><span class="green" style="color: black;">The similar products</span></h1>
                    </div>
                    <div class="product-restaurants">
                        <div class="row">
                            <?php
                            if (isset($_GET['id'])) {
                                $id = $_GET['id'];
                                $sql = 'SELECT product.*, collections.name AS collection_name 
                                        FROM product 
                                        INNER JOIN collections ON product.id_sanpham = collections.id 
                                        WHERE product.id = ' . $id . ' LIMIT 1';
                                $product = executeSingleResult($sql);

                                if ($product == null) {
                                    header('Location: index.php');
                                    die();
                                }

                                $category_id = $product['id_category'];
                                $sql_related_products = 'SELECT * FROM product WHERE id_category = ' . $category_id . ' AND id != ' . $id;
                            }

                            $productList = executeResult($sql_related_products);
                            foreach ($productList as $item) {
                                echo '
                                    <div class="col">
                                        <a href="single_product.php?id=' . $item['id'] . '">
                                            <img class="thumbnail" src="admin/product/' . $item['thumbnail'] . '" alt="">
                                            <div class="title">
                                                <p>' . $item['title'] . '</p>
                                            </div>
                                            <div class="price">
                                            <span style="color: black;">' . number_format($item['price'], 0, ',', '.') . ' VNĐ</span>
                                            </div>
                                            
                                        </a>
                                    </div>  
                                ';
                            }
                            ?>
                        </div>
                    </div>
                </section>
            </section>
        </div>
    </div>
</main>
<style>
    .restaurants.section-wrapper.blur {
        background-color: rgba(255, 255, 255, 0.8);
        /* Slightly more opaque background */
        padding: 30px;
        /* Increase padding for more space inside */
        border: 2px solid #333;
        /* Thicker, darker border */
        border-radius: 15px;
        /* More rounded corners */
        box-shadow: 0 6px 12px rgba(0, 0, 0, 0.2);
        /* Slightly larger shadow for depth */
        margin: 20px 0;
        /* Margin at the top and bottom */
    }

    .main_image_container {
        position: relative;
        width: 3000px;
        max-width: 500px;
        margin: auto;
        text-align: center;
    }

    .main_image img {
        width: 100%;
        border-radius: 10px;
        transition: opacity 0.5s ease-in-out;
        /* Smooth transition for opacity */
    }

    .prev,
    .next {
        cursor: pointer;
        position: absolute;
        top: 50%;
        transform: translateY(-50%);
        width: 40px;
        /* Adjust the width of the buttons */
        height: 40px;
        /* Adjust the height of the buttons */
        background-color: rgba(0, 0, 0, 0.5);
        /* Semi-transparent background for buttons */
        color: white;
        font-size: 24px;
        border: none;
        border-radius: 50%;
        outline: none;
        transition: background-color 0.3s ease;
        /* Smooth transition for background color */
    }

    .prev {
        left: -50px;
        /* Adjust the distance from the left */
    }

    .next {
        right: -10px;
        /* Adjust the distance from the right */
    }

    .prev:hover,
    .next:hover {
        background-color: rgba(0, 0, 0, 0.8);
    }
</style>
<?php require_once ('Layout/footer.php'); ?>