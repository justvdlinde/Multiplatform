<?php
	$servername = "localhost";
	$server_username = "root";
	$server_password = "admin";
	$dbName = "MultiPlatform";
	
	$username = $_POST["usernamePost"];
	$email = $_POST["emailPost"];
	$password = $_POST["passwordPost"];
	
	//Make Connectiond
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "INSERT IGNORE INTO users (username, email, password) 
			VALUES ('".$username."', '".$email."','".$password."')";
	$result = mysqli_query($conn, $sql);
	
	if(!result) echo "Error spotted";
	else echo "no its ok";


?>