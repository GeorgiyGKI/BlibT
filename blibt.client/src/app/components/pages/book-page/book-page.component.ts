import { Component, Input } from '@angular/core';
import { Book } from '../../../shared/models/Book';
import { BookService } from '../../../services/BookService';
import { ActivatedRoute } from '@angular/router';
import { RESOURCES } from '../../../shared/constants/urls';
import { UserService } from '../../../services/UserService';
import { authService } from '../../../services/AuthService';
import { User } from '../../../shared/models/User';

@Component({
  selector: 'app-book-page',
  templateUrl: './book-page.component.html',
  styleUrl: './book-page.component.css'
})
export class BookPageComponent {
  id: string | null;
  book: any;
  rndBooks: any[] = [];
  user: User | null;
  resoursesUrl: string = RESOURCES;
  isLiked: boolean = false;
  isFavorite: boolean = false;

  constructor(private bookService: BookService,
    private route: ActivatedRoute,
    private userServce: UserService,
    private authService: authService) {
    this.id = this.route.snapshot.paramMap.get('id');
    this.user = this.authService.userValue;

    this.userServce.isFavoriteBookForUser(this.user?.email, Number(this.id)).subscribe(isFavorite => {
      this.isFavorite = isFavorite;
    });

    this.userServce.isLikedBookForUser(this.user?.email, Number(this.id)).subscribe(isLiked => {
      this.isLiked = isLiked;
    });
  }

  ngOnInit(): void {

    if (this.id != null) {
      this.bookService.getBookById(parseInt(this.id, 10)).subscribe(book => {
        this.book = book;
      });

      this.bookService.getRndBooksForBookPage().subscribe(books => {
        this.rndBooks = books;
      });
    }
  }

  addLike(bookId: number) {
    if (!this.isLiked) {
      this.userServce.setLike(this.user?.email, bookId).subscribe({
        next: (val: any) => {
          console.log(val);
          this.isLiked = true;
        },
        error: (err: any) => {
          console.error(err);
        }
      });
    }
    else {
      this.userServce.removeLike(this.user?.email, bookId).subscribe({
        next: (val: any) => {
          console.log(val);
          this.isLiked = false;
        },
        error: (err: any) => {
          console.error(err);
        }
      })
    }
  }

  addFav(bookId: number) {
    if (!this.isFavorite) {
      this.userServce.setFav(this.user?.email, bookId).subscribe({
        next: (val: any) => {
          console.log(val)
          this.isFavorite = true;
        },
        error: (err: any) => {
          console.error(err);
        },
      });
    }
    else {
      this.userServce.removeFav(this.user?.email, bookId).subscribe({
        next: (val: any) => {
          console.log(val);
          this.isFavorite = false;
        },
        error: (err: any) => {
          console.error(err);
        }
      })
    }
  }
}
