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
    <style>
        table {
            border-collapse: collapse;
            width: 80%; /* Tabloyu küçültmek için genişliği ayarla */
            margin: 0 auto; /* Tabloyu ortalamak için */
        }
        th, td {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }
        th {
            background-color: #f2f2f2;
        }
        .btn-container {
            margin-top: 20px;
            text-align: center;
        }
        .btn {
            padding: 10px 20px;
            background-color: #4CAF50;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <h2>Gönderilen Bilgiler:</h2>
    <table>
        <tr>
            <th>Alan</th>
            <th>Bilgi</th>
        </tr>
        <tr>
            <td>İsim</td>
            <td><?php echo $name; ?></td>
        </tr>
        <tr>
            <td>E-posta</td>
            <td><?php echo $email; ?></td>
        </tr>
        <tr>
            <td>Telefon</td>
            <td><?php echo $phone; ?></td>
        </tr>
        <tr>
            <td>Cinsiyet</td>
            <td><?php echo $gender; ?></td>
        </tr>
        <tr>
            <td>Mesaj</td>
            <td><?php echo $message; ?></td>
        </tr>
    </table>
    <div class="btn-container">
        <a href="iletisim.html" class="btn">İletişim Sayfasına Dön</a>
    </div>
</body>
</html>
<?php
}
?>
