<?php
include("config.php");
$username = $_POST['Login'];
$password = $_POST['Password'];
$score = $_POST['Score'];

//Проверка логин пароль
$query = "SELECT * FROM users WHERE username='$username' AND password='$password'";
$results = mysqli_query($connections, $query);
//Получение предыдущего рекорда
$scorequery = "SELECT Score FROM users WHERE username='$username'";
$scoreResult = mysqli_query($connections,$scorequery);
//Проверка на наличие строк в бд
if (mysqli_num_rows($results) == 1){
      echo("True ");
      echo(mysqli_fetch_assoc($scoreResult)['Score']);

}

    else {
      echo("False");

    }
//Установка Нового Рекорда
$updateQuery = "UPDATE users SET Score ='$score' WHERE username = '$username'";
$updateResult = mysqli_query($connections,$updateQuery);


?>