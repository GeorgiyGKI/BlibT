import { Component} from '@angular/core';
import { User } from '../../../shared/models/User';
import { authService } from '../../../services/AuthService';
import { Observable } from 'rxjs';
import { UserService } from '../../../services/UserService';
import { Book } from '../../../shared/models/Book';
import { RESOURCES } from '../../../shared/constants/urls';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
  user: User | null;
  likedBooks: Book[] | undefined;
  favBooks: Book[] | undefined;

  resoursesUrl: string = RESOURCES;

 

  constructor(private authService: authService,
    private userService: UserService,
    private router: Router) {
    this.user = this.authService.userValue;
      this.userService.getFavoritBooks(this.user?.email).subscribe((books => {
        if (this.user != null) {
          this.favBooks = books;
        }
      }));

    this.userService.getLikedBooks(this.user?.email).subscribe((books => {
      if (this.user != null) {
        this.likedBooks = books;
      }
    }));
    }

  goToAbout(id: number) {
    this.router.navigate(['/about', id]);
  }

  scrollToSection(sectionName: string) {
    const section = document.querySelector(sectionName);
    if (section) {
      section.scrollIntoView({ behavior: "smooth", block: "start", inline: "nearest" });
    }
  }
}
