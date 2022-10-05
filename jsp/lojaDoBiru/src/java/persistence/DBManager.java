/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package persistence;

import business.Cliente;
import business.Compra;
import business.Dog;
import business.Loja;
import business.Utilizador;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

/**
 *
 * @author ruiboticas
 */
public class DBManager {

    private DBWorker dbWorker;

    public DBManager() throws ClassNotFoundException, IllegalAccessException, InstantiationException, SQLException {
        this.dbWorker = new DBWorker("192.168.56.110", "admin", "123", "dcDoBiru");
    }

    public int save(Dog dg) throws SQLException {
        
        
        String sql = "INSERT INTO Dog(id, nome, sexo, nascimento, cor, vendido) "
                + "VALUES(" + (dg.getId()<0?"null": dg.getId()) + ", '" + dg.getNome() + "','" + dg.getSexo() + "', '" + dg.getNascimento() + "', '" + dg.getCor() + "', '" + (dg.isVendido() ? "Y" : "N") + "') "
                + "ON DUPLICATE KEY UPDATE "
                + "     "
                + "          nome = '" + dg.getNome() + "',"
                + "          sexo = '" + dg.getSexo() + "',"
                + "          nascimento = '" + dg.getNascimento() + "', "
                + "          cor = '" + dg.getCor() + "',"
                + "          vendido = '" + (dg.isVendido() ? "Y" : "N") + "';";
       return dbWorker.executeUpdate(sql);
    }
//mudar para inteiro pois deve retornar um inteiro para confirmar
    public int save(Cliente cl) throws SQLException {
        String sql = "INSERT INTO Cliente(id, nome) "
                //operador ternario para saber se o id vem a null
                + "VALUES(" + (cl.getId()<0? "null":cl.getId()) + ", '" + cl.getNome() + "') "
                + "ON DUPLICATE KEY UPDATE "
                + "  "
                + "          nome = '" + cl.getNome() + "';";
       return dbWorker.executeUpdate(sql);
    }

    public int save(Compra cmp) throws SQLException {
        save(cmp.getDog());
        save(cmp.getCliente());
        String sql = "INSERT INTO Compra(id, data, valor, dogId, clienteId) "
                + "VALUES(" + (cmp.getId()<0? "null":cmp.getId()) + ", '" + cmp.getData() + "', " + cmp.getValor() + ", " + cmp.getDog().getId() + ", " + cmp.getCliente().getId() + ") "
                + "ON DUPLICATE KEY UPDATE "
                + "     "
                + "          data = '" + cmp.getData() + "',"
                + "          valor = '" + cmp.getValor() + "', "
                + "          dogId = '" + cmp.getDog().getId() + "',"
                + "          clienteId = '" + cmp.getCliente().getId() + "';";
       return dbWorker.executeUpdate(sql);
    }

    public int remove(Compra cmp) throws SQLException {
        String sql = "DELETE FROM Compra "
                + "WHERE id = " + cmp.getId();
        return dbWorker.executeUpdate(sql);
    }

    public int remove(Dog dg) throws SQLException {
        String sql = "DELETE FROM Compra "
                + "WHERE dogId = " + dg.getId();
        dbWorker.executeUpdate(sql);
        
        sql = "DELETE FROM Dog "
                + "WHERE id = " + dg.getId();
        return dbWorker.executeUpdate(sql);
    }

    public int removeCompra(Dog dg) throws SQLException {
        dg.setVendido(false);
        save(dg);
        String sql = "DELETE FROM Compra "
                + "WHERE dogId = " + dg.getId();
        return dbWorker.executeUpdate(sql);
    }

    public int remove(Cliente cl) throws SQLException {
        removeCompra(cl);
        String sql = "DELETE FROM Cliente "
                + "WHERE id = " + cl.getId();
        return dbWorker.executeUpdate(sql);
    }

    public int removeCompra(Cliente cl) throws SQLException {
        String sql = "DELETE FROM Compra "
                + "WHERE clienteId = " + cl.getId();
        return dbWorker.executeUpdate(sql);
    }

    public Dog loadDog(int id) throws SQLException {
        String sql = "SELECT * FROM Dog WHERE id = " + id;

        ResultSet rs = dbWorker.executeQuery(sql);

        if (rs.next()) {
            Dog dg = new Dog(id, rs.getString("nome"), rs.getString("sexo"), rs.getDate("nascimento").toLocalDate(), rs.getString("cor"));
            return dg;
        }
        return null;
    }

    public Cliente loadCliente(int id) throws SQLException {
        String sql = "SELECT * FROM Cliente WHERE id = " + id;

        ResultSet rs = dbWorker.executeQuery(sql);

        if (rs.next()) {
            Cliente cl = new Cliente(id, rs.getString("nome"));
            return cl;
        }
        return null;
    }
    
//-----------
    public ArrayList<Cliente> loadAllClientes() throws SQLException {
        String sql = "SELECT * FROM Cliente;";
        
        ArrayList<Cliente> clientes = new ArrayList<>();
        
        ResultSet rs = dbWorker.executeQuery(sql);

       while (rs.next()) {
            Cliente cl = new Cliente(rs.getInt("id"),rs.getString("nome"));
            clientes.add(cl);
           
        }
       
        return clientes;
    }
    
    
     public ArrayList<Dog> loadAllDogs() throws SQLException {
        String sql = "SELECT * FROM Dog;";
        
        ArrayList<Dog> dogs = new ArrayList<>();
        
        ResultSet rs = dbWorker.executeQuery(sql);

       while (rs.next()) {
            Dog d = new Dog();
            d.setId(rs.getInt("id"));
            d.setNome(rs.getString("nome"));
            d.setCor(rs.getString("cor"));
            d.setNascimento(rs.getDate("nascimento").toLocalDate());
            d.setSexo(rs.getString("sexo"));
            d.setVendido(rs.getBoolean("vendido"));
            dogs.add(d);
           
        }
       
        return dogs;
    }
     
     
       public ArrayList<Dog> loadDogsDisponiveis() throws SQLException {
        String sql = "SELECT * FROM Dog where vendido='N';";
        
        ArrayList<Dog> dogs = new ArrayList<>();
        
        ResultSet rs = dbWorker.executeQuery(sql);

       while (rs.next()) {
            Dog d = new Dog();
            d.setId(rs.getInt("id"));
            d.setNome(rs.getString("nome"));
            d.setCor(rs.getString("cor"));
            d.setNascimento(rs.getDate("nascimento").toLocalDate());
            d.setSexo(rs.getString("sexo"));
            d.setVendido(rs.getBoolean("vendido"));
            dogs.add(d);
           
        }
       
        return dogs;
    }
//-------------
    public Compra loadCompra(int id) throws SQLException {
        String sql = "SELECT * FROM Compra WHERE id = " + id;

        ResultSet rs = dbWorker.executeQuery(sql);

        if (rs.next()) {

            Compra cmp = new Compra(id, loadDog(rs.getInt("dogId")), loadCliente(rs.getInt("clienteId")), rs.getDate("data").toLocalDate(), rs.getFloat("valor"));
            return cmp;
        }
        return null;
    }
    
     public ArrayList<Compra> loadAllCompras() throws SQLException {
        String sql = "SELECT * FROM Compra";

        ResultSet rs = dbWorker.executeQuery(sql);
        ArrayList<Compra> compras = new ArrayList<>();    
        
        while (rs.next()) {

            Compra cmp = new Compra(rs.getInt("id"), loadDog(rs.getInt("dogId")), loadCliente(rs.getInt("clienteId")), rs.getDate("data").toLocalDate(), rs.getFloat("valor"));
            compras.add(cmp);
        }
        return compras;
    }

    public Utilizador loadUtilizador(String username, String password) throws SQLException {
        String sql = "SELECT * FROM Utilizador WHERE username = '" + username + "' AND " + "password = '" + password + "'";

        ResultSet rs = dbWorker.executeQuery(sql);

        if (rs.next()) {

            Utilizador u = new Utilizador(rs.getInt("id"), rs.getString("nome"), rs.getString("username"), rs.getString("password"));
            return u;
        }
        return null;
    }
//------------
    
    public Loja loadLoja() throws SQLException {

        Loja loja = new Loja();

        ArrayList<Cliente> clientes = loadAllClientes();
        for (Cliente cliente : clientes) {
            loja.adicionaCliente(cliente);
        }
        
        
        ArrayList<Dog> dogs = loadAllDogs();
        for (Dog dog : dogs) {
            loja.adicionaDog(dog);
        }
        
        
        ArrayList<Compra> compras = loadAllCompras();
        for (Compra c : compras) {
            loja.adicionaCompra(c);
        }
        
        
      
        
        return loja;
    }
    
//---------------
}
