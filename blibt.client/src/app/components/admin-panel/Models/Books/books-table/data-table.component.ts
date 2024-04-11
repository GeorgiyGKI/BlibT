import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { ModalService } from '../../../../../services/ModalService';
import { Book } from '../../../../../shared/models/Book';
import { AuthorService } from '../../../../../services/AuthorService';
import { BookService } from '../../../../../services/BookService';
import { GenreService } from '../../../../../services/GenreService';
import { RESOURCES } from '../../../../../shared/constants/urls';

@Component({
  selector: 'app-data-table',
  templateUrl: './data-table.component.html'
})
export class DataTableComponent  {
  selectedBook: Book = new Book();
  resoursesUrl: string = RESOURCES
  books: Book[] = [];

  constructor(private authorService: AuthorService,
    private bookService: BookService,
    private genreService: GenreService,
    private modalService: ModalService) {
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
    }));
  }

  openCreateModal() {
    this.modalService.openFormModal();
  }

  openEditModal(book: Book) {
    this.selectedBook = book;
    this.modalService.openFormModal();
  }

  openInfoModal(book: Book) {
    this.selectedBook = book;
    this.modalService.openInfoModal();
  }

  Delete(id: number) {
    this.bookService.deleteBook(id).subscribe({
      next: () => {
        console.log('deleted');
        window.location.reload();
      },
      error: (err: any) => {
        console.error(err);
      }
    });
  }
}
