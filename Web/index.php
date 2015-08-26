<!DOCTYPE html>
<html>
	<head>
		<link rel="shortcut icon" href="icon.ico">
		<title>Loader Config</title>
		<style type="text/css">
			*{
				font-family: Arial;
				font-size: 15px;
			}
			body{
				background-color: #90EE90;
			}
			#conteudo{
				width: 20%;
				heigth: 20%;
				margin-left: 40%;
				background-color: #3CB371;
				border: 2px solid #3CB371;
				border-radius: 5px;
			}
			#Logo{
				margin-bottom: 5px;
				margin-left: 66px;
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
				margin-left: 40px;
				color: #00FF00;
				text-decoration : none;
			}
			#link{
				margin-left: 50px;
				color: white;
				font-size: 20px;
				text-decoration : none;
			}
		</style>
	</head>
	<body>
		<div id="conteudo">
			<form method="POST" action="editar.php">
			<p id="Logo"> Conf Editor</p>
			<p id="label">Nome</p>
			<input type="text" name="Nome" class="textBox" placeholder="ex: Loader Crossfire"/><br>
			<p id="label">Versao:</p>
			<input type="text" name="Versao" class="textBox" placeholder="ex: 1.0"/><br><br>
			<button type="submit" class="botao1">Salvar</button><br>
			<a id="link" href="fazerupload.php"> Fazer Upload </a>
			<p id="creditos"> by: gusdnide</p>
			</form>
		</div>
		
	</body>
</html>