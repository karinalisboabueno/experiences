/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package presentation;

import javax.swing.JOptionPane;

/**
 *Classe com metodos para mostrar janelas de mensagem
 * @author Karina
 */
public class MessageBox {

    /**
     *
     * @param msg
     */
    public static void show(String msg) {
        JOptionPane.showMessageDialog(null, msg);
   }

    /**
     *
     * @param msg
     */
    public static void showError(String msg) {
        JOptionPane.showMessageDialog(null, msg,"Erro", JOptionPane.ERROR_MESSAGE);
   }
  
    /**
     *
     * @param exp
     */
    public static void showError(Exception exp) {
       JOptionPane.showMessageDialog(null, exp.getMessage(), exp.getClass().getSimpleName(), JOptionPane.ERROR_MESSAGE);
       exp.printStackTrace();
   }

    static int showConfirm(String msg) {
        return JOptionPane.showConfirmDialog(null, msg);
    }
}
