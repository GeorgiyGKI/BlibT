import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { authService } from '../../services/AuthService';

@Injectable({
  providedIn: 'root'
})
export class RoleGuard implements CanActivate {

  constructor(private authenticationService: authService, private router: Router) { }

  canActivate(
    next: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {

    let url: string = state.url;
    return this.checkUserLogin(next, url);
  }

  checkUserLogin(route: ActivatedRouteSnapshot, url: any): boolean {
    const user = this.authenticationService.userValue;
    let authRole: string[] = route.data['role'];
    if (user && user.roles) {
      for (var i = 0; i < authRole.length; i++) {
        if (user.roles.includes(authRole[i])) {
          return true;
        }
      }
    }

    this.router.navigate(['/']);
    return false;
  }
}
