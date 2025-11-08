import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, RouterModule],
  template: `
    <header class="main-header">
      <div class="container">
        <div class="logo">
          <h1>🐾 Tienda Mascotas</h1>
        </div>
        
        <nav class="main-nav">
          <ul>
            <li><a routerLink="/" routerLinkActive="active" [routerLinkActiveOptions]="{exact: true}">Inicio</a></li>
            <li><a routerLink="/productos" routerLinkActive="active">Productos</a></li>
            <li><a routerLink="/mascotas" routerLinkActive="active">Mascotas</a></li>
            <li><a routerLink="/servicios" routerLinkActive="active">Servicios</a></li>
            <li><a routerLink="/contacto" routerLinkActive="active">Contacto</a></li>
          </ul>
        </nav>

        <div class="header-actions">
          <button class="btn-cart">
            🛒 Carrito (0)
          </button>
        </div>
      </div>
    </header>
  `,
  styles: [`
    .main-header {
      background-color: #2c3e50;
      color: white;
      padding: 1rem 0;
      box-shadow: 0 2px 4px rgba(0,0,0,0.1);
    }

    .container {
      max-width: 1200px;
      margin: 0 auto;
      padding: 0 20px;
      display: flex;
      justify-content: space-between;
      align-items: center;
    }

    .logo h1 {
      margin: 0;
      font-size: 1.5rem;
      font-weight: 600;
    }

    .main-nav ul {
      list-style: none;
      margin: 0;
      padding: 0;
      display: flex;
      gap: 2rem;
    }

    .main-nav a {
      color: white;
      text-decoration: none;
      padding: 0.5rem 1rem;
      border-radius: 4px;
      transition: background-color 0.3s;
    }

    .main-nav a:hover,
    .main-nav a.active {
      background-color: #34495e;
    }

    .btn-cart {
      background-color: #e74c3c;
      color: white;
      border: none;
      padding: 0.5rem 1rem;
      border-radius: 4px;
      cursor: pointer;
      font-size: 0.9rem;
    }

    .btn-cart:hover {
      background-color: #c0392b;
    }

    @media (max-width: 768px) {
      .container {
        flex-direction: column;
        gap: 1rem;
      }

      .main-nav ul {
        flex-wrap: wrap;
        justify-content: center;
        gap: 1rem;
      }
    }
  `]
})
export class HeaderComponent {}