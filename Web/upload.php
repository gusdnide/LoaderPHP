<?php
$uploadfile = $_FILES['userfile']['name'];
if (move_uploaded_file($_FILES['userfile']['tmp_name'], $uploadfile)) {
    echo "<script>alert('Enviado com sucesso!');</script>";
} else{
    echo "<script>alert('Ocorreu algum error, nao foi possivel upar a atualizacao!');</script>";
}
?>