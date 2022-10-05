<%-- 
    Document   : logout
    Created on : 21/jul/2022, 14:38:09
    Author     : Formação
--%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%
    session.setAttribute("utilizador", null);
    session.invalidate();


%>

<a href="index.jsp">Voltar a home</a>