<%-- 
    Document   : app_navbar
    Created on : 24/07/2022, 15:18:42
    Author     : Karina
--%>

<header>
    <nav class="navbar navbar-expand-lg navbar-light">
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarTogglerDemo01" style="margin-left: 40px">
            <a class="navbar-brand "  href="index.jsp">Loja do Biru</a>
            <div id="logo"><img src="images/dog-training.png" alt="Logo" /></div>
            <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                <li class="nav-item active" style="margin-left: 40px">
                    <a class="nav-link" href="index.jsp">Home <span class="sr-only"></span></a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="lista_clientes.jsp">Clientes</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="lista_dogs.jsp">Dogs</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="lista_compras.jsp">Compras</a>
                </li>
            </ul> 
            <div class="d-flex position-absolute end-0">
            <a class="nav-link float-end" href="logout.jsp">Terminar Sessão &emsp;</a>
            </div>
        </div>
        
    </nav>
    <%-- 
     <div class="actions">
         <a href="index.jsp">Início</a>
     </div>
    --%>
</header>


<div class="container-fluid">
    <%
    
    if("sucesso".equals(request.getParameter("resultado-acao"))){
    
    
 %>
    <br/>
    <div class="alert alert-success" role="alert">
           ${param["resultado-mensagem"]}
    </div>
<%
    }else if("erro".equals(request.getParameter("resultado-acao"))){
%>

 <br/>
    <div class="alert alert-danger" role="alert">
           ${param["resultado-mensagem"]}
    </div>
    <br/>
    <%
    }
%>
</div>

