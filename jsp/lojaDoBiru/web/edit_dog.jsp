<%-- 
    Document   : edit_dog
    Created on : 22/jul/2022, 11:51:45
    Author     : Formação
--%>
<%@page import="java.time.LocalDate"%>
<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.util.Date"%>

<%@page import="business.Dog"%>
<%@page import="business.Loja"%>
<%@page import="persistence.DBManager"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
        
    DBManager dbManager = new DBManager();

    Loja l = dbManager.loadLoja();

    String operacao = request.getParameter("op");
    Dog dog = new Dog(-1, "","", null,"");

    if (operacao != null & operacao != "") {
        if (operacao.equals("save")) {
            int id = -1;

                try {

                    id = Integer.parseInt(request.getParameter("id"));

                } catch (NumberFormatException ex) {
                    out.println("O id é inválido!");

                }

                String nome = request.getParameter("txtNome");
                String sexo = request.getParameter("txtSexo");
                LocalDate nascimento = LocalDate.parse(request.getParameter("txtNascimento"));
                String cor = request.getParameter("txtCor");
                               
                dog = new Dog(id, nome, sexo, nascimento, cor);
                
                if (dbManager.save(dog) > 0) {

                    out.println("<script>window.location= 'lista_dogs.jsp';</script>");

                } else {

                    out.println("Erro ao guardar o novo dog");
                }

        } else if (operacao.equals("edit")) {
            int id = -1;
            try {
                id = Integer.parseInt(request.getParameter("id"));
                dog = l.getDog(id);

            } catch (NumberFormatException ex) {
                out.println("O id é inválido!");
            }
        }
    }

%>


<!DOCTYPE html>
<html>
    <head>
        <%@include file="include/html_generic_includes.jsp" %>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>... |Novo Dog|...</title>
    </head>
    <body>
        <%@include file="include/app_navbar.jsp" %>
        <h1>... |Novo Dog|...</h1>
        <form action="?op=save" method="POST">
            <input type="hidden" name="id" value="<%= dog.getId() %>"/>
            <input type="text" name="txtNome" value="<%= dog.getNome()%>" placeholder="Nome..."/>
            <input type="text" name="txtSexo" value="<%= dog.getSexo()%>" placeholder="Sexo..."/>
            <input type="date" name="txtNascimento" value="<%= dog.getNascimento()%>" placeholder="Nascimento..."/>
            <input type="color" name="txtCor" value="<%= dog.getCor()%>" placeholder="Cor..."/>
          
            <input type="hidden" value="save" name="op"/>
            <input type="submit" value="Guardar" name="cmdGuardar"/>

        </form>
            <br>
        <a href="lista_dogs.jsp">Voltar a listagem</a>
    </body>
</html>