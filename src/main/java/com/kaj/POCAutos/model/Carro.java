package com.kaj.POCAutos.model;
import com.fasterxml.jackson.annotation.JsonSubTypes;
import com.fasterxml.jackson.annotation.JsonTypeInfo;

@JsonTypeInfo(use = JsonTypeInfo.Id.NAME, property = "tipo")
@JsonSubTypes({
        @JsonSubTypes.Type(value = CarroCombustion.class, name = "combustion"),
        @JsonSubTypes.Type(value = CarroElectrico.class, name = "electrico")
})
public abstract class Carro {
    private String matricula;
    private Integer numeroPuertas;
    private String modelo;
    private String color;
    private String marca;

    public Carro(String matricula, Integer numeroPuertas, String modelo, String color, String marca) {
        this.matricula = matricula;
        this.numeroPuertas = numeroPuertas;
        this.modelo = modelo;
        this.color = color;
        this.marca = marca;
    }

    // Getters y Setters

    public String getMatricula() { return matricula; }
    public void setMatricula(String matricula) { this.matricula = matricula; }

    public Integer getNumeroPuertas() { return numeroPuertas; }
    public void setNumeroPuertas(Integer numeroPuertas) { this.numeroPuertas = numeroPuertas; }

    public String getModelo() { return modelo; }
    public void setModelo(String modelo) { this.modelo = modelo; }

    public String getColor() { return color; }
    public void setColor(String color) { this.color = color; }

    public String getMarca() { return marca; }
    public void setMarca(String marca) { this.marca = marca; }
}