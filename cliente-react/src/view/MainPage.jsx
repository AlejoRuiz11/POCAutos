import { Link } from 'react-router-dom';

// Vista principal: menu de la aplicacion. Cada link lleva a un caso de uso unico.
export default function MainPage() {
  return (
    <div className="container">
      <h1>Gestion de Carros</h1>
      <p>Selecciona una operacion del menu o usa los accesos directos:</p>
      <div className="menu-grid">
        <Link to="/agregar">Agregar carro</Link>
        <Link to="/buscar">Buscar carro</Link>
        <Link to="/listar">Listar carros</Link>
        <Link to="/actualizar">Actualizar carro</Link>
        <Link to="/eliminar">Eliminar carro</Link>
        <Link to="/acerca-de">Acerca de...</Link>
      </div>
    </div>
  );
}
