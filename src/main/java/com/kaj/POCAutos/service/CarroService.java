package com.kaj.POCAutos.service;

import com.kaj.POCAutos.model.Carro;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

@Service
public class CarroService implements ICarroService {

    private List<Carro> carros = new ArrayList<>();
    public static CarroService carroService;

    private CarroService(){}

    public static CarroService GetInstance()
    {
        if(carroService==null)
        {
            carroService = new CarroService();
        }
        return carroService;
    }

    @Override
    public boolean agregarCarro(Carro carro) {
        Carro existente = buscarPorPlaca(carro.getMatricula());
        if (existente != null) {
            return false;
        }
        carros.add(carro);
        return true;
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
        Carro carrito = buscarPorPlaca(placa);
        if(carrito != null)
        {
            carros.remove(carrito);
            return true;
        }
        return false;
    }

    @Override
    public boolean actualizarCarro(String placa, Carro carroNuevo) {
        Carro carrito = buscarPorPlaca(placa);
        if (carrito != null) {
            int index = carros.indexOf(carrito);
            carros.set(index, carroNuevo);
            return true;
        }
        return false;
    }

    @Override
    public List<Carro> listarPorFiltro(String marca, String color) {
        return carros.stream()
                .filter(c -> marca == null || c.getMarca().equalsIgnoreCase(marca))
                .filter(c -> color == null || c.getColor().equalsIgnoreCase(color))
                .collect(Collectors.toList());
    }

}

