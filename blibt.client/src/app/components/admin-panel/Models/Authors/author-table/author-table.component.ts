import { Component } from '@angular/core';
import { ModalService } from '../../../../../services/ModalService';
import { Author } from '../../../../../shared/models/Author';
import { AuthorService } from '../../../../../services/AuthorService';

@Component({
  selector: 'app-author-table',
  templateUrl: './author-table.component.html',
  styleUrl: './author-table.component.css'
})
export class AuthorTableComponent {
  selectedAuthor: Author = new Author();
  authors: Author[] = [];

  constructor(private authorService: AuthorService,
    private modalService: ModalService) {
    this.authorService.getAll().subscribe((authors => {
      this.authors = authors;
    }));
  };

  openCreateModal() {
    this.modalService.openFormModal();
  }

  openEditModal(author: Author) {
    this.selectedAuthor = author;
    this.modalService.openFormModal();
  }

  Delete(id: number) {
    this.authorService.deleteAuthor(id).subscribe({
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
