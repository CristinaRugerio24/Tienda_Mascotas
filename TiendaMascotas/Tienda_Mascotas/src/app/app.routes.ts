import { Routes } from '@angular/router';

export const routes: Routes = [
  {
    path: '',
    redirectTo: '/tienda',
    pathMatch: 'full'
  },
  {
    path: 'tienda',
    loadComponent: () => import('./pages/pagina-principal-tienda/pagina-principal-tienda')
      .then(m => m.PaginaPrincipalTienda)
  },
  {
    path: 'inicio-sesion',
    loadComponent: () => import('./pages/inicio-sesion/inicio-sesion')
      .then(m => m.InicioSesion)
  },
  {
    path: '**',
    redirectTo: '/tienda'
  }
];
