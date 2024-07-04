<?php
// Database connection configuration
$servername = "localhost";
$username = "host";
$password = "your_password";
$dbname = "your_database_name";

// Create a connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check the connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

// Retrieve the email from the form
$email = $_POST['email'];

// Prepare the SQL statement to insert the email into the table
$sql = "INSERT INTO emails (email) VALUES ('$email')";

// Execute the SQL statement
if ($conn->query($sql) === TRUE) {
    echo "Email stored successfully";
} else {
    echo "Error storing email: " . $conn->error;
}

// Close the database connection
$conn->close();
?>
