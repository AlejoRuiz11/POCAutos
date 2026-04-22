import { Routes, Route, Link } from 'react-router-dom';
import MainPage from './view/MainPage.jsx';
import AgregarPage from './view/AgregarPage.jsx';
import BuscarPage from './view/BuscarPage.jsx';
import ListarPage from './view/ListarPage.jsx';
import EliminarPage from './view/EliminarPage.jsx';
import ActualizarPage from './view/ActualizarPage.jsx';
import AcercaDePage from './view/AcercaDePage.jsx';

// Menu principal de la aplicacion (equivalente al menu de la ventana principal).
export default function App() {
  return (
    <>
      <nav>
        <Link to="/">Inicio</Link>
        <Link to="/agregar">Agregar</Link>
        <Link to="/buscar">Buscar</Link>
        <Link to="/listar">Listar</Link>
        <Link to="/actualizar">Actualizar</Link>
        <Link to="/eliminar">Eliminar</Link>
        <span className="spacer" />
        <Link to="/acerca-de">Ayuda - Acerca de...</Link>
      </nav>
      <Routes>
        <Route path="/" element={<MainPage />} />
        <Route path="/agregar" element={<AgregarPage />} />
        <Route path="/buscar" element={<BuscarPage />} />
        <Route path="/listar" element={<ListarPage />} />
        <Route path="/actualizar" element={<ActualizarPage />} />
        <Route path="/eliminar" element={<EliminarPage />} />
        <Route path="/acerca-de" element={<AcercaDePage />} />
      </Routes>
    </>
  );
}
