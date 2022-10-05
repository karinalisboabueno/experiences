/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package presentation;

import business.Cliente;
import business.Conta;
import javax.swing.JPanel;

/**
 *panel que lista os detalhes das contas dos clientes com recurso ao paneSaldoConta.
 * @author Karina
 */
public class PanelContasCliente extends JPanel {

    private Cliente cliente;
    private PanelSaldoConta contaCorrente;
    private PanelSaldoConta contaPoupanca;

    /**
     *
     */
    public PanelContasCliente() {
        super();
    }

    /**
     *
     * @return
     */
    public Cliente getCliente() {
        return cliente;
    }

    /**
     *
     * @param cliente
     */
    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
        
        this.removeAll();
        
        this.contaCorrente = new PanelSaldoConta();
        this.contaPoupanca = new PanelSaldoConta();
        
        for (Conta c : this.cliente.getContas()) {
            
            
            if (c.getTipo().equals(Conta.Tipo.CORRENTE)) {
                this.contaCorrente.setConta(c);
                this.add(this.contaCorrente);
            } else {
                this.contaPoupanca.setConta(c);
                this.add(this.contaPoupanca);
            }
        }
    }


}
