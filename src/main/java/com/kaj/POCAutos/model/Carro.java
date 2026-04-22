package com.kaj.POCAutos.model;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;

import java.time.LocalDateTime;
import com.fasterxml.jackson.annotation.JsonFormat;




public class Carro {
    private String matricula;        // String
    private int numeroPuertas;       // int
    private String marca;            // String
    private double precio;           // double
    private String color;
    @JsonFormat(pattern = "yyyy-MM-dd'T'HH:mm:ss")
    private LocalDateTime fechaRegistro;
    private boolean activo;          // true = activo, false = inactivo (eliminado lógico)

    public Carro(String matricula, int numeroPuertas, String marca, double precio, LocalDateTime fechaRegistro, String color) {
        this.matricula = matricula;
        this.numeroPuertas = numeroPuertas;
        this.marca = marca;
        this.precio = precio;
        this.fechaRegistro = fechaRegistro;
        this.color = color;
        this.activo = true;
    }

    public String getMatricula() { return matricula; }
    public void setMatricula(String matricula) { this.matricula = matricula; }

    public int getNumeroPuertas() { return numeroPuertas; }
    public void setNumeroPuertas(int numeroPuertas) { this.numeroPuertas = numeroPuertas; }

    public String getMarca() { return marca; }
    public void setMarca(String marca) { this.marca = marca; }

    public double getPrecio() { return precio; }
    public void setPrecio(double precio) { this.precio = precio; }

    public LocalDateTime getFechaRegistro() { return fechaRegistro; }
    public void setFechaRegistro(LocalDateTime fechaRegistro) { this.fechaRegistro = fechaRegistro; }

    public String getColor() { return color; }
    public void setColor(String color) { this.color = color; }

    public boolean isActivo() { return activo; }
    public void setActivo(boolean activo) { this.activo = activo; }

}