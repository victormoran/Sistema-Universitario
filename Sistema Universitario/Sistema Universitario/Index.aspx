<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Sistema_Universitario.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema Universitario</title>
 <script src="resources/js/jquery.js" type="application/javascript"></script>
<script type="text/javascript" src="resources/jquery.validate.js"></script>
 <script src="resources/js/script.js" type="application/javascript"></script>
</head>
<body>
    <div id="header">
      <div class="header">
        <div class="logo">
          <div class="logo__interior">
            <h1 class="logo__nombre">UAP<small>Filial Piura</small></h1>
          </div>
        </div>
        <div class="menu">
          <div class="menu__toggle icon-menu">Menu</div>
          <ul class="menu__lista menu__lista--oculta">
            <li class="menu__item"><a href="#" class="menu__link">Inicio</a></li>
            <li class="menu__item"><a href="#vision" class="menu__link">Acerca</a></li>
            <li class="menu__item"><a href="#" class="menu__link icon-libro">Carreras</a></li>
            <li class="menu__item"><a href="#resena" class="menu__link icon-nota">Historia</a></li>
            <li class="menu__item"><a href="#galeria" class="menu__link icon-foto">Galería</a></li>
            <li class="menu__item menu__item--activo"><a href="#" class="menu__link menu__link--intranet">Intranet</a></li>
          </ul>
        </div>
        <form id="formulario" class="formulario" runat="server">
          <div class="formulario__invisible"></div>
          <div class="formulario__contenedor">
            <label for="inputUsuario" class="formulario__etiqueta">Usuario</label>
            <asp:TextBox id="inputUsuario" placeholder="Usuario" name="inputUsuario" class="formulario__caja" runat="server"></asp:TextBox>
            <label for="inputPass" class="formulario__etiqueta">Contraseña</label>
            <asp:TextBox id="inputPass" runat="server" placeholder="Contraseña" name="inputPass" class="formulario__caja"></asp:TextBox>
            <asp:Button runat="server" Text="Ingresar"  href="/html/intranet/Alumno/index.html" class="formulario__boton" OnClick="Unnamed4_Click"/>
          </div>
        </form>
      </div>
    </div>
    <div id="categorias">
      <div class="categorias">
        <div class="categoria">
          <div class="categoria__imagen"><asp:Image runat="server" ImageUrl="~/resources/img/sistemas.jpg"/></div>
          <h3 class="categoria__titulo">Carreras</h3>
          <h4 class="categoria__subtitulo">Que marcan tu futuro</h4>
          <p class="categoria__texto">
            Carrera de Ingenieria de Sistemas a manos de docentes altamente calificados para formar profesionales capaces de afrontas
            los cambios constantes de la tecnologia en el mundo.
          </p><a href="http://www.uap.edu.pe" class="categoria__boton" target="_blank">Leer más</a>
        </div>
        <div class="categoria">
          <div class="categoria__imagen"><asp:Image runat="server" ImageUrl="~/resources/img/administracion.jpg" /></div>
          <h3 class="categoria__titulo">Carreras</h3>
          <h4 class="categoria__subtitulo">Que marcan tu futuro</h4>
          <p class="categoria__texto">
           Carrera de Administracion brindada por la UAP en donde muchos estudiantes adquieren conocimientos
            por parte de docentes expertos en la carrera actos para formar profesionales de alta competitividad en la carrera.
          </p><a href="http://www.uap.edu.pe" class="categoria__boton">Leer más</a>
        </div>
        <div class="categoria">
          <div class="categoria__imagen"><asp:Image runat="server" ImageUrl="~/resources/img/enfermeria.jpg" /></div>
          <h3 class="categoria__titulo">Carreras</h3>
          <h4 class="categoria__subtitulo">Que marcan tu futuro</h4>
          <p class="categoria__texto">
            Carrera de Enfermeria sobresaliente en la universidad por su amplia calidad de estudiantes actos para desenvolverse en la
              carrera con facilidad y valentia, sin duda es una carrera muy importante para sociedad.
          </p><a href="http://www.uap.edu.pe" class="categoria__boton">Leer más</a>
        </div>
        <div id="vision" class="categoria categoria--independiente">
          <h3 class="categoria__titulo categoria__titulo--independiente">VISION DE LA UAP</h3>
          <p class="categoria__texto categoria__texto--independiente">
            Ser una institución acreditada, solidaria, relacionada con su entorno nacional e internacional y con los avances científicos y tecnológicos para impulsar el desarrollo de nuestro país. 
          </p><a href="http://www.uap.edu.pe/Esp/Nosotros/Universidad/inicio.aspx" class="categoria__boton categoria__boton--independiente">Leer más</a>
        </div>
      </div>
    </div>
    <div id="resena">
      <div class="resena">
        <h3 class="resena__titulo">Acerca de la Universidad</h3>
        <h4 class="resena__subtitulo">Cuando recien iniciamos</h4>
        <p class="resena__texto">Nuestra universidad fue gestada por iniciativa del Dr. Fidel Ramírez Prado, por entonces Presidente del Consejo de Administración de la Cooperativa de Ahorro y Crédito Alas Peruanas.</p>
        <p class="resena__texto">En marzo de 1989, la Asamblea General de delegados de la Cooperativa Alas Peruanas aprobó por unanimidad la iniciativa del Dr. Ramírez y le encargó que realice los trámites pertinentes para la culminación de tan ambicioso proyecto.</p>
        <p class="resena__texto">En 1994 bajo la presidencia del Lic. Aguilar Bailón de la Cruz, se presentó al Congreso de la Repùblica (Congreso Constituyente Democrático-CCD) el proyecto de creación Nº 1485/94 de la Universidad Alas Peruanas.</p>
        <p class="resena__texto">En 1995 continúan los trámites siendo Presidente de la Cooperativa el Dr. Ricardo Díaz Bazán; para entonces se crea el Consejo Nacional para la Autorización del Funcionamiento de Universidades (CONAFU), único organismo encargado de aprobar o rechazar los proyectos de universidades.</p>
        <p class="resena__texto">En 1996 bajo la presidencia del Consejo de Administración de la Cooperativa Alas Peruanas del Sr. Estanislao Chujutalli Muñoz y el Dr. Fidel Ramírez Prado como Gerente General, el CONAFU aprueba con fecha 26 de abril la Resolución Nº 102 que autoriza el funcionamiento de la Universidad Alas Peruanas, con cinco carreras profesionales.</p>
        <p class="resena__texto">Desde entonces la UAP ha seguido todos los pasos legales que formalizan y garantizan su existencia y expansión a nivel nacional e internacional.</p>
        <p class="resena__texto">El primero de junio del mismo año empieza a funcionar la universidad, siendo el Dr. Javier Pulgar Vidal nombrado Presidente de la Comisión Organizadora, el Dr. César Olano Aguilar Secretario General y el Dr. Fidel Ramírez Prado como Presidente Ejecutivo, habiendo sido ellos los encargados de planear, elaborar y sustentar el proyecto de desarrollo institucional de la UAP.</p>
        <p class="resena__texto">En el mes de noviembre del año 1999, el CONAFU con resolución Nº 656 declara la adecuación de la UAP al régimen de Sociedad Anónima en virtud al Derecho Legislativo Nº882 "Ley de promoción de la inversión en educación".</p>
        <p class="resena__texto">Por acuerdo unánime de la promotora de la UAP, el 8 de febrero del 2000 fue nombrado Rector de la Universidad Alas Peruanas el Ph.D Fidel Ramírez Prado, siendo posteriormente incorporado al pleno de la Asamblea Nacional de Rectores (ANR), desempeñando el cargo hasta la fecha.</p>
        <p class="resena__texto">Alas Peruanas es el ayer, también es el hoy y será el mañana. Siempre habrá una interacción entre el presente y el pasado.</p>
        <p class="resena__texto">Lo sucedido contribuye al conocimiento de lo actual, así como las experiencias del presente transforman nuestra percepción del pasado.</p>
        <p class="resena__texto">Alas Peruanas es una universidad que nació con ideas propias, conceptos prospectivos y planes siempre futuristas.</p>
        <p class="resena__texto">Por eso crece rápidamente. Pensar, escudriñar, inventar, etc constituyen la normal tarea de nuestra casa de estudios. Saludamos pues, a los rostros estudiantiles que anhelan ingresar a nuestras aulas.</p>
        <p class="resena__texto">Los recibimos con el mismo calor que ya recibieron nuestros 70 mil alumnos en todo el Perú.</p>
        <p class="resena__texto">Se trata de un saludo habitual que hace suyo nuestro rector, el Dr. Fidel Ramírez Prado.</p>
      </div>
    </div>
    <div id="galeria">
      <div class="galeria">
        <h2 class="galeria__titulo">Galeria</h2>
        <div class="galeria__item">
          <div class="galeria__imagen galeria__imagen--uno"></div>
          <div class="galeria__texto">
            <div class="galeria__subtitulo">Vista panoramica de la UAP</div>
            <div class="galeria__parrafo">DRONE mostrando la fachada de la UAP, en un día normal de trabajo</div>
          </div>
        </div>
        <div class="galeria__item">
          <div class="galeria__imagen galeria__imagen--dos"></div>
          <div class="galeria__texto">
            <div class="galeria__subtitulo">Visita de TEOFILO CUBILLAS</div>
            <div class="galeria__parrafo">Gran exjugador de la seleccion Peruana visito la UAP y demostro sus habilidades </div>
          </div>
        </div>
        <div class="galeria__item">
          <div class="galeria__imagen galeria__imagen--tres"></div>
          <div class="galeria__texto">
            <div class="galeria__subtitulo">Miss y Mister UAP 2015</div>
            <div class="galeria__parrafo">En gran disputa escogen a la nueva miss UAP y mister UAP 2015</div>
          </div>
        </div>
        <div class="galeria__item">
          <div class="galeria__imagen galeria__imagen--cuatro"></div>
          <div class="galeria__texto">
            <div class="galeria__subtitulo">Desfile Militar 2015</div>
            <div class="galeria__parrafo">La UAP se hace presente en el gran desfile militar realizado en Piura</div>
          </div>
        </div>
      </div>
    </div>
</body>
</html>
