import { Injectable } from '@angular/core';
import { HttpRequest, HttpHandler, HttpEvent, HttpInterceptor } from '@angular/common/http';
import { Observable } from 'rxjs';
import { authService } from '../../services/AuthService';


@Injectable({ providedIn: 'root' })
export class JwtInterceptor implements HttpInterceptor {
  constructor(private authenticationService: authService) { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const user = this.authenticationService.userValue;
    const isApiUrl = request.url.startsWith("https://localhost:7148");
    if (user && isApiUrl) {
      request = request.clone({
        setHeaders: {
          Authorization: `Bearer ${user.token}`,
        }
      });

      if (user.roles) {
        request = request.clone({
          setHeaders: {
            Roles: user.roles
          }
        });
      }
    }

    return next.handle(request);
  }
}
