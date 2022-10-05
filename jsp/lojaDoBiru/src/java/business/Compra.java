/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package business;

import java.time.LocalDate;
import java.util.Date;

/**
 *
 * @author ruiboticas
 */
public class Compra {
    private int id;
    private Dog dog;
    private Cliente cliente;
    private LocalDate data;
    private float valor;

    public Compra(int id, Dog dog, Cliente cliente, LocalDate data, float valor) {
        this.id = id;
        this.dog = dog;
        this.cliente = cliente;
        this.data = data;
        this.valor = valor;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Dog getDog() {
        return dog;
    }

    public void setDog(Dog dog) {
        this.dog = dog;
    }

    public Cliente getCliente() {
        return cliente;
    }

    public void setCliente(Cliente cliente) {
        this.cliente = cliente;
    }

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }

    public float getValor() {
        return valor;
    }

    public void setValor(float valor) {
        this.valor = valor;
    }

    @Override
    public String toString() {
        return "Compra{" + "id=" + id + ", dog=" + dog + ", cliente=" + cliente + ", data=" + data + ", valor=" + valor + '}';
    }
    
    
}
