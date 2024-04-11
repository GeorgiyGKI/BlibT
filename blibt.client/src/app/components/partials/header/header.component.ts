import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { authService } from '../../../services/AuthService';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {
  constructor(private router: Router,
  private authService: authService) { }

  isOnAdminPanel(): boolean {
    return this.router.url.startsWith('/admin');
  }

  logout(): void {
    this.authService.logout();
    window.location.reload();
  }
}
