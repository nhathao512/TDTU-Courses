
<?php 
 include("Layout/header.php");
?>
<!-- pages-title-start -->
<section class="contact-img-area">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="con-text">
                    <h2 class="page-title">About Us</h2>
                    <p><a href="index.php">Home</a> | About Us</p>
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
<hr class="opacity-20">
    
    <h2 style="   text-align: center;
  padding:80px;
  font-size:25px;
  margin-top:-200px">About us</h2>
    <h5 style="    font-size:16.6px;
    color:rgb(0, 0, 0);
    text-align:center;
    padding-left:395px;
    padding-right:395px;
    letter-spacing:0.5px;
    line-height:40px;
    font-weight:500;
    padding-bottom:70px;">
       The PrimeMart Mini Supermarket is more than simply a grocery shop; it is a unique retail concept. PrimeMart Mini Supermarket assures that every item fulfills high quality and origin criteria through its network of chain stores that specialize in providing precisely picked products and fresh delicacies.</br></br>
        
       Since its beginning in early 2024, the PrimeMart Mini Supermarket model has evolved and expanded, opening new locations and improving product quality. The implementation of an online store management system improves consumer experience and convenience. PrimeMart Mini Supermarket has stores across the country, from the north to the south, making it easily accessible to everyone.</br></br>
        
       PrimeMart Mini Supermarket specializes on delivering a large range of hygienic and diversified food alternatives at reasonable costs, and it tries to meet the demands of all clients, from budget-conscious shoppers to those looking for quality products. Our courteous team is always ready to help, making each visit a pleasurable experience.</br></br>
        
       At PrimeMart Mini Supermarket, we focus customer pleasure while also striving to provide outstanding value. We want to reward our loyal customers and make their shopping experience even better by offering great promos and incentives.</br></br>
       PrimeMart Mini Supermarket is committed to sustainable development and lives by the motto "Top product quality". We promise to continually meet our clients' purchasing demands, guarantee product quality, provide timely delivery, and provide passionate support from our personnel. Our objective is to improve the quality of life for modern consumers by providing value-driven solutions.</h5>
    </body>
</html>
<hr class="opacity-20">
<?php require_once('Layout/footer.php'); ?>


<style>
    *{
    margin: 0;
    padding: 0;
}
i{/*  chỉnh icon ngôi sao */
    font-size:16px;
    text-align: center;
    padding-right: 10px;
}

h2{/*  chỉnh ô chứa chữ H2 */
text-align: center;
font-size:23px; 
padding-left:325px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
padding-right:343px;
padding-bottom:70px;
padding-top:100px;
}

h5{/*  chỉnh ô chứa chữ H5 */
    text-align: left;
    font-size:16px; 
    font-weight: 50;
    padding-left:340px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
    padding-right:343px;
    padding-top:10px;
    padding-bottom:18px;


    }

h6{/*  chỉnh ô chứa chữ H6 */
    text-align: left;
    font-size:17.5px; 
    font-weight: 600;
    text-decoration: underline;
    padding-left:355px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
    padding-right:343px;
    padding-bottom:10px;
    margin-top:-10px;/*  chỉnh khoảng cách so với chữ bên trên */
}
.image{/*  chỉnh ảnh trong mục body */
    align-items: center;
    text-align: center;
}



/*-----------------BÀI VIẾT LIÊN QUAN--------------------------*/


hr{/*  chỉnh thanh kẻ giữa bài viết liên quan với ảnh trên */
    margin-top:70px;/*  chỉnh khoảng cách so với chữ bên trên */padding-left:325px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
    margin-left:313px;
}
h1{/*  chỉnh ô chứa chữ H1 */
    text-align: left;
    font-size:16px; 
    font-weight: 550;
    padding-left:325px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
    padding-right:343px;
    padding-bottom:18px;
    margin-top:15px;/*  chỉnh khoảng cách so với chữ bên trên */
}
#list-new {/*  chỉnh ảnh bài viết liên quan */
    font-size:10px;/*size chữ sản phẩm*/
    display: flex;
    list-style: none;
    justify-content: space-around;
    padding-left:190px;/*  chỉnh khoảng cách 2 bên lề để song song với ảnh */
    padding-right:317px;
    margin-top:40px;

}

#list-new .item .name {/*  chỉnh chữ bài viết liên quan */
    text-align: center;
    color:rgb(10, 10, 10);
    font-weight: bold;
    margin-top:20px;/*chỉnh khoảng cách từ tên so với sản phẩm*/
}


#list-new .box-left{
    text-align: center;
    margin-top:435px;/*chỉnh lên xuống nút xem thêm */
    margin-left:-490px;/*chỉnh trái phải nút xem thêm*/
    
}
#list-new .box-left button:hover {/*màu sắc khi nhấp vô nút buttom mua ngay*/
    background:orange;
}
#list-new .box-left button {/*nút buttom mua ngay*/
    font-size:12px;/*chỉnh size chữ*/
    width: 80px;/*chỉnh size dài bóng đen*/
    height: 30px;/*chỉnh size rộng bóng đen*/
    background:#1d1a1a;
    border:none;
    outline:none;
    color:#fff;
    font-weight: bold;
    border-radius: 200px;
    transition:0.4s;/*chỉnh tốc độ chuyển màu*/
}

.gallery-display-area{
    overflow: hidden;
    height: 360px;
    width: 1080px;
    
}

.gallery-wrap{
    animation: slideShow 16s infinite;
    
}

.image{
    float: left;
    height: 360px;
    width: 1080px;
    display: flex;
    justify-content: center;
    align-items: center;

}

@keyframes slideShow{
    20%{
        margin-left: 0;        
    }
    30%{
        margin-left: -100%;        
    }
    40%{
        margin-left: -100%;        
    }
    50%{
        margin-left: -200%;        
    }
    60%{
        margin-left: -200%;        
    }
    70%{
        margin-left: -300%;        
    }
    80%{
        margin-left: -300%;        
    }
    90%{
        margin-left: -400%;        
    }
    100%{
        margin-left: -400%;        
    }
}
h5{/*  chỉnh  ô chứa chữ H4 */
    font-size:16.6px;
    color:rgb(0, 0, 0);
    text-align:center;
    padding-left:395px;
    padding-right:395px;
    letter-spacing:0.5px;
    line-height:40px;
    font-weight:500;
    padding-bottom:70px;
    
    
}
h2{/*  chỉnh ô chứa chữ H2 */
   text-align: center;
  padding:80px;
  font-size:25px;
  margin-top:-200px
}

@media screen and  (max-width: 870px)  and (min-width:300px){
    body {
   width: 1500px;
    }
}
</style>