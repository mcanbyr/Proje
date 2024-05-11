<?php

// Kullanıcı adı ve şifre bilgilerini formdan alın
$username = $_POST['username'];
$password = $_POST['password'];

// Kullanıcı adı ve şifrenin doğrulama işlemi
$first_letter = strtolower(substr($username, 0, 1)); // Kullanıcının ilk harfini al ve küçük harfe çevir
$student_number = substr($username, 1, strpos($username, "@") - 1); // Öğrenci numarasını al
$expected_password = $first_letter . $student_number; // Öğrenci numarasını şifreye ekle

// Başarılı giriş durumunda hoşgeldiniz mesajı ve öğrenci numarası göster
if ($username == "$first_letter$student_number@sakarya.edu.tr" && $password == $expected_password) {
    echo "<html>
            <head>
                <title>Giriş Başarılı</title>
                <style>
                    body {
                        font-family: Arial, sans-serif;
                        text-align: center;
                    }
                    .welcome-message {
                        margin-top: 100px;
                        font-size: 24px;
                        color: #4CAF50;
                    }
                    .student-number {
                        font-size: 18px;
                        color: #333;
                    }
                </style>
            </head>
            <body>
                <div class='welcome-message'>
                    Hoşgeldiniz!
                </div>
                <div class='student-number'>
                    Okul Numaranız: $expected_password
                </div>
            </body>
        </html>";
    // 3 saniye bekleyip sonra menu.html sayfasına yönlendir
    header("refresh:3;url=menu.html");
    exit();
} 
else {
    echo "Giriş başarısız. Yönlendiriliyorsunuz...";
    // Hatalı giriş durumunda kullanıcıyı tekrar login sayfasına yönlendir
    header("refresh:2;url=login.html");
    exit();
}
?>
