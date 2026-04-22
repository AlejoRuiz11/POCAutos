// Controlador (MVC): media entre las vistas y el modelo.
// Las vistas no llaman directo al ApiClient: usan este controlador.
// Despues de cada operacion que modifique datos refresca el Store (Observer).

import api from '../model/CarroApiClient.js';
import store from '../model/CarroStore.js';

const CarroController = {
  async refrescarLista() {
    const carros = await api.listar();
    store.setCarros(carros);
    return carros;
  },

  async listarPorFiltro(marca, color) {
    const carros = await api.listarPorFiltro(marca, color);
    store.setCarros(carros);
    return carros;
  },

  buscarPorPlaca(placa) {
    return api.buscarPorPlaca(placa);
  },

  async agregar(carro) {
    const msg = await api.agregar(carro);
    await this.refrescarLista();
    return msg;
  },

  async actualizar(placa, carro) {
    const msg = await api.actualizar(placa, carro);
    await this.refrescarLista();
    return msg;
  },

  async eliminar(placa) {
    const msg = await api.eliminar(placa);
    await this.refrescarLista();
    return msg;
  },
};

export default CarroController;
