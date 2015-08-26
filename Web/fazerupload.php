<!DOCTYPE html>
<html>
	<head>
		<title>Loader Config</title>
		<style type="text/css">
			*{
				font-family: Arial;
				font-size: 15px;
			}
			body{
				background-color: #90EE90;
			}
			form input[type=file]{
				margin-left: 60px;
				margin-bottom: 10px;
				color: white;
			}
			#conteudo{
				width: 35%;
				heigth: 20%;
				margin-left: 30%;
				background-color: #3CB371;
				border: 2px solid #3CB371;
				border-radius: 5px;
			}
			#Logo{
				margin-bottom: 5px;
				margin-left: 100px;
				color: white;
				font-size: 30px;
			}
			#conteudo p{
				margin-bottom: 1px;
			}
			.textBox{
				margin-left: 40px;
			}
			.botao1{
				border: none;
				margin-left: 60px;
				margin-bottom: 10px;
				background-color: #32CD32;
				border-radius: 3px;
				width: 150px;
				height: 25px;
				color: white;
				cursor: pointer;
				text-transform: uppercase;
				text-align: center;
			}
			.botao1:hover{
				background-color: #228B22;
			}
			#creditos{
				color: white;
				margin-left: 65%;
			}
			#label{
				margin-left:  60px;
				color: white;
			}
		</style>
	</head>
	<body>
		<div id="conteudo">
			<form enctype="multipart/form-data" action="fazendoupload.php" method="post">
			<p id="Logo"> Fazer Upload </p>
			<p id="label">Selecione o arquivo: <a id="creditos" href="index.php"> Inicio </a></p><br>
			<input name="userfile" type="file" /><br>
			<input class="botao1" type="submit" value="Upload"/><br>
			
			</form>
		</div>
		
	</body>
</html>


