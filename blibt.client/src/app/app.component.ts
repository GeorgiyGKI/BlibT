import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { authService } from './services/AuthService';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {

  constructor(private http: HttpClient) {
    
  }

  ngOnInit() {
   
  }

  title = 'blibt.client';
}
