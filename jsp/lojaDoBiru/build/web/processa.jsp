<%-- 
    Document   : processa
    Created on : 14/jul/2022, 15:23:16
    Author     : ruiboticas
--%>

<%    
    int linhas = 0;
    try{
        linhas = Integer.parseInt(request.getParameter("txtLinhas"));
    }catch(NumberFormatException ex){
        linhas = 2;
    }
    
    int colunas = 0;
    try{
        colunas = Integer.parseInt(request.getParameter("txtColunas"));
    }catch(NumberFormatException ex){
        colunas = 2;
    }
    
    int borderSize = 0;
    try{
        borderSize = Integer.parseInt(request.getParameter("txtBorderSize"));
    }catch(NumberFormatException ex){
        borderSize = 1;
    }
    
    String borderColor = request.getParameter("txtBorderColor");
    
    boolean formatCheck = request.getParameter("chkLigaFormatacao") != null && request.getParameter("chkLigaFormatacao").equals("on") ? true : false;    
%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>JSP Page</title>
        <style>
            .format td{
                border: <%= borderSize %>px solid <%= borderColor %>;
            }
            
        </style>
    </head>
    <body>
        <table <% if(formatCheck) {out.println(" class=\"format\""); } %>>
            <%
            
            for (int i = 0; i < linhas; i++) {
            %>
                        <tr>

            <%
                    for (int j = 0; j < colunas; j++) {
            %>
                <td>
                    <%= request.getParameter("txtContent") %>gfshdgfjhsd
                </td>
            
            <%
                    }                    
            %>
            </tr>

            <%
            }
            
            %>
        </table>
    </body>
</html>
