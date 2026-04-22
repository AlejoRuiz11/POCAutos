import { useState } from 'react';
import controller from '../controller/CarroController.js';

// Caso de uso UNICO: Actualizar carro.
// Requiere busqueda previa y mostrar TODA la informacion antes de actualizar.
export default function ActualizarPage() {
  const [matricula, setMatricula] = useState('');
  const [carro, setCarro] = useState(null);
  const [form, setForm] = useState(null);
  const [msg, setMsg] = useState(null);

  const onBuscar = async (e) => {
    e.preventDefault();
    setMsg(null);
    setCarro(null);
    setForm(null);
    try {
      const c = await controller.buscarPorPlaca(matricula);
      if (!c) {
        setMsg({ type: 'err', text: 'No se encontro un carro con esa matricula' });
        return;
      }
      setCarro(c);
      setForm({
        numeroPuertas: c.numeroPuertas,
        marca: c.marca,
        precio: c.precio,
        color: c.color,
      });
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  const onChange = (e) => setForm({ ...form, [e.target.name]: e.target.value });

  const onActualizar = async (e) => {
    e.preventDefault();
    setMsg(null);
    try {
      const carroActualizado = {
        matricula: carro.matricula,
        numeroPuertas: parseInt(form.numeroPuertas, 10),
        marca: form.marca,
        precio: parseFloat(form.precio),
        color: form.color,
        fechaRegistro: carro.fechaRegistro,
      };
      const res = await controller.actualizar(carro.matricula, carroActualizado);
      setMsg({ type: 'ok', text: res });
      setCarro(null);
      setForm(null);
      setMatricula('');
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  return (
    <div className="container">
      <h1>Actualizar carro</h1>
      <form onSubmit={onBuscar}>
        <label>Matricula del carro a actualizar
          <input value={matricula} onChange={(e) => setMatricula(e.target.value)} required />
        </label>
        <button type="submit">Buscar</button>
      </form>
      {msg && <div className={`msg ${msg.type}`}>{msg.text}</div>}
      {carro && form && (
        <div className="card">
          <h3>Informacion actual</h3>
          <p><b>Matricula:</b> {carro.matricula}</p>
          <p><b>Marca:</b> {carro.marca}</p>
          <p><b>Color:</b> {carro.color}</p>
          <p><b>Numero de puertas:</b> {carro.numeroPuertas}</p>
          <p><b>Precio:</b> {carro.precio}</p>
          <p><b>Fecha de registro:</b> {carro.fechaRegistro}</p>

          <h3 style={{ marginTop: 16 }}>Nuevos datos</h3>
          <form onSubmit={onActualizar}>
            <label>Marca
              <input name="marca" value={form.marca} onChange={onChange} required />
            </label>
            <label>Color
              <input name="color" value={form.color} onChange={onChange} required />
            </label>
            <label>Numero de puertas
              <input name="numeroPuertas" type="number" min="1" value={form.numeroPuertas} onChange={onChange} required />
            </label>
            <label>Precio
              <input name="precio" type="number" step="0.01" min="0" value={form.precio} onChange={onChange} required />
            </label>
            <button type="submit">Actualizar</button>
          </form>
        </div>
      )}
    </div>
  );
}
