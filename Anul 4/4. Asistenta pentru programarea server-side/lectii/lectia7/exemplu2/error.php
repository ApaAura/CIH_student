<?php if(!empty($_GET["login"])): ?>
    <?php if($_GET['login']==="succes"):?>
        <p style="color:green;">Autentificare cu succes!</p>
    <?php else:?>
        <p style="color:red;">Autentificare esuata!</p>
    <?php endif;?>
<?php  endif;?>