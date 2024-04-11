import { Component, Input } from '@angular/core';
import { ModalService } from '../../../../../services/ModalService';
import { Genre } from '../../../../../shared/models/Genre';
import { Author } from '../../../../../shared/models/Author';
import { GenreService } from '../../../../../services/GenreService';
import { AuthorService } from '../../../../../services/AuthorService';
import { BookService } from '../../../../../services/BookService';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Book } from '../../../../../shared/models/Book';

@Component({
  selector: 'app-book-form',
  templateUrl: './book-form.component.html',
  styleUrl: './book-form.component.css'
})
export class BookFormComponent {
  @Input() book: Book = new Book();
  bookForm: FormGroup;
  genres: Genre[] = [];
  authors: Author[] = [];
  imageFile?: File;
  constructor(private fb: FormBuilder,
    public modalService: ModalService,
    private bookService: BookService,
    private genreService: GenreService,
    private authorService: AuthorService) {
      this.genreService.getAll().subscribe((genres => {
        this.genres = genres;
      }));
      this.authorService.getAll().subscribe((authors => {
        this.authors = authors;
    }));

    this.bookForm = this.fb.group({
      title: ['', Validators.compose([Validators.required, Validators.maxLength(256)])],
      description: ['', Validators.maxLength(2560)],
      authorId: [0, Validators.required],
      genres: [],
    });
  }

  onChange(event: any) {
    this.imageFile = event.target.files[0];
  }

  onFormSubmit() {
    const frmData: Book = Object.assign(this.bookForm.value);
    frmData.ImageFile = this.imageFile;
    if (this.book.id != 0) {
      this.bookService.updateBook(this.book.id, frmData).subscribe({
        next: (val: any) => {
          console.log(val)
          window.location.reload();
        },
        error: (err: any) => {
          console.error(err);
        },
      });
    }
    else {
      this.bookService.addBook(frmData).subscribe({
        next: (val: any) => {
          console.log(val)
          window.location.reload();
        },
        error: (err: any) => {
          console.error(err);
        },
      });
    }
  }

  closeModal() {
    this.book = new Book();
    this.modalService.closeModal();
  }
}
