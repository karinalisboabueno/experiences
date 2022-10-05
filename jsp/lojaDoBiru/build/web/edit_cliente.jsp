<%--
    Document   : edit_cliente
    Created on : 22/jul/2022, 9:25:06
    Author     : Formação
--%>

<%@page import="business.Cliente"%>
<%@page import="business.Loja"%>
<%@page import="persistence.DBManager"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<%
    DBManager dbManager = new DBManager();

    Loja l = dbManager.loadLoja();

    String operacao = request.getParameter("op");
    Cliente cl = new Cliente(-1, "");

    if (operacao != null & operacao != "") {
        if (operacao.equals("save")) {
            int id = -1;

                try {

                    id = Integer.parseInt(request.getParameter("id"));

                } catch (NumberFormatException ex) {
                    out.println("O id é inválido!");

                }

                String nome = request.getParameter("txtNome");
                cl = new Cliente(id, nome);
                if (dbManager.save(cl) > 0) {

                    out.println("<script>window.location= 'lista_clientes.jsp?resultado-acao=sucesso&resultado-mensagem=Cliente criado com sucesso';</script>");

                } else {

                    out.println("<script>window.location= 'lista_clientes.jsp?resultado-acao=erro&resultado-mensagem=Ocorreu um erro';</script>");
                }

        } else if (operacao.equals("edit")) {
            int id = -1;
            try {
                id = Integer.parseInt(request.getParameter("id"));
                cl = l.getCliente(id);

            } catch (NumberFormatException ex) {
                out.println("O id é inválido!");
            }
        }
    }

%>


<!DOCTYPE html>
<html>
    <head>
        <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
        <title>... |Novo Cliente|...</title>
        <script>
            function validaForm(){
                var txtNomeCliente = document.getElementById("txtNome");
                if(txtNomeCliente.value != ""){
                    return true;
                }else{
                    return false;
                }
                
            }
        </script>
    </head>
    <body>
        <h1>... |Novo Cliente|...</h1>
        <form action="?op=save" method="POST">
            <input type="hidden" name="id" value="<%= cl.getId() %>"/>
            <input type="text" id="txtNome" name="txtNome" value="<%= cl.getNome()%>" placeholder="Nome..."/>
            <%--
            <input type="submit" onclick ="return validaForm()" value="Guardar" name="cmdGuardar"/>
            Para validar se campo esta vazio e não deixar guardar
            --%>
             <input type="submit" onclick ="if(!validaForm()){alert('Deve ser informado o nome');return false;}else{ return true;};" value="Guardar" name="cmdGuardar"/>

        </form>
        <a href="lista_clientes.jsp">Voltar a listagem</a>
    </body>
</html>
