# Cliente Carros (React + Node.js)

Cliente del segundo proyecto del curso. Consume los servicios REST del servidor
Spring Boot (`POCAutos`) que corre en `http://localhost:31230`.

## Requisitos

- Node.js 18 o superior
- El servidor Spring Boot corriendo en el puerto `31230`

## Instalacion

```bash
cd cliente-react
npm install
```

## Ejecucion

```bash
npm run dev
```

Abre el navegador en `http://localhost:5173`.

> Vite usa un proxy: todas las peticiones a `/api/*` se redirigen al servidor
> en `http://localhost:31230` (configurado en `vite.config.js`). Esto evita
> problemas de CORS sin tocar el servidor.

## Estructura (MVC)

```
src/
  model/
    CarroApiClient.js   <- Singleton, hace fetch al backend
    CarroStore.js       <- Observer, notifica a las vistas suscritas
  controller/
    CarroController.js  <- Coordina vistas y modelo
  view/
    MainPage.jsx        <- Menu principal
    AgregarPage.jsx     <- Caso de uso: Agregar
    BuscarPage.jsx      <- Caso de uso: Consultar uno (1-2 criterios)
    ListarPage.jsx      <- Caso de uso: Listar + filtro (usa Observer)
    ActualizarPage.jsx  <- Caso de uso: Actualizar (con busqueda previa)
    EliminarPage.jsx    <- Caso de uso: Eliminar (con busqueda previa)
    AcercaDePage.jsx    <- Ayuda > Acerca de...
  App.jsx               <- Router + menu superior
  main.jsx              <- Entrada
```

## Patrones aplicados

- **MVC**: separacion clara entre `model/`, `view/` y `controller/`.
- **Singleton**: `CarroApiClient` y `CarroStore` exportan una unica instancia.
- **Observer**: `ListarPage` se suscribe al `CarroStore` y se refresca solo
  cuando otra operacion (agregar, actualizar, eliminar) cambia los datos.
