import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { authService } from '../../../services/AuthService';

@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrl: './register-page.component.css'
})
export class RegisterPageComponent {
  regForm: FormGroup;
  constructor(private fb: FormBuilder,
    private authService: authService,
    private router: Router) {
    this.regForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  registration() {
    const formVal = this.regForm.value;
    this.authService.registration(formVal.email, formVal.password, formVal.name).subscribe(
      () => {
        console.log("User is logged in");
        this.router.navigateByUrl('/');
      }
    )
  }
}
