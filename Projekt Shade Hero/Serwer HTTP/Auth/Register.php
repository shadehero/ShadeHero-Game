<?php
    require('../DB_Connect.php');

    $id = "1";
    $login = $_POST['login'];
    $password = $_POST['password'];
    $email = $_POST['email'];

    $sql_login = "SELECT login FROM users WHERE login = '".$login."';";
    $sql_add_user = "INSERT INTO `shadehero`.`users` (`login`, `password`, `email`) VALUES ('".$login."', '".$password."', '".$email."');";

    $query_result = mysql_query($sql_login);
    $rows_count = mysql_num_rows($query_result);

    if($rows_count == 0)
    {
        mysql_query($sql_add_user);
        echo "OK";
    }
    else
    {
        echo "LOGIN_ERROR";
    }
?>