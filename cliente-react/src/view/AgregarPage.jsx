import { useState } from 'react';
import controller from '../controller/CarroController.js';

// Caso de uso UNICO: Agregar carro.
export default function AgregarPage() {
  const [form, setForm] = useState({
    matricula: '',
    numeroPuertas: '',
    marca: '',
    precio: '',
    color: '',
  });
  const [msg, setMsg] = useState(null);

  const onChange = (e) => setForm({ ...form, [e.target.name]: e.target.value });

  const onSubmit = async (e) => {
    e.preventDefault();
    setMsg(null);
    try {
      const carro = {
        matricula: form.matricula,
        numeroPuertas: parseInt(form.numeroPuertas, 10),
        marca: form.marca,
        precio: parseFloat(form.precio),
        color: form.color,
        fechaRegistro: new Date().toISOString().split('.')[0], // yyyy-MM-ddTHH:mm:ss
      };
      const res = await controller.agregar(carro);
      setMsg({ type: 'ok', text: res });
      setForm({ matricula: '', numeroPuertas: '', marca: '', precio: '', color: '' });
    } catch (err) {
      setMsg({ type: 'err', text: err.message });
    }
  };

  return (
    <div className="container">
      <h1>Agregar carro</h1>
      <form onSubmit={onSubmit}>
        <label>Matricula
          <input name="matricula" value={form.matricula} onChange={onChange} required />
        </label>
        <label>Numero de puertas
          <input name="numeroPuertas" type="number" min="1" value={form.numeroPuertas} onChange={onChange} required />
        </label>
        <label>Marca
          <input name="marca" value={form.marca} onChange={onChange} required />
        </label>
        <label>Precio
          <input name="precio" type="number" step="0.01" min="0" value={form.precio} onChange={onChange} required />
        </label>
        <label>Color
          <input name="color" value={form.color} onChange={onChange} required />
        </label>
        <button type="submit">Agregar</button>
      </form>
      {msg && <div className={`msg ${msg.type}`}>{msg.text}</div>}
    </div>
  );
}
