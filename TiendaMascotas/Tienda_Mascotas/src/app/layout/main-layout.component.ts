import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-main-layout',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  template: `
    <div class="app-layout">
      <!-- Header se importará aquí -->
      <div class="header-placeholder">
        <p>Header Component</p>
      </div>
      
      <main class="main-content">
        <router-outlet></router-outlet>
      </main>
      
      <!-- Footer se importará aquí -->
      <div class="footer-placeholder">
        <p>Footer Component</p>
      </div>
    </div>
  `,
  styles: [`
    .app-layout {
      min-height: 100vh;
      display: flex;
      flex-direction: column;
    }

    .header-placeholder,
    .footer-placeholder {
      background-color: #f0f0f0;
      padding: 20px;
      text-align: center;
      border: 2px dashed #ccc;
    }

    .main-content {
      flex: 1;
      min-height: calc(100vh - 200px);
    }
  `]
})
export class MainLayoutComponent {}