import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { authService } from '../../../services/AuthService';
import { first } from 'rxjs';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent {
  loginForm: FormGroup;

  isLoggedIn = false;
  isLoginFailed = false;
  errorMessage = '';
  roles: string[] = []
  constructor(private fb: FormBuilder,
    private authService: authService,
    private router: Router) {
    this.loginForm = this.fb.group({
      email: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  
  onSubmit() {
    const formVal = this.loginForm.value;

    this.authService.login(formVal.email, formVal.password).subscribe({
      next: (val: any) => {
        const user = localStorage.getItem('user');
        if (!user) {
          alert('Authentication error. Please try again.');
          return;
        }
        //добавь роутер на home-page
      },
      error: (err: any) => {
        console.error(err);
      },
    });
  }

   

  reloadPage(): void {
    window.location.reload();
  }
}
