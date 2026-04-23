// Acerca de... (parte del menu Ayuda).
export default function AcercaDePage() {
  return (
    <div className="container">
      <h1>Acerca de...</h1>
      <div className="card">
        <p><b>Aplicacion:</b> Cliente Carros (React + Node.js)</p>
        <p><b>Version:</b> 1.0.0</p>
        <p><b>Curso:</b> Desarrollo de Aplicaciones Empresariales - Universidad de Ibague</p>
        <p><b>Integrantes del equipo:</b></p>
        <ul>
          <li>Fabian Alejandro Ruiz Osorio</li>
          <li>Kevin Esteban Rodriguez Guijo</li>
          <li>Juan Angel Bocanegra Valencia</li>
        </ul>
      </div>
    </div>
  );
}
