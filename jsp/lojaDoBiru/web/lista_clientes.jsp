<%-- 
    Document   : lista_clientes
    Created on : 21/jul/2022, 15:34:19
    Author     : Formação
--%>

<%@page import="business.Cliente"%>
<%@page import="persistence.DBManager"%>
<%@page import="business.Loja"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    DBManager dbManager = new DBManager();

    Loja l = dbManager.loadLoja();

    String operacao = request.getParameter("op");

    if (operacao != null & operacao != "") {
        if (operacao.equals("del")) {
            try {
                int id = Integer.parseInt(request.getParameter("id"));
                dbManager.remove(l.getCliente(id));
                out.print("<script>location.href='lista_clientes.jsp';</script>");
            } catch (NumberFormatException ex) {
                out.println("O id é inválido!");
            }
        }
    }

    int pagina = 1;
    final int MAX_PAGE_SIZE = 5;
    double numero_paginas_float = (float) l.getClientes().size() / (float) MAX_PAGE_SIZE;
    int numero_paginas = (int) Math.ceil(numero_paginas_float);

    String paginaStr = request.getParameter("pagina");

    if (paginaStr != null & paginaStr != "") {
        try {
            pagina = Integer.parseInt(paginaStr);

        } catch (NumberFormatException ex) {
            out.println("Numero de pagina inválido!");
        }
    }

%>
<!DOCTYPE html>
<html>
    <head>
        <%@include file="include/html_generic_includes.jsp" %>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>...|Lista de Clientes|...</title>
        <style>
            .lista_clientes td{

                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <%@include file="include/app_navbar.jsp" %>
        <div class="container-fluid">
            <h1 class='text-center text-secondary display-2'>Lista de Clientes</h1>

            <div class="card">
                <div class="card-body p-0">
                    <table class="table table-striped m-0">
                        <thead class="bg-light">
                            <tr>
                                <th  >Código</td>
                                <th  >Nome</td>
                                <th  class="col-2 text-center">Operações</td>
                            </tr>
                        </thead>
                        <tbody>
                            <%  int count = 0;
                                for (Cliente cliente : l.getClientes()) {
                                    count++;

                                    if (count >= (pagina * MAX_PAGE_SIZE) - (MAX_PAGE_SIZE - 1) && count <= (pagina * MAX_PAGE_SIZE)) {


                            %> 
                            <tr>
                                <td><%=cliente.getId()%></td>
                                <td><%=cliente.getNome()%></td>
                                <td><a href="?op=del&id=<%= cliente.getId()%>"><img src="images/deletar-lixeira .png"></a>&emsp;
                                    <a href="edit_cliente.jsp?op=edit&id=<%= cliente.getId()%>"><img src="images/editar-texto.png"></a>&emsp;
                                    <a class="btn btn-info" href="compra.jsp?id=<%= cliente.getId()%>">Selecionar comprador</a>
                                </td>

                            </tr>
                            <%
                                    }
                                }
                            %>

                        </tbody>
                        <tfoot>
                            <tr>
                                <td colspan="6">   <!-- colocar aqui as páginas -->
                                    Pagina:
                                    <%
                                        for (int i = 1; i <= numero_paginas; i++) {

                                    %>
                                    <a href="?pagina=<%= i%>"> <%= i%> </a> |

                                    <%

                                        }
                                    %>


                                </td> 

                            </tr>

                        </tfoot>
                    </table>
                </div><!-- comment -->
            </div>

            <br>
            <br>
            <a class="btn btn-secondary" href="edit_cliente.jsp?op=new">Novo Cliente</a>
            <a class="btn btn-secondary" href="index.jsp">Voltar a Home</a>
        </div>
    </body><!-- comment -->


</html>
