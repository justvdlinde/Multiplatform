<?php
	$servername = "localhost";
	$server_username = "root";
	$server_password = "admin";
	$dbName = "MultiPlatform";
	
	$x_pos = $_POST["xPost"];
	$y_pos = $_POST["yPost"];
	$z_pos = $_POST["zPost"];
	
	//Make Connection
	$conn = new mysqli($servername, $server_username, $server_password, $dbName);
	
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "INSERT INTO vectors (x_pos, y_pos, z_pos) 
			VALUES ('".$x_pos."', '".$y_pos."','".$z_pos."')";
	$result = mysqli_query($conn, $sql);
	
	if(!result) echo "Error spotted";
	else echo "no its ok";


?>