import { Component } from '@angular/core';
import { Genre } from '../../../../../shared/models/Genre';
import { RESOURCES } from '../../../../../shared/constants/urls';
import { GenreService } from '../../../../../services/GenreService';
import { ModalService } from '../../../../../services/ModalService';

@Component({
  selector: 'app-genre-table',
  templateUrl: './genre-table.component.html',
  styleUrl: './genre-table.component.css'
})
export class GenreTableComponent {
  selectedGenre: Genre = new Genre();
  genres: Genre[] = [];

  constructor(private genreService: GenreService,
    private modalService: ModalService) {
    this.genreService.getAll().subscribe((genres => {
      this.genres = genres;
    }));
  };

  openCreateModal() {
    this.modalService.openFormModal();
  }

  openEditModal(genre: Genre) {
    this.selectedGenre = genre;
    this.modalService.openFormModal();
  }

  Delete(id: number) {
    this.genreService.deleteGenre(id).subscribe({
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
