import { Component } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html'
})
export class BodyComponent {
  currentRoute!: string;

  constructor(private router: Router) {
    this.router.events.pipe(filter((event: any) => event instanceof NavigationEnd)).subscribe((event: NavigationEnd) => {
      this.currentRoute = event.url;
    });
  }
}
