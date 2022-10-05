
package presentation;

import business.Conta;
import java.awt.Color;
import java.awt.Font;
import java.math.BigDecimal;
import javax.swing.JLabel;
import javax.swing.JPanel;

/**
 *Panel que mostra detalhes de uma conta
 * @author Karina
 */
public class PanelSaldoConta extends JPanel {

    private Conta conta;

    /**
     *
     * @return
     */
    public Conta getConta() {
        return conta;
    }

    /**
     *
     * @param conta
     */
    public void setConta(Conta conta) {
        this.conta = conta;
        this.initComponent();
    }

    /**
     *
     */
    public PanelSaldoConta() {
        this.conta = new Conta();
        this.conta.setSaldo(BigDecimal.ZERO);
        this.conta.setNumeroConta("- - -");

        this.initComponent();
    }

    private void initComponent() {
        
        this.removeAll();
        this.setBackground(new java.awt.Color(102, 102, 102));  
        
        Font lblFont = new java.awt.Font("Microsoft Sans Serif", 1, 18);
        Color lblColor = new java.awt.Color(255, 255, 255);

        JLabel jLabel5 = new JLabel();
        jLabel5.setFont(lblFont); // NOI18N
        jLabel5.setForeground(lblColor);
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        jLabel5.setText("Saldo "+conta.getTipo());

        JLabel jLabel6 = new JLabel();
        jLabel6.setFont(lblFont); // NOI18N
        jLabel6.setForeground(lblColor);
        jLabel6.setText("Nº Conta:");

        JLabel labelNumeroContaHome = new JLabel();
        labelNumeroContaHome.setFont(lblFont); // NOI18N
        labelNumeroContaHome.setForeground(lblColor);
        labelNumeroContaHome.setText(conta.getNumeroConta());

        JLabel labelSaldoHome = new JLabel();
        labelSaldoHome.setFont(lblFont); // NOI18N
        labelSaldoHome.setForeground(lblColor);
        labelSaldoHome.setHorizontalAlignment(javax.swing.SwingConstants.RIGHT);
        labelSaldoHome.setText("€ " + conta.getSaldo().toString());

        javax.swing.GroupLayout thisLayout = new javax.swing.GroupLayout(this);
        this.setLayout(thisLayout);
        thisLayout.setHorizontalGroup(
                thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(thisLayout.createSequentialGroup()
                                .addContainerGap()
                                .addGroup(thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                        .addGroup(thisLayout.createSequentialGroup()
                                                .addGroup(thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                        .addComponent(labelNumeroContaHome, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE)
                                                        .addComponent(jLabel6, javax.swing.GroupLayout.PREFERRED_SIZE, 100, javax.swing.GroupLayout.PREFERRED_SIZE))
                                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 21, Short.MAX_VALUE)
                                                .addGroup(thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                                        .addComponent(jLabel5, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 220, javax.swing.GroupLayout.PREFERRED_SIZE)
                                                        .addComponent(labelSaldoHome, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 172, javax.swing.GroupLayout.PREFERRED_SIZE))
                                                .addContainerGap(22, Short.MAX_VALUE))))
        );
        
        thisLayout.setVerticalGroup(
                thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(thisLayout.createSequentialGroup()
                                .addContainerGap()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(jLabel5)
                                        .addComponent(jLabel6))
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                .addGroup(thisLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                        .addComponent(labelSaldoHome)
                                        .addComponent(labelNumeroContaHome))
                                .addContainerGap(16, Short.MAX_VALUE))
        );
    }
}
