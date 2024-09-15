<?php
include 'database/dbhelper.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $id = $_POST["id"];

    $sql = "DELETE FROM order WHERE id=?";
    $conn = mysqli_connect(HOST, USERNAME, PASSWORD, DATABASE);
    $stmt = $conn->prepare($sql);
    $stmt->bind_param("i", $id);

    if ($stmt->execute()) {
        echo "Record deleted successfully";
    } else {
        echo "Error deleting record: " . $conn->error;
    }

    $stmt->close();
    $conn->close();

    header("Location: index.php");
    exit();
}
?>
