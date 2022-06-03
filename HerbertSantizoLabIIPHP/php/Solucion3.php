<html>
    <body>
        <?php
            $cod = $_GET['cod'];
            $nombre = $_GET['nombre'];
            $sueldo = $_GET['sueldo'];
            $boni = $_GET['boni'];
            $hxtras = $_GET['hxtras'];
            $desc = $_GET['desc'];
            $apelli = $_GET['apelli'];
            
            $iggs = ($sueldo * 4.83)/100;
            $hxtras = ($sueldo + $boni)/30/8 * $hxtras;
            $totaling = ($sueldo + $boni + $hxtras);
            $totaldesc = ($desc + $iggs);
            $totalliq = ($totaling - $totaldesc);
        ?>
            <table border="1" align="center">
            <tr>
                <td colspan="2" align="center">DATOS GENERALES</td>
            </tr>
            <tr>
                <td align="center" widht="50%">Código:  </td>
                <td align="center"><?php echo $cod; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">Nombre Completo:  </td>
                <td align="center"><?php echo $nombre,' ', $apelli; ?></td>
            </tr>
            <tr>
                <td colspan="2" align="center">INGRESOS</td>
            </tr>
            <tr>
                <td align="center" widht="50%">Sueldo Base:  </td>
                <td align="center"><?php echo $sueldo; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">Bonificacion:   </td>
                <td align="center"><?php echo $boni; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">Horas Extras:  </td>
                <td align="center"><?php echo $hxtras; ?></td>
            </tr>
            <tr>
                <td colspan="2" align="center">DESCUENTOS</td>
            </tr>
            <tr>
                <td align="center" widht="50%">Descuentos:  </td>
                <td align="center"><?php echo $desc; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">IGGS:  </td>
                <td align="center"><?php echo $iggs; ?></td>
            </tr>
            <table border="1" align="center">
            <br><br>
            <tr>
                <td colspan="2" align="center">TOTAL A RECIBIR</td>
            </tr>
            <tr>
                <td align="center" widht="50%">Total de Ingresos:   </td>
                <td align="center"><?php echo $cod; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">Total de Descuentos:   </td>
                <td align="center"><?php echo $totaldesc; ?></td>
            </tr>
            <tr>
                <td align="center" widht="50%">Saldo Liquido:    </td>
                <td align="center"><?php echo $totalliq; ?></td>
            </tr>
    </body>
</html>