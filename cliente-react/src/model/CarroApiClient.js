// Patron SINGLETON: una sola instancia para hablar con el servidor REST.
// El proxy de Vite redirige /api -> http://localhost:31230

class CarroApiClient {
  constructor() {
    if (CarroApiClient._instance) {
      return CarroApiClient._instance;
    }
    this.baseUrl = '/api/carros';
    CarroApiClient._instance = this;
  }

  static getInstance() {
    if (!CarroApiClient._instance) {
      CarroApiClient._instance = new CarroApiClient();
    }
    return CarroApiClient._instance;
  }

  async listar() {
    const res = await fetch(this.baseUrl);
    if (!res.ok) throw new Error('Error al listar carros');
    return res.json();
  }

  async listarPorFiltro(marca, color) {
    const params = new URLSearchParams();
    if (marca) params.append('marca', marca);
    if (color) params.append('color', color);
    const res = await fetch(`${this.baseUrl}/filtro?${params.toString()}`);
    if (!res.ok) throw new Error('Error al listar por filtro');
    return res.json();
  }

  async buscarPorPlaca(placa) {
    const res = await fetch(`${this.baseUrl}/${encodeURIComponent(placa)}`);
    if (res.status === 404) return null;
    if (!res.ok) throw new Error('Error al buscar carro');
    return res.json();
  }

  async agregar(carro) {
    const res = await fetch(this.baseUrl, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(carro),
    });
    const text = await res.text();
    if (!res.ok) throw new Error(text || 'Error al agregar carro');
    return text;
  }

  async actualizar(placa, carro) {
    const res = await fetch(`${this.baseUrl}/${encodeURIComponent(placa)}`, {
      method: 'PUT',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(carro),
    });
    const text = await res.text();
    if (!res.ok) throw new Error(text || 'Error al actualizar carro');
    return text;
  }

  async eliminar(placa) {
    const res = await fetch(`${this.baseUrl}/${encodeURIComponent(placa)}`, {
      method: 'DELETE',
    });
    const text = await res.text();
    if (!res.ok) throw new Error(text || 'Error al eliminar carro');
    return text;
  }
}

export default CarroApiClient.getInstance();
