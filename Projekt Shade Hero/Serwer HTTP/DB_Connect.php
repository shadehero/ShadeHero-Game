<?php
 $connection = mysql_connect('localhost','root','');
 $db = mysql_select_db("shadehero",$connection);

 if(!$connection){
     die("nie moge sie polaczyc: ".mysql_error());
 }
?>