import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Author } from '../../../shared/models/Author';
import { Observable } from 'rxjs';
import { AuthorService } from '../../../services/AuthorService';
import { BookService } from '../../../services/BookService';
import { GenreService } from '../../../services/GenreService';
import { Book } from "../../../shared/models/Book";
import { RESOURCES } from '../../../shared/constants/urls';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent {
  resoursesUrl: string = RESOURCES;
  books: Book[] = [];
  sortedBooks: Book[] = [];
  selectedBook: Book = new Book();
  constructor(private authorService: AuthorService,
    activatedRoute: ActivatedRoute,
    private bookService: BookService,
    private genreService: GenreService,
    private router: Router) {
    this.bookService.getAll().subscribe((books => {
      this.books = books;
      this.books.forEach(book => {
        this.authorService.getAuthorById(book.authorId).subscribe((author => {
          book.authorName = author.fullName;
        }));
        this.genreService.getGenresByBookId(book.id).subscribe((genres => {
          book.genres = genres;
        }))
      });

      this.sortedBooks = books;
    }));
  }

  goToAbout(id: number) {
    this.router.navigate(['/about', id]);
  }

  sortByLikes() {
    this.sortedBooks.sort((a, b) => b.likes - a.likes);
  }
  sortByViews() {
    this.sortedBooks.sort((a, b) => b.views - a.views);
  }
  sortByRnd() {
    this.sortedBooks.sort(() => Math.random() - 0.5)
  }
 
}


