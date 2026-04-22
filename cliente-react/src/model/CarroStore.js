// Patron OBSERVER: el Store mantiene la lista de carros y notifica a los suscriptores
// cuando hay cambios. La pagina Listar se suscribe para refrescarse automaticamente.
// Tambien es Singleton (una unica instancia exportada).

class CarroStore {
  constructor() {
    this.carros = [];
    this.observers = new Set();
  }

  subscribe(observer) {
    this.observers.add(observer);
    return () => this.observers.delete(observer);
  }

  notify() {
    for (const obs of this.observers) {
      obs(this.carros);
    }
  }

  setCarros(carros) {
    this.carros = carros;
    this.notify();
  }

  getCarros() {
    return this.carros;
  }
}

export default new CarroStore();
