<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Formdan gelen verileri al
    $name = $_POST['name'];
    $email = $_POST['email'];
    $phone = $_POST['phone'];
    $gender = $_POST['gender'];
    $message = $_POST['message'];
?>
<!DOCTYPE html>
<html lang="tr">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Gönderilen Bilgiler</title>
</head>
<body>
    <h2>Gönderilen Bilgiler:</h2>
    <p>İsim: <?php echo $name; ?></p>
    <p>E-posta: <?php echo $email; ?></p>
    <p>Telefon: <?php echo $phone; ?></p>
    <p>Cinsiyet: <?php echo $gender; ?></p>
    <p>Mesaj: <?php echo $message; ?></p>
</body>
</html>
<?php
}
?>
