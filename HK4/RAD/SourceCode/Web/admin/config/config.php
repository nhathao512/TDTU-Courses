<?php
$mysqli = new mysqli("localhost","root","","primemart");
$conn = mysqli_connect("localhost","root","","primemart");
mysqli_set_charset($conn, 'UTF8');
// Check connection
if ($mysqli -> connect_errno) {
  echo "Không kết nối được MYSQLi" . $mysqli -> connect_error;
  exit();
}

?>
