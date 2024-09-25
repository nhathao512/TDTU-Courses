<?php
session_start();
if (!isset($_COOKIE['tendangnhap'])) {
    header('Location: login.php');
    exit;
}

include('config.php');
require_once('database/dbhelper.php');

if (isset($_POST['submit'])) {
    $hovaten = $_POST['hovaten'];
    $email = $_POST['email'];
    $message_contact = $_POST['message_contact'];
    $created_at = $updated_at = date('Y-m-d H:s:i');

    if (empty($hovaten) || empty($email) || empty($message_contact)) {
        echo 'Vui lòng nhập đầy đủ thông tin!';
        exit;
    } elseif (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        echo 'Vui lòng nhập đúng định dạng email!';
        exit;
    }

    $userId = ""; // Initialize to an empty string
    if (isset($_COOKIE['tendangnhap'])) {
        $tendangnhap = $_COOKIE['tendangnhap'];
        $sql = "SELECT id_user FROM user WHERE tendangnhap = '$tendangnhap'";
        $user = executeResult($sql);
        if (count($user) > 0) {
            $userId = $user[0]['id_user'];
        }
    }

    if ($userId !== "") {
        $sql = "INSERT INTO contact(hoten, email, message_contact, id_user, created_at, updated_at) VALUES('$hovaten', '$email', '$message_contact', '$userId', '$created_at', '$updated_at')";
        execute($sql);
        echo '<script>alert("Gửi liên hệ thành công."); window.location.href = "index.php";</script>';
    }
}
?>

<?php include("Layout/header.php"); ?>

<!-- pages-title-start -->
<section class="contact-img-area" style="background-image: url('/Web/images/banner_main1.jpg'); background-size: cover; background-position: center;">
    <div class="container">
        <div class="row">
            <div class="col-md-12 text-center">
                <div class="con-text">
                    <h2 class="page-title">History Support Message</h2>
                    <p><a href="index.php">Home</a> | History Support Message</p>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- pages-title-end -->

<body>
    <hr class="opacity-20">
    <div class="container">
        <h2>History Support Message</h2>
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Fullname</th>
                    <th scope="col">Email</th>
                    <th scope="col">Message</th>
                    <th scope="col">Created Date</th>
                </tr>
            </thead>
            <tbody>
            <?php
                $limit = 5;
                $page = isset($_GET['page']) ? $_GET['page'] : 1;
                $start = ($page - 1) * $limit;
                $userId = ""; // Assume no user ID initially

                if (isset($_COOKIE['tendangnhap'])) {
                    $tendangnhap = $_COOKIE['tendangnhap'];
                    $sql = "SELECT id_user FROM user WHERE tendangnhap = '$tendangnhap'";
                    $user = executeResult($sql);
                    if (count($user) > 0) {
                        $userId = $user[0]['id_user'];
                    }
                }

                if ($userId !== "") {
                    $sql = "SELECT * FROM contact WHERE id_user = '$userId' ORDER BY created_at DESC LIMIT $start, $limit";
                    $contactList = executeResult($sql);
                    foreach ($contactList as $item) {
                        echo '<tr>
                            <td class="text-heading font-semibold">' . $item['hoten'] . '</td>
                            <td class="text-heading font-semibold">' . $item['email'] . '</td>
                            <td class="text-heading font-semibold">' . $item['message_contact'] . '</td>
                            <td class="text-heading font-semibold">' . $item['created_at'] . '</td>
                        </tr>';
                    }
                }
            ?>
            </tbody>
        </table>
    </div>

    <!-- Bootstrap JS and Popper.js -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.0.7/dist/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</body>

</html>

<?php include("Layout/footer.php"); ?>
