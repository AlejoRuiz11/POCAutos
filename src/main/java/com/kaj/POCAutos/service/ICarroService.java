package com.kaj.POCAutos.service;

import com.kaj.POCAutos.model.Carro;

import java.util.List;

public interface ICarroService {

    public void agregarCarro(Carro carro);
    public List<Carro> listarCarros();
    public Carro buscarPorPlaca(String placa);
    public boolean eliminarCarro(String placa);
    public double calcularValorTotal();

}
