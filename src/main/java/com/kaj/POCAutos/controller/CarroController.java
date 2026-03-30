package com.kaj.POCAutos.controller;

import com.kaj.POCAutos.model.Carro;
import com.kaj.POCAutos.service.ICarroService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/carros")
public class CarroController {

    @Autowired
    private ICarroService carroService;

    // Recibe el POST -> le pasa el trabajo al service -> responde
    @PostMapping
    public String agregar(@RequestBody Carro carro) {
        carroService.agregarCarro(carro);
        return "Carro agregado";
    }

    // Recibe el GET -> pide la lista al service -> la devuelve
    @GetMapping
    public List<Carro> listar() {
        return carroService.listarCarros();
    }
}