import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [CommonModule],
  template: `
    <footer class="main-footer">
      <div class="container">
        <div class="footer-content">
          <div class="footer-section">
            <h3>🐾 Tienda Mascotas</h3>
            <p>Tu tienda de confianza para el cuidado de tus mascotas.</p>
            <div class="social-links">
              <a href="#" aria-label="Facebook">📘</a>
              <a href="#" aria-label="Instagram">📷</a>
              <a href="#" aria-label="Twitter">🐦</a>
            </div>
          </div>

          <div class="footer-section">
            <h4>Productos</h4>
            <ul>
              <li><a href="#">Alimentos</a></li>
              <li><a href="#">Juguetes</a></li>
              <li><a href="#">Accesorios</a></li>
              <li><a href="#">Cuidado e Higiene</a></li>
            </ul>
          </div>

          <div class="footer-section">
            <h4>Servicios</h4>
            <ul>
              <li><a href="#">Veterinaria</a></li>
              <li><a href="#">Peluquería</a></li>
              <li><a href="#">Guardería</a></li>
              <li><a href="#">Entrenamiento</a></li>
            </ul>
          </div>

          <div class="footer-section">
            <h4>Contacto</h4>
            <div class="contact-info">
              <p>📍 Calle Principal 123</p>
              <p>📞 (555) 123-4567</p>
              <p>📧 info@tiendamascotas.com</p>
            </div>
          </div>
        </div>

        <div class="footer-bottom">
          <p>&copy; {{ currentYear }} Tienda Mascotas. Todos los derechos reservados.</p>
        </div>
      </div>
    </footer>
  `,
  styles: [`
    .main-footer {
      background-color: #2c3e50;
      color: white;
      padding: 2rem 0 1rem;
      margin-top: auto;
    }

    .container {
      max-width: 1200px;
      margin: 0 auto;
      padding: 0 20px;
    }

    .footer-content {
      display: grid;
      grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
      gap: 2rem;
      margin-bottom: 2rem;
    }

    .footer-section h3,
    .footer-section h4 {
      margin: 0 0 1rem 0;
      color: #ecf0f1;
    }

    .footer-section p {
      margin: 0 0 1rem 0;
      line-height: 1.6;
      color: #bdc3c7;
    }

    .footer-section ul {
      list-style: none;
      margin: 0;
      padding: 0;
    }

    .footer-section ul li {
      margin-bottom: 0.5rem;
    }

    .footer-section a {
      color: #bdc3c7;
      text-decoration: none;
      transition: color 0.3s;
    }

    .footer-section a:hover {
      color: #ecf0f1;
    }

    .social-links {
      display: flex;
      gap: 1rem;
      margin-top: 1rem;
    }

    .social-links a {
      font-size: 1.5rem;
      text-decoration: none;
    }

    .contact-info p {
      margin-bottom: 0.5rem;
    }

    .footer-bottom {
      border-top: 1px solid #34495e;
      padding-top: 1rem;
      text-align: center;
    }

    .footer-bottom p {
      margin: 0;
      color: #95a5a6;
      font-size: 0.9rem;
    }

    @media (max-width: 768px) {
      .footer-content {
        grid-template-columns: 1fr;
        gap: 1.5rem;
      }
    }
  `]
})
export class FooterComponent {
  currentYear = new Date().getFullYear();
}