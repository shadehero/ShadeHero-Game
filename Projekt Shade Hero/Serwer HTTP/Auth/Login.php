<?php
require("../DB_Connect.php");

$login = $_POST['login'];
$password = $_POST['password'];

$sql_login = "SELECT login FROM users WHERE login = '".$login."';";
$sql_password = "SELECT password FROM users WHERE password = '".$password."';";

$query_login = mysql_query($sql_login);
$query_password = mysql_query($sql_password);

$result_login = mysql_num_rows($query_login);
$result_password = mysql_num_rows($query_password);

if($result_login > 0)
{
    if($result_password > 0)
    {
        echo "OK";
    }
}
else
{
    echo "BAD";
}

?>