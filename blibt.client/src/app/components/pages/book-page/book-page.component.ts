import { Component, Input } from '@angular/core';
import { Book } from '../../../shared/models/Book';
import { BookService } from '../../../services/BookService';
import { ActivatedRoute, Router } from '@angular/router';
import { RESOURCES } from '../../../shared/constants/urls';
import { UserService } from '../../../services/UserService';
import { authService } from '../../../services/AuthService';
import { User } from '../../../shared/models/User';
import { CartService } from '../../../services/CartService';
import { FileService } from '../../../services/FileService';

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
  isBuyed: boolean = false;

  constructor(private bookService: BookService,
    private route: ActivatedRoute,
    private userService: UserService,
    private authService: authService,
    private cartService: CartService,
    private fileService: FileService,
    private router: Router) {
    this.id = this.route.snapshot.paramMap.get('id');
    if (this.id != null) {
      this.bookService.getBookById(Number(this.id)).subscribe(book => {
        this.book = book;
      });
    }

    this.bookService.getRndBooksForBookPage().subscribe(books => {
      this.rndBooks = books;
    });

    this.user = this.authService.userValue;

    this.userService.setView(this.user?.email, Number(this.id)).subscribe({
      next: (val: any) => {
 
      },
      error: (err: any) => {
        console.error(err);
      },
    });

    this.userService.isFavoriteBookForUser(this.user?.email, Number(this.id)).subscribe(isFavorite => {
      this.isFavorite = isFavorite;
    });

    this.userService.isLikedBookForUser(this.user?.email, Number(this.id)).subscribe(isLiked => {
      this.isLiked = isLiked;
    });

    this.userService.getBuyedBooks(this.user?.email).subscribe(books => {
      for (var i = 0; i < books.length; i++) {
        if (books[i].id === this.book.id) {
          this.isBuyed = true;
        }
      }
    });
  }

  downloadFile() {
    this.fileService.GetFile(this.user?.email, this.book.id).subscribe(response => {
      const blob = new Blob([response], { type: 'application/vnd.openxmlformats-officedocument.wordprocessingml.document' });
      const url = window.URL.createObjectURL(blob);
      const a = document.createElement('a');
      a.href = url;
      a.download = "meow";
      document.body.appendChild(a);
      a.click();
      document.body.removeChild(a);
      window.URL.revokeObjectURL(url);
    });
  }

  addToCart() {
    this.cartService.addToCart(this.book);
  }

  goToAbout(id: number) {
    this.router.navigate(['/about', id]);
  }

  addLike(bookId: number) {
    if (!this.isLiked) {
      this.userService.setLike(this.user?.email, bookId).subscribe({
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
      this.userService.removeLike(this.user?.email, bookId).subscribe({
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
      this.userService.setFav(this.user?.email, bookId).subscribe({
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
      this.userService.removeFav(this.user?.email, bookId).subscribe({
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
