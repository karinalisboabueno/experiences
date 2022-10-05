/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package business;

import java.util.ArrayList;

/**
 *
 * @author ruiboticas
 */
public class Loja {
    private ArrayList<Cliente> clientes;
    private ArrayList<Dog> dogs;
    private ArrayList<Compra> compras;

    public Loja() {
        this.clientes = new ArrayList<>();
        this.dogs = new ArrayList<>();
        this.compras = new ArrayList<>();
    }
    
    public boolean existeCliente(int id){
        for (Cliente cliente : clientes) {
            if(cliente.getId() == id){
                return true;
            }
        }
        return false;
    }
    
    public boolean existeCliente(Cliente cl){
        return existeCliente(cl.getId());
    }
    
    public boolean existeDog(int id){
        for (Dog dog : dogs) {
            if(dog.getId() == id){
                return true;
            }
        }
        return false;
    }
    
    public boolean existeDog(Dog d){
        return existeDog(d.getId());
    }
    
    public Cliente getCliente(int id){
        for (Cliente cliente : clientes) {
            if(cliente.getId() == id){
                return cliente;
            }
        }
        return null;
    }
    
    public Dog getDog(int id){
        for (Dog dog : dogs) {
            if(dog.getId() == id){
                return dog;
            }
        }
        return null;
    }
    
    public Compra getCompra(int id){
        for (Compra compra : compras) {
            if(compra.getId() == id){
                return compra;
            }
        }
        return null;
    }

    public ArrayList<Cliente> getClientes() {
        return clientes;
    }

    public ArrayList<Dog> getDogs() {
        return dogs;
    }

    public ArrayList<Compra> getCompras() {
        return compras;
    }
    
    public void setCliente(int pos, Cliente cl){
        clientes.set(pos, cl);
    }
    
    public void setDog(int pos, Dog d){
        dogs.set(pos, d);
    }
    
    public void setCompra(int pos, Compra cp){
        compras.set(pos, cp);
    }
    
    public void adicionaCompra(Compra c){
        compras.add(c);
        c.getDog().setVendido(true);
    }
    
    public void adicionaCliente(Cliente cl){
        clientes.add(cl);
    }
    
    public void adicionaDog(Dog d){
        dogs.add(d);
    }
    
    public void removeCliente(int id){
        for (int i = 0; i < clientes.size(); i++) {
            if(clientes.get(i).getId() == id) {
                clientes.remove(i);
            }
        }
    }
    
    public void removeCliente(Cliente cl){
        removeCliente(cl.getId());
    }
    
    public void removeDog(int id){
        for (int i = 0; i < dogs.size(); i++) {
            if(dogs.get(i).getId() == id){
                dogs.remove(i);
            }
        }
    }
    
    public void removeDog(Dog d){
        removeDog(d.getId());
    }
    
    public void removeCompra(int id){
        for (int i = 0; i < compras.size(); i++) {
            if(compras.get(i).getId() == id){
                compras.get(i).getDog().setVendido(false);
                compras.remove(i);
            }
        }
    }
    
    public void removeCompra(Compra cp){
        removeCompra(cp.getId());
    }
    
    public float getTotalArrecadado(){
        float total = 0.0f;
        
        for (Compra compra : compras) {
            total += compra.getValor();
        }
        
        return total;
    }
    
    public ArrayList<Dog> getDogsDisponiveis(){
        ArrayList<Dog> dogsDisponiveis = new ArrayList<>();
        
        for (Dog dog : dogs) {
            if(!dog.isVendido()){
                dogsDisponiveis.add(dog);
            }
        }
        
        return dogsDisponiveis;
    }
    
    
    
}
