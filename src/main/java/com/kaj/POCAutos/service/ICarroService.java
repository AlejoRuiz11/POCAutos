package com.kaj.POCAutos.service;

import com.kaj.POCAutos.model.Carro;

import java.util.List;

public interface ICarroService {

    public boolean agregarCarro(Carro carro);
    public List<Carro> listarCarros();
    public Carro buscarPorPlaca(String placa);
    public boolean eliminarCarro(String placa);
    public boolean actualizarCarro(String placa, Carro carro);
    public List<Carro> listarPorFiltro(String marca, String color);

}
