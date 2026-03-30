package com.kaj.POCAutos.model;

public class CarroElectrico extends Carro implements IRecargable{
    private Float capacidadBateria;
    private Float tiempoCarga;

    public CarroElectrico(String matricula, Integer numeroPuertas, String modelo,
                          String color, String marca,
                          Float capacidadBateria, Float tiempoCarga) {
        super(matricula, numeroPuertas, modelo, color, marca);
        this.capacidadBateria = capacidadBateria;
        this.tiempoCarga = tiempoCarga;
    }

    @Override
    public void recargar() {
        System.out.println("Recargando batería de " + capacidadBateria + " kWh");
    }

    // Getters y Setters
}
