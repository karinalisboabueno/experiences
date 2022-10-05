<%-- 
    Document   : index
    Created on : 1/jul/2022, 10:08:26
    Author     : ruiboticas
--%>

<%@page import="business.Utilizador"%>
<%@include file="include/app_pre_processor.jsp" %>

<%
    Utilizador utilizador = (Utilizador) session.getAttribute("utilizador");

%> 

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <%@include file="include/html_generic_includes.jsp" %>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <style>
            
            body{
                background-image: url(images/dog.jpg);
                background-repeat: no-repeat;
                background-size:900px;
                background-position: bottom center;
                height: 100vh;
            }
        </style>
    </head>
    <body>

        <%@include file="include/app_navbar.jsp"  %>


        <div id="login_form">

            <% if (utilizador == null) {


            %> 

            <section class="w-100 p-4 d-flex justify-content-center pb-4">
                <form action="login.jsp" method="POST" class="form-inline">
                    <!-- username input -->
                    <div class="form-outline mb-6">
                        <input type="text" name="txtUsername" id="form2Example1" class="form-control" />
                        <label class="form-label" for="form2Example1">Username</label>
                    </div>

                    <!-- Password input -->
                    <div class="form-outline mb-6">
                        <input type="password" name="txtPassword" id="form2Example2" class="form-control" />
                        <label class="form-label" for="form2Example2">Password</label>
                    </div>

                    <!-- Submit button -->
                    <button type="submit" class="btn btn-primary btn-lg btn-block" style="margin-left: 50px">Entrar</button>

                </form>

            </section>

            <section class="w-100 p-4 d-flex justify-content-center pb-4">





                <% } else {

                    out.print("<br/><h1 class='text-center text-secondary display-2'>" + "Bem vindo(a), " + utilizador.getNome() + "</h1>");
                %>



                <%
                        //out.print("<br><br><a class=\"menuInicial\" href=\"lista_clientes.jsp\">Lista de Clientes</a><br>");
                        //out.print("<br><a class=\"menuInicial\" href=\"lista_dogs.jsp\">Lista de Dogs</a><br>");
                        //out.print("<br><a id=\"linklogout\" href=\"logout.jsp\">Terminar Sessão</a><br>");

                    }
                %>  


            </section>
        </div>
    </body>
</html>


<%@include file="include/app_pos_processor.jsp" %>