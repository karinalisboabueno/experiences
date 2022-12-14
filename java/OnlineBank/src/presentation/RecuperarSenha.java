package presentation;

import business.Cliente;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import persistence.DBDataManager;

/**
 *Janela para redefinir a senha do cliente
 * @author Karina
 */
public class RecuperarSenha extends javax.swing.JFrame {

    DBDataManager db;
    String codigoEnviado = null;
    private Cliente cliente;

    /**
     * Creates new form RecuperarSenha
     */
    public RecuperarSenha() {
        initComponents();
        try {
            this.db = new DBDataManager();
        } catch (Exception ex) {
            MessageBox.showError(ex);
        }
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        panelBase = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        txtCriarSenha = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        txtRepetirSenha = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        btnConfirmaCodigo = new javax.swing.JButton();
        btnVoltarLogin = new javax.swing.JButton();
        txtEmail = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        btnEnviarCodigo = new javax.swing.JButton();
        txtCodigo = new javax.swing.JTextField();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/reset-password.png"))); // NOI18N

        jLabel2.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 36)); // NOI18N
        jLabel2.setText("Recuperar Senha");

        jLabel3.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 14)); // NOI18N
        jLabel3.setText("Criar Nova Senha");

        jLabel4.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 14)); // NOI18N
        jLabel4.setText("Repetir Senha");

        btnConfirmaCodigo.setBackground(new java.awt.Color(204, 0, 204));
        btnConfirmaCodigo.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 18)); // NOI18N
        btnConfirmaCodigo.setForeground(new java.awt.Color(255, 255, 255));
        btnConfirmaCodigo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/diskette.png"))); // NOI18N
        btnConfirmaCodigo.setText("Confirmar");
        btnConfirmaCodigo.setEnabled(false);
        btnConfirmaCodigo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                btnConfirmaCodigoMouseClicked(evt);
            }
        });
        btnConfirmaCodigo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnConfirmaCodigoActionPerformed(evt);
            }
        });

        btnVoltarLogin.setBackground(new java.awt.Color(204, 0, 204));
        btnVoltarLogin.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 18)); // NOI18N
        btnVoltarLogin.setForeground(new java.awt.Color(255, 255, 255));
        btnVoltarLogin.setIcon(new javax.swing.ImageIcon(getClass().getResource("/icons/back.png"))); // NOI18N
        btnVoltarLogin.setText("Voltar para Login");
        btnVoltarLogin.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnVoltarLoginActionPerformed(evt);
            }
        });

        jLabel5.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 14)); // NOI18N
        jLabel5.setText("Email");

        btnEnviarCodigo.setBackground(new java.awt.Color(204, 0, 204));
        btnEnviarCodigo.setFont(new java.awt.Font("Microsoft Sans Serif", 1, 18)); // NOI18N
        btnEnviarCodigo.setForeground(new java.awt.Color(255, 255, 255));
        btnEnviarCodigo.setText("Enviar C??digo");
        btnEnviarCodigo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEnviarCodigoActionPerformed(evt);
            }
        });

        txtCodigo.setEnabled(false);

        javax.swing.GroupLayout panelBaseLayout = new javax.swing.GroupLayout(panelBase);
        panelBase.setLayout(panelBaseLayout);
        panelBaseLayout.setHorizontalGroup(
            panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(panelBaseLayout.createSequentialGroup()
                .addGap(376, 376, 376)
                .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGap(376, 376, 376))
            .addGroup(panelBaseLayout.createSequentialGroup()
                .addGap(298, 298, 298)
                .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelBaseLayout.createSequentialGroup()
                        .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabel4, javax.swing.GroupLayout.Alignment.LEADING))
                        .addGap(298, 298, 298))
                    .addGroup(panelBaseLayout.createSequentialGroup()
                        .addComponent(jLabel5)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addGroup(panelBaseLayout.createSequentialGroup()
                        .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(txtRepetirSenha, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtCriarSenha, javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(txtEmail, javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(panelBaseLayout.createSequentialGroup()
                                .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addGroup(panelBaseLayout.createSequentialGroup()
                                        .addGap(15, 15, 15)
                                        .addComponent(btnVoltarLogin))
                                    .addComponent(jLabel3))
                                .addGap(217, 217, 217)))
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelBaseLayout.createSequentialGroup()
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelBaseLayout.createSequentialGroup()
                        .addComponent(txtCodigo, javax.swing.GroupLayout.PREFERRED_SIZE, 216, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(btnConfirmaCodigo)
                        .addGap(16, 16, 16))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, panelBaseLayout.createSequentialGroup()
                        .addComponent(btnEnviarCodigo)
                        .addGap(303, 303, 303))))
        );
        panelBaseLayout.setVerticalGroup(
            panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(panelBaseLayout.createSequentialGroup()
                .addContainerGap()
                .addComponent(btnVoltarLogin)
                .addGap(30, 30, 30)
                .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel2)
                .addGap(49, 49, 49)
                .addComponent(jLabel5)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtEmail, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtCriarSenha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(txtRepetirSenha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(35, 35, 35)
                .addComponent(btnEnviarCodigo)
                .addGap(96, 96, 96)
                .addGroup(panelBaseLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(btnConfirmaCodigo)
                    .addComponent(txtCodigo, javax.swing.GroupLayout.PREFERRED_SIZE, 30, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(16, 16, 16))
        );

        panelBaseLayout.linkSize(javax.swing.SwingConstants.VERTICAL, new java.awt.Component[] {btnConfirmaCodigo, txtCodigo});

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panelBase, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(panelBase, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnConfirmaCodigoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnConfirmaCodigoActionPerformed
        // TODO add your handling code here:
        btnEnviarCodigoActionPerformed(evt);
    }//GEN-LAST:event_btnConfirmaCodigoActionPerformed

    private void btnConfirmaCodigoMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_btnConfirmaCodigoMouseClicked
        // TODO add your handling code here:

    }//GEN-LAST:event_btnConfirmaCodigoMouseClicked

    private void btnEnviarCodigoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEnviarCodigoActionPerformed
        // TODO add your handling code here:

           try{
                if (this.txtCodigo.getText().isEmpty() && this.txtRepetirSenha.getText().equals(this.txtCriarSenha.getText())) {

                    this.cliente = db.loadClienteByEmail(txtEmail.getText());

                    if (this.cliente != null) {
                        this.codigoEnviado = db.enviarEmailRecuperacao(cliente);
                        this.txtCodigo.setEnabled(true);
                        this.btnConfirmaCodigo.setEnabled(true);
                    }

                } else {
                    if (this.codigoEnviado.equals(this.txtCodigo.getText()) && this.cliente != null) {
                        try {
                            db.alterarSenha(this.cliente, this.txtCriarSenha.getText());

                            this.btnVoltarLoginActionPerformed(evt);

                        } catch (SQLException ex) {

                            ex.printStackTrace();

                        }
                    }

                }
           }catch(Exception e){
              MessageBox.showError(e);
           }


    }//GEN-LAST:event_btnEnviarCodigoActionPerformed

    private void btnVoltarLoginActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnVoltarLoginActionPerformed
        Login login = new Login();
        setVisible(false);
        login.setVisible(true);
        dispose();
    }//GEN-LAST:event_btnVoltarLoginActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(RecuperarSenha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(RecuperarSenha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(RecuperarSenha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(RecuperarSenha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RecuperarSenha().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnConfirmaCodigo;
    private javax.swing.JButton btnEnviarCodigo;
    private javax.swing.JButton btnVoltarLogin;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JPanel panelBase;
    private javax.swing.JTextField txtCodigo;
    private javax.swing.JTextField txtCriarSenha;
    private javax.swing.JTextField txtEmail;
    private javax.swing.JTextField txtRepetirSenha;
    // End of variables declaration//GEN-END:variables
}
