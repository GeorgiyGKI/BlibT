import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { User } from '../shared/models/User';
import { USER_LOGIN_URL, USER_REGISTER_URL } from '../shared/constants/urls';


@Injectable({ providedIn: 'root' })
export class authService {
  private userSubject: BehaviorSubject<User | null>;
  public user: Observable<User | null>;

  constructor(
    private router: Router,
    private http: HttpClient
  ) {
    this.userSubject = new BehaviorSubject(JSON.parse(localStorage.getItem('user')!));
    this.user = this.userSubject.asObservable();
  }

  public get userValue() {
    return this.userSubject.value;
  }

  login(email: string, password: string) {
    return this.http.post<any>(USER_LOGIN_URL, { email, password })
      .pipe(map(user => {
        localStorage.setItem('user', JSON.stringify(user));
        this.userSubject.next(user);
        return user;
      }));
  }

  registration(email: string, password: string, name: string) {
    let data = {
      name,
      email,
      password,
      roles: []
    }

    return this.http.post<any>(USER_REGISTER_URL, data);
  }

  logout() {
    localStorage.removeItem('user');
    this.userSubject.next(null);
  }
}
