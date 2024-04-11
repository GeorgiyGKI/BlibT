import { Component} from '@angular/core';
import { User } from '../../../shared/models/User';
import { authService } from '../../../services/AuthService';
import { Observable } from 'rxjs';
import { UserService } from '../../../services/UserService';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrl: './user-profile.component.css'
})
export class UserProfileComponent {
  user: User | null;
  liked: number[] | undefined;

  constructor(private authService: authService,
  private userService: UserService) {
    this.user = this.authService.userValue;
      this.userService.getFavoritBooks(this.user?.email).subscribe((books => {
        if (this.user != null) {
          this.user.books = books;
        }
      }));

    this.userService.getLikedBooks(this.user?.email).subscribe((books => {
      if (this.user != null) {
        this.liked = books;
      }
    }));
    }
 

  scrollToSection(sectionName: string) {
    const section = document.querySelector(sectionName);
    if (section) {
      section.scrollIntoView({ behavior: "smooth", block: "start", inline: "nearest" });
    }
  }
}
