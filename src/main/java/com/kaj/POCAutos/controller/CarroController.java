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



    @PostMapping
    public ResponseEntity<String> agregarCarro(@RequestBody Carro carro) {
        boolean agregado = carroService.agregarCarro(carro);
        if (agregado) {
            return ResponseEntity.status(HttpStatus.CREATED).body("Carro agregado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.CONFLICT).body("Ya existe un carro con esa placa");
    }


    @GetMapping
    public ResponseEntity<List<Carro>> listarCarros() {
        return ResponseEntity.ok(carroService.listarCarros());
    }


    @GetMapping("/filtro")
    public ResponseEntity<List<Carro>> listarPorFiltro(
            @RequestParam(required = false) String marca,
            @RequestParam(required = false) String color) {
        return ResponseEntity.ok(carroService.listarPorFiltro(marca, color));
    }


    @GetMapping("/{placa}")
    public ResponseEntity<?> buscarPorPlaca(@PathVariable String placa) {
        Carro carro = carroService.buscarPorPlaca(placa);
        if (carro != null) {
            return ResponseEntity.ok(carro);
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado");
    }


    @DeleteMapping("/{placa}")
    public ResponseEntity<String> eliminarCarro(@PathVariable String placa) {
        boolean eliminado = carroService.eliminarCarro(placa);
        if (eliminado) {
            return ResponseEntity.ok("Carro inactivado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado o ya se encuentra inactivo");
    }

    @PatchMapping("/{placa}/activar")
    public ResponseEntity<String> reactivarCarro(@PathVariable String placa) {
        boolean reactivado = carroService.reactivarCarro(placa);
        if (reactivado) {
            return ResponseEntity.ok("Carro reactivado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado o ya se encuentra activo");
    }


    @PutMapping("/{placa}")
    public ResponseEntity<String> actualizarCarro(@PathVariable String placa, @RequestBody Carro carroNuevo) {
        boolean actualizado = carroService.actualizarCarro(placa, carroNuevo);
        if (actualizado) {
            return ResponseEntity.ok("Carro actualizado exitosamente");
        }
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body("Carro no encontrado");
    }
}