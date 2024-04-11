import { Component, Input } from '@angular/core';
import { Book } from '../../../shared/models/Book';
import { BookService } from '../../../services/BookService';
import { ActivatedRoute } from '@angular/router';
import { RESOURCES } from '../../../shared/constants/urls';

@Component({
  selector: 'app-book-page',
  templateUrl: './book-page.component.html',
  styleUrl: './book-page.component.css'
})
export class BookPageComponent {
  id: string | null;
  book: any; 
  rndBooks: any[] = [];

  resoursesUrl: string = RESOURCES;

  constructor(private bookService: BookService, private route: ActivatedRoute) {
    this.id = this.route.snapshot.paramMap.get('id');
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
}
