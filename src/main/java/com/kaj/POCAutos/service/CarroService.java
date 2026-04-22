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
        // Verifica si ya existe un carro con esa placa (activo o inactivo)
        Carro existente = carros.stream()
                .filter(c -> c.getMatricula().equals(carro.getMatricula()))
                .findFirst()
                .orElse(null);
        if (existente != null) {
            return false;
        }
        carro.setActivo(true);
        carros.add(carro);
        return true;
    }

    @Override
    public List<Carro> listarCarros() {
        // Solo retorna los carros activos
        return carros.stream()
                .filter(Carro::isActivo)
                .collect(Collectors.toList());
    }

    @Override
    public Carro buscarPorPlaca(String placa) {
        // Solo busca entre los carros activos
        return carros.stream()
                .filter(c -> c.getMatricula().equals(placa) && c.isActivo())
                .findFirst()
                .orElse(null);
    }

    @Override
    public boolean eliminarCarro(String placa) {
        // Eliminado lógico: cambia el estado a inactivo en vez de borrar
        Carro carrito = buscarPorPlaca(placa);
        if (carrito != null) {
            carrito.setActivo(false);
            return true;
        }
        return false;
    }

    @Override
    public boolean reactivarCarro(String placa) {
        // Reactiva un carro que estaba inactivo
        Carro carrito = carros.stream()
                .filter(c -> c.getMatricula().equals(placa) && !c.isActivo())
                .findFirst()
                .orElse(null);
        if (carrito != null) {
            carrito.setActivo(true);
            return true;
        }
        return false;
    }

    @Override
    public boolean actualizarCarro(String placa, Carro carroNuevo) {
        Carro carrito = buscarPorPlaca(placa);
        if (carrito != null) {
            int index = carros.indexOf(carrito);
            carroNuevo.setActivo(true); // Mantiene activo al actualizar
            carros.set(index, carroNuevo);
            return true;
        }
        return false;
    }

    @Override
    public List<Carro> listarPorFiltro(String marca, String color) {
        // Solo filtra entre los carros activos
        return carros.stream()
                .filter(Carro::isActivo)
                .filter(c -> marca == null || marca.isEmpty() || c.getMarca().equalsIgnoreCase(marca))
                .filter(c -> color == null || color.isEmpty() || c.getColor().equalsIgnoreCase(color))
                .collect(Collectors.toList());
    }

}

