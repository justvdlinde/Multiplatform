<?php
	$servername = "localhost";
	$username = "root";
	$password = "admin";
	$dbName = "MultiPlatform";
	
	$user_username = $_POST["usernamePost"];
	$user_password = $_POST["passwordPost"];
	
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "SELECT password, id FROM users WHERE username = '".$user_username."' ";
	
	$result = mysqli_query($conn, $sql);
	
	if(mysqli_num_rows($result) > 0) {
		while($row = mysqli_fetch_assoc($result)) {
			echo "ID = ".$row['id'].";";
			if($row['password'] == $user_password) {
				echo "login success";
				
			} else { 
				echo "password incorrect";
			}		
		}
	} else {
		echo "user not found";
	}
	
	
?>