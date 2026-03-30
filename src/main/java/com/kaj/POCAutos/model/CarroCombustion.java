package com.kaj.POCAutos.model;

public class CarroCombustion extends Carro {
    private Float capacidadTanque;

    public CarroCombustion(String matricula, Integer numeroPuertas, String modelo,
                           String color, String marca,
                           Float capacidadTanque) {
        super(matricula, numeroPuertas, modelo, color, marca);
        this.capacidadTanque = capacidadTanque;
    }

    // Getters y Setters
}