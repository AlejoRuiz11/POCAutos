import { useEffect, useState } from 'react';
import controller from '../controller/CarroController.js';
import store from '../model/CarroStore.js';

// Caso de uso UNICO: Listar carros (con filtro opcional por un parametro: marca).
// Implementa el patron OBSERVER: se suscribe al CarroStore y se actualiza
// automaticamente cuando otro caso de uso modifica los datos.
export default function ListarPage() {
  const [carros, setCarros] = useState(store.getCarros());
  const [marca, setMarca] = useState('');
  const [msg, setMsg] = useState(null);

  useEffect(() => {
    // Observer: se suscribe al store
    const unsubscribe = store.subscribe((nuevos) => setCarros([...nuevos]));
    // Carga inicial
    controller.refrescarLista().catch((err) => setMsg({ type: 'err', text: err.message }));
    return unsubscribe;
  }, []);

  const onFiltrar = async (e) => {
    e.preventDefault();
    setMsg(null);
    try {
      await controller.listarPorFiltro(marca, '');
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  const onLimpiar = async () => {
    setMarca('');
    await controller.refrescarLista();
  };

  return (
    <div className="container">
      <h1>Listar carros</h1>
      <form onSubmit={onFiltrar} style={{ flexDirection: 'row', alignItems: 'flex-end', gap: 8 }}>
        <label>Filtrar por marca
          <input value={marca} onChange={(e) => setMarca(e.target.value)} placeholder="Ej: Mazda" />
        </label>
        <button type="submit">Filtrar</button>
        <button type="button" onClick={onLimpiar}>Limpiar</button>
      </form>
      {msg && <div className={`msg ${msg.type}`}>{msg.text}</div>}
      <table>
        <thead>
          <tr>
            <th>Matricula</th><th>Marca</th><th>Color</th><th>Puertas</th><th>Precio</th><th>Fecha registro</th>
          </tr>
        </thead>
        <tbody>
          {carros.length === 0 ? (
            <tr><td colSpan="6">Sin registros</td></tr>
          ) : (
            carros.map((c) => (
              <tr key={c.matricula}>
                <td>{c.matricula}</td>
                <td>{c.marca}</td>
                <td>{c.color}</td>
                <td>{c.numeroPuertas}</td>
                <td>{c.precio}</td>
                <td>{c.fechaRegistro}</td>
              </tr>
            ))
          )}
        </tbody>
      </table>
    </div>
  );
}
