<%-- 
    Document   : lista_dogs
    Created on : 22/jul/2022, 11:45:51
    Author     : Formação
--%>

<%@page import="business.*"%>
<%@page import="persistence.DBManager"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    DBManager dbManager = new DBManager();

    Loja l = dbManager.loadLoja();

    String operacao = request.getParameter("op");

    if (operacao != null & operacao != "") {
        if (operacao.equals("del")) {
            try {
                int id = Integer.parseInt(request.getParameter("id"));
                dbManager.remove(l.getCompra(id));
                out.print("<script>location.href='lista_compras.jsp';</script>");
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
        <title>...|Lista de compras|...</title>
        <style>
            .lista_dogs td{

                border: 1px solid black;
            }
        </style>
    </head>
    <body>
        <%@include file="include/app_navbar.jsp" %>
        <div class="container-fluid">
            <h1 class='text-center text-secondary display-2'>Lista de Compras</h1>

            <div class="card">
                <div class="card-body p-0">
                    <table class="table table-striped m-0">
                        <thead class="bg-light">
                            <tr>
                                <th>Código</td>
                                <th>Data</td>
                                <th>Valor</td>
                                <th>Cliente</td>
                                <th>cão</td>
                                <th class="col-1 text-center">Operações</td>
                            </tr>
                        </thead>

                        <tbody>

                            <%  int count = 0;
                                for (Compra compra : l.getCompras()) {
                                    count++;

                                    if (count >= (pagina* MAX_PAGE_SIZE)- (MAX_PAGE_SIZE-1)  && count <= (pagina *MAX_PAGE_SIZE)) {


                            %> 
                            <tr>
                                <td><%=compra.getId()%></td>
                                <td><%=compra.getData()%></td>
                                <td><%=compra.getValor()%></td>
                                <td><%=compra.getCliente().getNome()%></td>
                                <td><%=compra.getDog().getNome()%></td>

                                <td class="text-center">
                                    <a href="?op=del&id=<%= compra.getId()%>"><img src="images/deletar-lixeira .png"></a>&emsp;
                                    <a href="edit_compras.jsp?op=edit&id=<%= compra.getId()%>"><img src="images/editar-texto.png"></a>
                                </td>
                            </tr>
                            <%
                                    }
                                }
                            %>
                        </tbody>
                        <tfoot>
                            <tr> 
                                <td colspan="6"><!-- colocar aqui as páginas -->
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
                </div>

            </div>


            <br>
            <br>
            <a class="btn btn-secondary" href="edit_dog.jsp?op=new">Novo Dog</a>
            <a class="btn btn-secondary" href="index.jsp">Voltar a Home</a>
        </div>
    </body>
</html>
