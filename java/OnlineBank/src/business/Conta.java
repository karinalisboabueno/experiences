/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package business;

import java.math.BigDecimal;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *Classe que representa uma conta do Cliente
 * @author Karina
 */
public class Conta {

    private int id;
    private String numeroConta;
    private BigDecimal saldo;
    private Tipo tipo;
    private Cliente cliente;
    private ArrayList<Movimento> movimentos;

    /**
     *Construtor. Inicializa com o Saldo a zero, com o tipo corrente, uma lista de movimentos vazia.
     */
    public Conta() {
        saldo = new BigDecimal(0);
        tipo = Tipo.CORRENTE;
        movimentos = new ArrayList<>();
    }

    /**
     *Obter id da conta
     * @return id
     */
    public int getId() {
        return id;
    }

    /**
     *Definir id da conta
     * @param id
     */
    public void setId(int id) {
        this.id = id;
    }

    /**
     *Obter Numero de conta
     * @return
     */
    public String getNumeroConta() {
        return numeroConta;
    }

    /**
     *Definir numero de conta
     * @param numeroConta
     */
    public void setNumeroConta(String numeroConta) {
        this.numeroConta = numeroConta;
    }

    /**
     *Obter Cliente
     * @return cliente
     */
    public Cliente getCliente() {
        return cliente;
    }

    /**
     *Modificar Cliente
     * @param cliente
     */
    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    /**
     *Obter Tipo da conta
     * @return tipo
     */
    public Tipo getTipo() {
        return tipo;
    }

    /**
     *Modificar tipo da conta
     * @param tipo
     */
    public void setTipo(Tipo tipo) {
        this.tipo = tipo;
    }

    /**
     *Obter lista de movimentos
     * @return movimentos
     */
    public ArrayList<Movimento> getMovimentos() {
        return movimentos;
    }

    /**
     *Modificar movimentos
     * @param movimentos
     */
    public void setMovimentos(ArrayList<Movimento> movimentos) {
        this.movimentos = movimentos;
    }
    
    /**
     *Obter saldo da conta
     * @return saldo
     */
    public BigDecimal getSaldo() {
        return saldo;
    }

    /**
     *Modificar Saldo da conta
     * @param saldo
     */
    public void setSaldo(BigDecimal saldo) {
        this.saldo = saldo;
    }
   
    /**
     *Texto pré definido apresentar
     * @return
     */
    public String toString() {
        return this.tipo + ": " + this.getNumeroConta();
    }

    /**
     *Criar conta a partir do ResultSet
     * @param rs
     * @return conta
     * @throws SQLException
     */
    public static Conta fromResultSet(ResultSet rs) throws SQLException {
        Conta c = new Conta();
        c.setId(rs.getInt("id_conta"));
        c.setNumeroConta(rs.getString("numero_conta"));
        c.setTipo(Tipo.valueOf(rs.getString("tipo_conta")));
        c.setSaldo(rs.getBigDecimal("saldo"));
        return c;
    }
    
    /**
     *Enumeração com tipos de cliente.
     */
    public enum Tipo {

        /**
         *Para indicar que é uma conta poupança
         */
        POUPANCA("Conta Poupança"),

        /**
         *Para indicar que é uma conta corrente
         */
        CORRENTE("Conta Corrente");

        private String descricao;

        private Tipo(String descricao) {
            this.descricao = descricao;
        }

        /**
         *Texto pré definido apresentar
         * @return descricao
         */
        @Override
        public String toString() {
            return this.descricao;
        }

    }

}
