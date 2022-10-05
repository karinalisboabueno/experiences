package business;

import java.math.BigDecimal;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.time.LocalDateTime;

/**
 *Classe que representa os Movimentos
 * @author Karina
 */
public class Movimento {
    
    private Integer id;
    private Conta conta;
    private LocalDateTime dataHora;
    private Tipo tipo;
    private BigDecimal montante;
    private BigDecimal saldo;

    /**
     *Obter id do movimento
     * @return id
     */
    public Integer getId() {
        return id;
    }

    /**
     *definir id movimento
     * @param id
     */
    public void setId(Integer id) {
        this.id = id;
    }

    /**
     *Obter conta do movimento
     * @return conta
     */
    public Conta getConta() {
        return conta;
    }

    /**
     *Definir conta do movimento
     * @param conta
     */
    public void setConta(Conta conta) {
        this.conta = conta;
    }

    /**
     *Obter datahora do movimento
     * @return datahora
     */
    public LocalDateTime getDataHora() {
        return dataHora;
    }

    /**
     *Definir datahora do movimento
     * @param dataHora
     */
    public void setDataHora(LocalDateTime dataHora) {
        this.dataHora = dataHora;
    }

    /**
     *Obter tipo do movimento
     * @return tipo
     */
    public Tipo getTipo() {
        return tipo;
    }

    /**
     *definir/modificar tipo do movimento
     * @param tipo
     */
    public void setTipo(Tipo tipo) {
        this.tipo = tipo;
    }

    /**
     *Obter Montante do movimento
     * @return montante
     */
    public BigDecimal getMontante() {
        return montante;
    }

    /**
     *definir/modificar montante do movimento
     * @param montante
     */
    public void setMontante(BigDecimal montante) {
        this.montante = montante;
    }

    /**
     *Obter saldo do movimento
     * @return saldo
     */
    public BigDecimal getSaldo() {
        
        return saldo;
    }

    /**
     *definir/modificar saldo do movimento
     * @param saldo
     */
    public void setSaldo(BigDecimal saldo) {
        this.saldo = saldo;
    }
    
    /**
     *Criar movimento a partir do ResultSet
     * @param rs
     * @return movimento
     * @throws SQLException
     */
    public static Movimento fromResultSet(ResultSet rs) throws SQLException {
        Movimento m = new Movimento();
        m.setId(rs.getInt("id"));
        
        Conta c = new Conta();
        c.setId(rs.getInt("id_conta"));
        m.setConta(c);
        m.setDataHora(rs.getTimestamp("data_atual").toLocalDateTime());
        m.setMontante(rs.getBigDecimal("montante"));
        m.setSaldo(rs.getBigDecimal("saldo"));
        m.setTipo(Tipo.valueOf(rs.getString("tipo")));
        
        return m;
    }
    
    /**
     * Enumeração com tipos de movimento.
     */
    public enum Tipo {

        /**
         *Para indicar que é uma conta a credito
         */
        C("Crédito"),

        /**
         *Para indicar que é uma conta a debito
         */
        D("Débito");
        
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
