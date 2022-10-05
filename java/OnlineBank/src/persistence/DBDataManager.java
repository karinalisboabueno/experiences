package persistence;

import business.Cliente;
import business.Conta;
import business.Movimento;
import business.SendMail;
import java.math.BigDecimal;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.UUID;
import presentation.MessageBox;

/**
 * Classe com métodos para gerir a base de dados
 *
 * @author Karina
 */
public class DBDataManager {

    private DBWorker dbWorker;

    /**
     * Instancia a DBWorker
     *
     * @throws ClassNotFoundException
     * @throws IllegalAccessException
     * @throws InstantiationException
     * @throws SQLException
     */
    public DBDataManager() throws ClassNotFoundException, IllegalAccessException, InstantiationException, SQLException {
        dbWorker = new DBWorker("192.168.56.110", "admin", "123", "online_bank");
    }

    /**
     * Criar Cliente e uma conta com o valor passado como argumento
     *
     * @param cliente
     * @param primeiroMontante
     * @return cliente
     * @throws SQLException
     */
    public Cliente criarCliente(Cliente cliente, BigDecimal primeiroMontante) throws SQLException {

        if (cliente != null) {

            try ( PreparedStatement ps = dbWorker.createPreparedStatement("insert into cliente(nome,email,endereco,senha) values (?,?,?,?)")) {

                ps.setString(1, cliente.getNome());
                ps.setString(2, cliente.getEmail());
                ps.setString(3, cliente.getEndereco());
                ps.setString(4, cliente.getSenha());
                ps.executeUpdate();

                cliente.setId(dbWorker.getGeneratedKey(ps));

                Conta c = new Conta();

                c = criarContaBancaria(c, cliente, primeiroMontante);

                cliente.getContas().add(c);
               
            }

        }

        return cliente;
    }

    /**
     * Cria uma conta com os dados passados como argumento
     *
     * @param c conta
     * @param cliente
     * @param primeiroMontante
     * @return conta
     * @throws SQLException
     */
    public Conta criarContaBancaria(Conta c, Cliente cliente, BigDecimal primeiroMontante) throws SQLException {
        PreparedStatement ps = null;
        try {

            c.setNumeroConta(cliente.getId() + (int) Math.ceil(Math.random() * (999999999 - 100000000) + 100000000) + "");

            ps = dbWorker.createPreparedStatement("insert into conta(numero_conta, id_cliente, tipo_conta) values (?,?,?)");

            ps.setString(1, c.getNumeroConta());
            ps.setInt(2, cliente.getId());
            ps.setString(3, c.getTipo().name());
            ps.executeUpdate();

            c.setId(dbWorker.getGeneratedKey(ps));

        } catch (SQLException e) {
            c = criarContaBancaria(c, cliente, primeiroMontante);
        } finally {
            if (ps != null) {
                ps.close();
            }
        }

        Movimento mov = new Movimento();
        mov.setTipo(Movimento.Tipo.D);
        mov.setMontante(primeiroMontante);
        registarMovimento(c, mov);
        
        SendMail.sendToCliente("Conta criada com sucesso!", String.format("Criaste a tua %s com sucesso!\n\n Nº Conta: %s", c.getTipo(), c.getNumeroConta()), cliente);
        
        return c;
    }

    /**
     * Obter Cliente através do seu ID
     *
     * @param idCliente
     * @return um cliente
     */
    public Cliente loadCliente(Integer idCliente) throws SQLException {

        Cliente cli = null;

        PreparedStatement ps = null;
        try {
            ps = dbWorker.createPreparedStatement("select * from cliente where id_cliente=?;");
            ps.setInt(1, idCliente);

            ResultSet rs = ps.executeQuery();

            if (rs.next()) {
                cli = Cliente.fromResultSet(rs);

            }

            ps = dbWorker.createPreparedStatement("select * from conta where id_cliente=?");
            ps.setInt(1, idCliente);

            rs = ps.executeQuery();
            while (rs.next()) {

                Conta c = Conta.fromResultSet(rs);
                c.setCliente(cli);

                this.getMovimentosConta(c);

                cli.getContas().add(c);
            }

        } finally {
            if (ps != null) {
                ps.close();
            }
        }

        return cli;
    }

    /**
     * Obter cliente através do email
     *
     * @param email
     * @return cliente
     * @throws
     */
    public Cliente loadClienteByEmail(String email) throws SQLException {

        Cliente cli = null;
        PreparedStatement ps = null;
        try {
            ps = dbWorker.createPreparedStatement("select * from cliente where email=?;");
            ps.setString(1, email);

            ResultSet rs = ps.executeQuery();

            if (rs.next()) {
                cli = Cliente.fromResultSet(rs);

            }

            ps = dbWorker.createPreparedStatement("select * from conta where id_cliente=?");
            ps.setInt(1, cli.getId());

            rs = ps.executeQuery();
            while (rs.next()) {

                Conta c = Conta.fromResultSet(rs);
                c.setCliente(cli);

                this.getMovimentosConta(c);

                cli.getContas().add(c);
            }

        } catch (SQLException e) {
            e.printStackTrace();
            throw e;
        } finally {
            if (ps != null) {
                ps.close();
            }
        }

        return cli;
    }

    /**
     * Regista Movimento relativo a conta passada como argumento e atualiza o
     * seu saldo corrente
     *
     * @param c
     * @param m
     * @return movimento ou null se algo correr mal
     */
    public Movimento registarMovimento(Conta c, Movimento m) throws SQLException {

        PreparedStatement ps = null;

        try {

            ps = dbWorker.createPreparedStatement("insert into movimento(tipo,montante, saldo, id_conta) values(?,?,?,?);");

            ps.setString(1, m.getTipo().name());
            ps.setBigDecimal(2, m.getMontante());

            BigDecimal saldo = new BigDecimal(0);

            if (m.getTipo().equals(Movimento.Tipo.D)) {
                saldo = c.getSaldo().add(m.getMontante());
            } else {
                saldo = c.getSaldo().subtract(m.getMontante());
            }

            ps.setBigDecimal(3, saldo);

            ps.setInt(4, c.getId());
            ps.executeUpdate();

            m.setId(dbWorker.getGeneratedKey(ps));
            m.setSaldo(saldo);
            m.setConta(c);
            c.getMovimentos().add(m);

            ps = dbWorker.createPreparedStatement("update conta set saldo=? where id_conta=?;");
            ps.setBigDecimal(1, saldo);
            ps.setInt(2, c.getId());
            ps.executeUpdate();

            return m;

        } catch (Exception e) {
            e.printStackTrace();
            throw e;

        } finally {
            if (ps != null) {
                ps.close();
            }
        }

    }

    /**
     * Obter movimentos da conta
     *
     * @param c
     * @return movimentos
     */
    public ArrayList<Movimento> getMovimentosConta(Conta c) {

        try ( PreparedStatement ps = dbWorker.createPreparedStatement("select * from movimento where id_conta=? order by data_atual;");) {

            ps.setInt(1, c.getId());

            ResultSet rs = ps.executeQuery();

            while (rs.next()) {

                Movimento m = Movimento.fromResultSet(rs);
                m.setConta(c);
                c.getMovimentos().add(m);

            }

        } catch (Exception e) {
            e.printStackTrace();
        }

        return c.getMovimentos();
    }

    /**
     * Verificar se o cliente existe passando os criterios de email e senha
     *
     * @param email
     * @param senha
     * @return cliente
     */
    public Cliente checkLogin(String email, String senha) {

        Cliente cliente = null;
        try ( PreparedStatement ps = dbWorker.createPreparedStatement("select * from cliente where email=? and senha=?")) {

            ps.setString(1, email);
            ps.setString(2, senha);

            ResultSet rs = ps.executeQuery();

            if (rs.next()) {
                cliente = Cliente.fromResultSet(rs);
            }

        } catch (Exception e) {
            e.printStackTrace();
        }

        return cliente;
    }

    /**
     * Obter uma conta através do número da conta
     *
     * @param numeroConta
     * @return conta
     * @throws SQLException
     */
    public Conta getContaByNumero(String numeroConta) throws SQLException {

        try ( PreparedStatement ps = dbWorker.createPreparedStatement("select * from conta where numero_conta=?")) {

            ps.setString(1, numeroConta);

            ResultSet rs = ps.executeQuery();

            if (rs.next()) {

                Conta c = Conta.fromResultSet(rs);
                c.setCliente(this.loadCliente(rs.getInt("id_cliente")));
                return c;
            }
        }

        return null;
    }

    /**
     * Regista os movimentos relativos a transferencia de um montante de uma
     * conta(origem) para outra (destino)
     *
     * @param origem
     * @param destino
     * @param montante
     */
    public void transferir(Conta origem, Conta destino, BigDecimal montante) throws SQLException {

        if (origem.getSaldo().longValue() >= montante.longValue()) {

            Movimento m = new Movimento();
            m.setMontante(montante);
            m.setTipo(Movimento.Tipo.C);
            registarMovimento(origem, m);
            SendMail.sendToCliente(String.format("Enviaste %s €!", montante), String.format("Foi enviado o montante de %s€ para a conta %s.", montante, destino.getNumeroConta()), origem.getCliente());

            m = new Movimento();
            m.setMontante(montante);
            m.setTipo(Movimento.Tipo.D);
            registarMovimento(destino, m);
            SendMail.sendToCliente(String.format("Recebeste %s €!", montante), String.format("Recebeste o montante de %s€ proveniente da conta %s.", montante, origem.getNumeroConta()), destino.getCliente());
        } else {
            MessageBox.showError("Sem Saldo Suficiente :(!");
        }

    }

    /**
     * Persistir alteração de um cliente na base de dados
     *
     * @param cliente
     * @return cliente
     * @throws SQLException
     */
    public Cliente editarCliente(Cliente cliente) throws SQLException {
        PreparedStatement ps = dbWorker.createPreparedStatement("UPDATE cliente SET nome =?, endereco =?, email = ? WHERE id_cliente = ?;");
        ps.setString(1, cliente.getNome());
        ps.setString(2, cliente.getEndereco());
        ps.setString(3, cliente.getEmail());
        ps.setInt(4, cliente.getId());
        ps.executeUpdate();

        return this.loadCliente(cliente.getId());

    }

    /**
     * Remove todos os dados relativos a cliente(conta,movimento,cliente)
     *
     * @param idCliente
     * @throws SQLException
     */
    public void encerrarConta(Integer idCliente) throws SQLException {
        PreparedStatement ps = dbWorker.createPreparedStatement("delete from cliente where id_cliente=?;");
        ps.setInt(1, idCliente);
        ps.executeUpdate();
    }

    /**
     * Envia email com um codigo para redefinir a senha
     *
     * @param cliente
     * @return codigo
     */
    public String enviarEmailRecuperacao(Cliente cliente) {

        String codigo = UUID.randomUUID().toString();

        //ENVIA EMAIL
        SendMail.sendToCliente("Código de recuperação", String.format("Utilize o código ' %s ' para avançar com a alteração da senha.", cliente.getNome(), codigo), cliente);

        return codigo;
    }

    /**
     * Modifica a senha de um cliente na base de dados
     *
     * @param cliente
     * @param senha
     * @throws SQLException
     */
    public void alterarSenha(Cliente cliente, String senha) throws SQLException {
        PreparedStatement ps = dbWorker.createPreparedStatement("UPDATE cliente SET senha=? WHERE id_cliente=?;");
        ps.setString(1, senha);
        ps.setInt(2, cliente.getId());

        ps.executeUpdate();

    }

    public ArrayList<Movimento> getMovimentosCliente(Cliente cliente) throws SQLException {

        ArrayList<Movimento> movimentos = new ArrayList<>();

        try ( PreparedStatement ps = dbWorker.createPreparedStatement("select *  from movimento inner join conta using(id_conta) where id_cliente=? order by data_atual;")) {
            ps.setInt(1, cliente.getId());

            ResultSet rs = ps.executeQuery();

            while (rs.next()) {
                Movimento m = Movimento.fromResultSet(rs);
                m.setConta(Conta.fromResultSet(rs));
                movimentos.add(m);

            }
        }

        return movimentos;
    }

}
