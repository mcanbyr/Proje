<?php
// Kullanıcı adı ve şifre bilgilerini formdan alın
$username = $_POST['username'];
$password = $_POST['password'];

// Boş alan var mı kontrol et
if(empty($username) || empty($password)) {
    header("Location: login.html"); // Boş alan varsa login sayfasına geri yönlendir
    exit();
}

// Kullanıcı adı alanının mail adresi olup olmadığını kontrol et
if(!filter_var($username, FILTER_VALIDATE_EMAIL)) {
    header("Location: login.html"); // Geçersiz e-posta adresi varsa login sayfasına geri yönlendir
    exit();
}
echo "Giriş başarılı. Yönlendiriliyorsunuz...";
// Kullanıcı adı ve şifrenin doğrulama işlemi
$student_number = substr($username, 1); // Öğrenci numarasını al
$expected_password = "b" . $student_number; // Öğrenci numarasını şifreye ekle

// Kullanıcı adı ve şifrenin doğruluğunu kontrol et
if ($username == "$student_number@sakarya.edu.tr" && $password == $expected_password) {
    // Başarılı giriş durumunda hoşgeldiniz mesajı ile birlikte sayfaya yönlendir
    header("Location: login.html"); // 3 saniye sonra menu.html sayfasına yönlendir
    echo "Giriş başarılı. Yönlendiriliyorsunuz...";
    exit();
} else {
    echo "Giriş başarısız. Yönlendiriliyorsunuz...";
    // Hatalı giriş durumunda kullanıcıyı tekrar login sayfasına yönlendir
    header("Location: login.html");
    exit();
}
?>
