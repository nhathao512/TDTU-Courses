<?php
include('config.php');
?>
<!--------------------FOOTER--------------------------- -->
<footer class="section-p1"><!--mục footer -->
    <div class="col">
        <h4>GROUP MEMBER</h4><!--Hệ thông cửa hàng -->
        <p><a href ="https://www.facebook.com/ntn10042004"> NGUYEN THANH NHAN </a></p>
        <p><a href ="https://www.facebook.com/nauu02">DANG THANH NHAN</a></p>
        <p><a href ="https://www.facebook.com/vo.nhathao.512">VO NHAT HAO </a></p>
        <p> <a href ="https://www.facebook.com/Huyy.es/">NGO DUC HUY</a></p>
    </div> 
    <div class="col">
        <h4>CONTACT INFORMATION</h4><!--Thông tin liên hệ -->
        <p>Email: <a href ="mailto:522h0038@student.tdtu.edu.vn?subject=subject text">522H0038@student.tdtu.edu.vn</a></p>
        <p>Contact CSKH: <a href="tel:0329545212">0329545212</a></p>
        <p>Address:<a href ="https://tdtu.edu.vn/"> 19 Nguyễn Hữu Thọ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh</a></p>
    </div>
    <div class="col">
        <h4>FOLLOW US ON SOCIAL MEDIA</h4><!--Follow us on social media-->
        <li><i class="fa fa-facebook"></i> Facebook</li>
        <li><i class="fa fa-instagram"></i> Instagram</li>
        <li><i class="fa fa-youtube"></i> Youtube</li>            
    </div>    
</footer>
<style>
/*----------------FOOTER--------------------*/

footer{
    background:rgb(0, 0, 0);
    display:flex;
    margin-top:0px;
    justify-content: space-around;
    margin-bottom:0px;
    padding-bottom: 20px;   /*chỉnh size background đen */
    padding-left:150px;
    
}
footer.col{
    
    display:flex;
    flex-direction:column;
    align-items: flex-start;
    margin-top: 100p;
}
footer h4{   /*chỉnh size chữ H4*/
    color:rgb(255, 255, 255);
    font-size: 16px;
    padding-bottom:30px;
    margin-top:40px;
    font-weight: bold;
}
footer p{  /*chỉnh size chữ P*/
    color:rgb(255, 255, 255);
    font-size: 13px;
    text-decoration:none;
    margin-bottom:15px;

 
}
footer li{ /*chỉnh icon fb,instagram,youtube*/
    color:#fff;
    margin-top: 3px;
    font-weight: bold;
    
   
}

</style>

<style>