import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';

// Proxy hacia el servidor Spring Boot (puerto 31230) para evitar problemas de CORS.
export default defineConfig({
  plugins: [react()],
  server: {
    port: 5173,
    proxy: {
      '/api': {
        target: 'http://localhost:31230',
        changeOrigin: true,
        rewrite: (path) => path.replace(/^\/api/, ''),
      },
    },
  },
});
