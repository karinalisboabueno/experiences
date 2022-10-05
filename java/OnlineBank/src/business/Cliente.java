package business;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.internet.AddressException;
import javax.mail.internet.InternetAddress;

/**
 * Classe que representa o cliente
 * @author Karina
 */
public class Cliente {

    private Integer id;
    private String nome;
    private String email;
    private String senha;
    private String endereco;
    private ArrayList<Conta> contas;

    /**
     *Construtor que inicializa a lista de contas
     */
    public Cliente() {
        this.contas = new ArrayList<Conta>();
    }

    /**
     * Obter endereço
     * @return endereço
     */
    public String getEndereco() {
        return endereco;
    }

    /**
     *Definir Endereço
     * @param endereco
     */
    public void setEndereco(String endereco) {
        if (endereco.isEmpty()) {
            throw new RuntimeException("Endereço obrigatório");
        }
        this.endereco = endereco;
    }

    /**
     *Obter Id Cliente
     * @return id 
     */
    public Integer getId() {
        return id;
    }

    /**
     *Definir id Cliente
     * @param id
     */
    public void setId(Integer id) {
        this.id = id;
    }

    /**
     *Obter Nome do Cliente
     * @return nome
     */
    public String getNome() {
        return nome;
    }

    /**
     *Definir nome do Cliente
     * @param nome
     */
    public void setNome(String nome) {
        if (nome.isEmpty()) {
            throw new RuntimeException("nome obrigatório");
        }
        this.nome = nome;
    }

    /**
     *Obter email do cliente
     * @return email
     */
    public String getEmail() {
        return email;
    }

    /**
     *Definir email cliente
     * @param email
     */
    public void setEmail(String email) {
        try {
            
            if (email.isEmpty()) {
                throw new RuntimeException();
            }
            
            new InternetAddress(email, true).validate();
            
            this.email = email;
            
        } catch (Exception ex) {
            throw new RuntimeException("Email inválido ou vazio", ex);
        }
    }

    /**
     *Obter senha do cliente
     * @return senha
     */
    public String getSenha() {
        return senha;
    }

    /**
     *Definir Senha do cliente
     * @param senha
     */
    public void setSenha(String senha) {
        if (senha.isEmpty()) {
            throw new RuntimeException("Senha obrigatória");
        }
        this.senha = senha;
    }

    /**
     *Obter lista de contas
     * @return contas
     */
    public ArrayList<Conta> getContas() {
        return contas;
    }

    /**
     *Definir lista de contas
     * @param contas
     */
    public void setContas(ArrayList<Conta> contas) {
        this.contas = contas;
    }

    /**
     *Criar cliente a partir do ResultSet
     * @param rs
     * @return Cliente
     * @throws SQLException
     */
    public static Cliente fromResultSet(ResultSet rs) throws SQLException{
        Cliente cli = new Cliente();
        cli.setId(rs.getInt("id_cliente"));
        cli.setEmail(rs.getString("email"));
        cli.setEndereco(rs.getString("endereco"));
        cli.setNome(rs.getString("nome"));
        
        return cli;
    }

}
