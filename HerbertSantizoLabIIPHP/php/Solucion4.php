<html>
    <body>
        <?php
            $numero = $_GET['num'];
                $numero;
                if($numero > 0){
                    echo "El número es <b>positivo.<b>";
                }
                else if ($numero < 0){
                    echo "El número es <b>negativo.<b>";
                }
                else{
                    echo "El número es <b>cero.<b>";
                }
        ?>
    </body>    
</html>