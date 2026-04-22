import { useState } from 'react';
import controller from '../controller/CarroController.js';

// Caso de uso UNICO: Consulta de UN solo carro a partir de criterios (matricula y/o marca).
export default function BuscarPage() {
  const [matricula, setMatricula] = useState('');
  const [marca, setMarca] = useState('');
  const [carro, setCarro] = useState(null);
  const [msg, setMsg] = useState(null);

  const onBuscar = async (e) => {
    e.preventDefault();
    setMsg(null);
    setCarro(null);
    try {
      if (!matricula) {
        setMsg({ type: 'err', text: 'La matricula es obligatoria para la consulta individual' });
        return;
      }
      const c = await controller.buscarPorPlaca(matricula);
      if (!c) {
        setMsg({ type: 'err', text: 'No se encontro un carro con esa matricula' });
        return;
      }
      // segundo criterio opcional: marca
      if (marca && c.marca.toLowerCase() !== marca.toLowerCase()) {
        setMsg({ type: 'err', text: 'El carro existe pero no coincide con la marca indicada' });
        return;
      }
      setCarro(c);
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  return (
    <div className="container">
      <h1>Buscar carro</h1>
      <form onSubmit={onBuscar}>
        <label>Matricula (obligatorio)
          <input value={matricula} onChange={(e) => setMatricula(e.target.value)} required />
        </label>
        <label>Marca (opcional, segundo criterio)
          <input value={marca} onChange={(e) => setMarca(e.target.value)} />
        </label>
        <button type="submit">Buscar</button>
      </form>
      {msg && <div className={`msg ${msg.type}`}>{msg.text}</div>}
      {carro && (
        <div className="card">
          <h3>Resultado</h3>
          <p><b>Matricula:</b> {carro.matricula}</p>
          <p><b>Marca:</b> {carro.marca}</p>
          <p><b>Color:</b> {carro.color}</p>
          <p><b>Numero de puertas:</b> {carro.numeroPuertas}</p>
          <p><b>Precio:</b> {carro.precio}</p>
          <p><b>Fecha de registro:</b> {carro.fechaRegistro}</p>
          <p><b>Activo:</b> {carro.activo ? 'Si' : 'No'}</p>
        </div>
      )}
    </div>
  );
}
