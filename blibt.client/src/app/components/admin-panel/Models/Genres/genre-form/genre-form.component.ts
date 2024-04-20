import { Component, Input } from '@angular/core';
import { Genre } from '../../../../../shared/models/Genre';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ModalService } from '../../../../../services/ModalService';
import { GenreService } from '../../../../../services/GenreService';

@Component({
  selector: 'app-genre-form',
  templateUrl: './genre-form.component.html',
  styleUrl: './genre-form.component.css'
})
export class GenreFormComponent {
  @Input() genre: Genre = new Genre();
  GenreForm: FormGroup;
  constructor(private fb: FormBuilder,
    public modalService: ModalService,
    private genreService: GenreService) {
    this.GenreForm = this.fb.group({
      //name: ['', Validators.compose([Validators.required, Validators.maxLength(256)])]
    });
  }

  onFormSubmit() {
    const frmData: Genre = Object.assign(this.GenreForm.value);
    if (this.genre.id != 0) {
      this.genreService.updateGenre(this.genre.id, frmData).subscribe({
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
      this.genreService.addGenre(frmData).subscribe({
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

  //!!!
  closeModal() {
    //this.genre = null;
    this.modalService.closeModal();
  }
}
