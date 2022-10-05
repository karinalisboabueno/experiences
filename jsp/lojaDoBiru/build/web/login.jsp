<%-- 
    Document   : login
    Created on : 19/jul/2022, 15:26:35
    Author     : ruiboticas
--%>

<%@page import="business.Utilizador"%>
<%@page import="persistence.DBManager"%>
<%@page import="persistence.DBWorker"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%
    String username = request.getParameter("txtUsername");
    String password = request.getParameter("txtPassword");
    
    DBManager dbManager = new DBManager();
    
    Utilizador utilizador = dbManager.loadUtilizador(username, password);
    
    if(utilizador != null){
        // Utilizador válido
        session.setAttribute("utilizador", utilizador);
        out.println("<script>window.location='index.jsp';</script>");
    }else{
        // Utilizador inválido
        out.println("<br>Utilizador invalido");
        out.println("<br><a href=\"index.jsp\" >Voltar ao inicio</a>");
    }
    

%>