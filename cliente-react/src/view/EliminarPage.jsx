import { useState } from 'react';
import controller from '../controller/CarroController.js';

// Caso de uso UNICO: Eliminar carro.
// Requiere busqueda previa y mostrar TODA la informacion antes de eliminar.
export default function EliminarPage() {
  const [matricula, setMatricula] = useState('');
  const [carro, setCarro] = useState(null);
  const [msg, setMsg] = useState(null);

  const onBuscar = async (e) => {
    e.preventDefault();
    setMsg(null);
    setCarro(null);
    try {
      const c = await controller.buscarPorPlaca(matricula);
      if (!c) {
        setMsg({ type: 'err', text: 'No se encontro un carro con esa matricula' });
        return;
      }
      setCarro(c);
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  const onEliminar = async () => {
    if (!confirm(`Seguro que desea eliminar el carro ${carro.matricula}?`)) return;
    try {
      const res = await controller.eliminar(carro.matricula);
      setMsg({ type: 'ok', text: res });
      setCarro(null);
      setMatricula('');
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  return (
    <div className="container">
      <h1>Eliminar carro</h1>
      <form onSubmit={onBuscar}>
        <label>Matricula a eliminar
          <input value={matricula} onChange={(e) => setMatricula(e.target.value)} required />
        </label>
        <button type="submit">Buscar</button>
      </form>
      {msg && <div className={`msg ${msg.type}`}>{msg.text}</div>}
      {carro && (
        <div className="card">
          <h3>Informacion del carro a eliminar</h3>
          <p><b>Matricula:</b> {carro.matricula}</p>
          <p><b>Marca:</b> {carro.marca}</p>
          <p><b>Color:</b> {carro.color}</p>
          <p><b>Numero de puertas:</b> {carro.numeroPuertas}</p>
          <p><b>Precio:</b> {carro.precio}</p>
          <p><b>Fecha de registro:</b> {carro.fechaRegistro}</p>
          <p><b>Activo:</b> {carro.activo ? 'Si' : 'No'}</p>
          <button className="danger" onClick={onEliminar}>Confirmar eliminacion</button>
        </div>
      )}
    </div>
  );
}
