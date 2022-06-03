<html>
</body>
<img src="https://arc-anglerfish-arc2-prod-abccolor.s3.amazonaws.com/public/LLHZCHLOXJF4ZOV4XYTCOEMXC4.jpg" align="center">
<?php
 
$base = $_GET["base"];
 
$high = $_GET["high"];
 
$Hipo = sqrt(pow($base,2) + pow($high,2));
 
echo "Valor de Hipotenusa: " . $Hipo;
 
?>
</body>
</html>