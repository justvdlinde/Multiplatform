<?php
	$servername = "localhost";
	$username = "root";
	$password = "admin";
	$dbName = "MultiPlatform";
	
	//Make Connection
	$conn = new mysqli($servername, $username, $password, $dbName);
	//Check Connection
	if(!$conn){
		die("Connection Failed. ". mysqli_connect_error());
	}
	
	$sql = "SELECT x_pos, y_pos, z_pos FROM vectors";
	//$sql2 = "SELECT X, Y, Z FROM vectors";
	$result = mysqli_query($conn, $sql);
	//$result2 = mysqli_query($conn, $sql2);
	
	if(mysqli_num_rows($result) > 0) {
		while($row = mysqli_fetch_assoc($result)) {
			echo "".$row['x_pos'].";".$row['y_pos'].";".$row['z_pos']. ";";
		}
		//while($row = mysqli_fetch_assoc($result2)) {
		//	echo "X:".$row['X']."|Y:".$row['Y']."|Z:".$row['Z'] . ";";
		//}
	}


?>