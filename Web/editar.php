<?php
	$Titulo = $_POST['Nome'];
	$Version = $_POST['Versao']; 
	if($Titulo !== "")
	{
		if($Version !== "")
		{
			Salvar($Titulo, $Version);
		}else{
			echo "<script>alert('Voce deixou a versao em banco')</script>";
		}
	}else{
	    echo "<script> alert('Voce deixou o Titulo em branco'); </script>";
	}
	header("Location: index.php");
	
    function Salvar($Nome, $Versao)
	{
		$SalvarComo = $Versao . "\n" . $Nome;
		$arquivo = fopen("config.conf", "w") or die("Nao foi possivel carregar arquivo");
		fwrite($arquivo, $SalvarComo);
		fclose($arquivo);
	}
	
?>