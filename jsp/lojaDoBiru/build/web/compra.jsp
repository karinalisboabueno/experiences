<%-- 
    Document   : lista_dogs
    Created on : 22/jul/2022, 11:45:51
    Author     : Formação
--%>
<%@page import="business.Compra"%>
<%@page import="business.Dog"%>
<%@page import="business.Loja"%>
<%@page import="business.Cliente"%>
<%@page import="persistence.DBManager"%>
<%@page import="java.time.LocalDate"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    DBManager dbManager = new DBManager();
    Loja l = dbManager.loadLoja();
    String operacao = request.getParameter("op");
    
    if (operacao != null && operacao != "") {
    
        if (operacao.equals(("save"))) {
            int id = -1;
            try {
            
                String[] idsCaes = request.getParameterValues("chkCao");
                if(idsCaes!=null){
                boolean vendido = true;
                
                for (String ids : idsCaes) {
                    int idCao = Integer.parseInt(ids);
                    Dog dog = l.getDog(idCao);
                    
                    int clienteId = Integer.parseInt(request.getParameter("id"));
                    Cliente cliente = l.getCliente(clienteId);
                    
                    LocalDate data = LocalDate.now();
                    float valor = Float.parseFloat(request.getParameter("txtValor"));
                    
                    Compra compra = new Compra(id, dog, cliente, data, valor);
                    if (dbManager.save(compra) < 0) {
                        vendido = false;
                    }
                }
                if (vendido) {
                    for (String ids : idsCaes) {
                        int idCao = Integer.parseInt(ids);
                        Dog dog = l.getDog(idCao);
                        dog.setVendido(true);
                        dbManager.save(dog);
                    }
                    out.println(
                        "<script>window.location='lista_compras.jsp?resultado-acao=sucesso&resultado-mensagem=Compra realizada com sucesso!'</script> ");

                } else {
                    out.println("Erro ao guardar compra");

                }
    }

            } catch (Exception e) {
                e.printStackTrace();
               
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
        <title>...|Lista de Dogs|...</title>
        <script>
            var total = 0;
            function verValores() {
                //traz a lista
                total = 0;

                var listIds = document.getElementsByName('chkCao');
                var listValores = document.getElementsByName('txtValor');


                var i = 0;
                for (let item of listIds) {
                    if (item.checked === true) {
                        total += parseInt(listValores[i].value);
                        console.log(listValores[i].value);
                    }
                    i++;

                }
                var objcheckoutTotal = document.getElementById('checkoutTotal');
                objcheckoutTotal.innerHTML = total + ",00";

            }



        </script>

    </head>
    <body>
        <%@include file="include/app_navbar.jsp" %>
        <div class="container-fluid">
            <form action="?op=save&id=<%=request.getParameter("id")%>" method="POST">

                <h1 class='text-center text-secondary display-2'>Lista de Dogs Disponíveis</h1>
                <div class="card">
                    <div class="card-body p-0">
                        <table class="table table-striped m-0" >
                            <thead class="bg-light">
                                <tr>
                                    <th scope="col">Código</th>
                                    <th scope="col">Nome</th>
                                    <th scope="col">Sexo</th>
                                    <th scope="col">Nascimento</th>
                                    <th scope="col">Cor</th>
                                    <th scope="col">Valor</th>
                                    <th scope="col">Comprar Cão</th>
                                </tr>
                            </thead>

                            <tbody>

                                <%  int count = 0;
                                    for (Dog dog : l.getDogsDisponiveis()) {
                                        count++;

                                        if (count >= (pagina * MAX_PAGE_SIZE) - (MAX_PAGE_SIZE - 1) && count <= (pagina * MAX_PAGE_SIZE)) {


                                %> 
                                <tr>
                                    <td><%=dog.getId()%></td>
                                    <td><%=dog.getNome()%></td>
                                    <td><%=dog.getSexo()%></td>
                                    <td><%=dog.getNascimento()%></td>
                                    <td style="background-color:<%=dog.getCor()%>"></td>
                                    <td><input type="text" id="txtValor" name="txtValor" value="100" step="0.01" ></td>
                                    <td><input name="chkCao" id="chkCao" value="<%= dog.getId()%>" type="checkbox" onchange="verValores()" ></td>



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
                                    <td></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div><!-- comment -->
                </div>
                                    <br>
                <div class="row flex-row-reverse">
                    <div class="col-4 ">
                        <div class="card " >
                            <div class="card-header">
                                <h2>Total</h2>
                            </div>
                            <div class="card-footer">
                                <b class="float-end" id="checkoutTotal"> &euro;</b>
                            </div>

                            <div class="card-footer">
                                <button type="submit" class="btn btn-primary btn-block">Finalizar compra</button>
                            </div>
                        </div>

                    </div>
                </div>               
            </form>
        </div>
        <br>
        <br>
        <a class="btn btn-secondary" href="edit_dog.jsp?op=new">Novo Dog</a>
        <a class="btn btn-secondary" href="index.jsp">Voltar a Home</a>

    </body>
</html>
