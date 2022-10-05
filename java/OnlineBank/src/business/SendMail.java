package business;

import javax.mail.*;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import java.util.Properties;
import presentation.MessageBox;

/**
 *Classe com utilitários relacionados com envio de email
 * @author Karina
 */
public class SendMail {

    private static Session session;
    
    
    
    public static void sendToCliente(String assunto, String mensagem, Cliente cliente){
        send(assunto, String.format("Olá %s,\n\n%s\n\n\nCumprimentos,\nKbank!", cliente.getNome(), mensagem), cliente.getEmail());
    }

    /**
     * Método para enviar email
     * @param assunto do email
     * @param mensagem a enviar
     * @param to email para onde enviar
     */
    public static void send(String assunto, String mensagem, String to) {
       try {

           
            Message message = new MimeMessage(getSession());
            message.setFrom(new InternetAddress("kbank@kbank.com"));
            message.setRecipients(
                    Message.RecipientType.TO,
                    InternetAddress.parse(to)
            );
            message.setSubject("KBANK!: "+assunto);
            message.setText(mensagem);

            Transport.send(message);

        } catch (MessagingException e) {
            MessageBox.showError(e);
        }
    }
/**
 * Se estiver a null cria uma sessão a ser usada para envio de email
 * @return Session
 */
    private static Session getSession() {
        if (session == null) {

            Properties prop = new Properties();
            prop.put("mail.smtp.host", "smtp.gmail.com");
            prop.put("mail.smtp.port", "587");
            prop.put("mail.smtp.auth", "true");
            prop.put("mail.smtp.starttls.enable", "true"); //TLS

            session = Session.getInstance(prop,
                    new javax.mail.Authenticator() {
                @Override
                protected PasswordAuthentication getPasswordAuthentication() {
                    return new PasswordAuthentication("testekbank@gmail.com", "123kbank!");
                }
            });
        }
        
        return session;
    }

}
