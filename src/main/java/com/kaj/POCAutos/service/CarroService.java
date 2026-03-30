package com.kaj.POCAutos.service;

import com.kaj.POCAutos.model.Carro;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;

@Service
public class CarroService implements ICarroService {

    private List<Carro> carros = new ArrayList<>();

    @Override
    public void agregarCarro(Carro carro) {
        carros.add(carro);
    }

    @Override
    public List<Carro> listarCarros() {
        return carros;
    }

    @Override
    public Carro buscarPorPlaca(String placa) {
        return carros.stream()
                .filter(c -> c.getMatricula().equals(placa))
                .findFirst()
                .orElse(null);
    }

    @Override
    public boolean eliminarCarro(String placa) {
        return carros.removeIf(c -> c.getMatricula().equals(placa));
    }

    @Override
    public double calcularValorTotal() {
        // lógica de negocio, no va en el controller
        return carros.size() * 15000.0;
    }
}

