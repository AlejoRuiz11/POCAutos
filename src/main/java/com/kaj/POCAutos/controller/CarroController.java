package com.kaj.POCAutos.controller;

import com.kaj.POCAutos.model.Carro;
import com.kaj.POCAutos.service.ICarroService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/carros")
public class CarroController {

    @Autowired
    private ICarroService carroService;


    // Insertar - 20%
    @PostMapping
    public ResponseEntity<String> agregarCarro(@RequestBody Carro carro) {
        carroService.agregarCarro(carro);
        return ResponseEntity.status(HttpStatus.CREATED).body("Carro agregado exitosamente");
    }

    // Listar todos - 25%
    @GetMapping
    public ResponseEntity<List<Carro>> listarCarros() {
        return ResponseEntity.ok(carroService.listarCarros());
    }

    // Listar con filtro por marca y color - 25%
    @GetMapping("/filtro")
    public ResponseEntity<List<Carro>> listarPorFiltro(
            @RequestParam(required = false) String marca,
            @RequestParam(required = false) String color) {
        return ResponseEntity.ok(carroService.listarPorFiltro(marca, color));
    }

    // Consulta individual por placa - 15%
    @GetMapping("/{placa}")
    public ResponseEntity<?> buscarPorPlaca(@PathVariable String placa) {
        Carro carro = carroService.buscarPorPlaca(placa);
        if (carro != null) {
            return ResponseEntity.ok(carro);
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado");
    }

    // Eliminar - 20% (el service ya busca primero internamente)
    @DeleteMapping("/{placa}")
    public ResponseEntity<String> eliminarCarro(@PathVariable String placa) {
        boolean eliminado = carroService.eliminarCarro(placa);
        if (eliminado) {
            return ResponseEntity.ok("Carro eliminado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado");
    }

    // Actualizar - 20% (el service ya busca primero internamente)
    @PutMapping("/{placa}")
    public ResponseEntity<String> actualizarCarro(@PathVariable String placa, @RequestBody Carro carroNuevo) {
        boolean actualizado = carroService.actualizarCarro(placa, carroNuevo);
        if (actualizado) {
            return ResponseEntity.ok("Carro actualizado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado");
    }
}