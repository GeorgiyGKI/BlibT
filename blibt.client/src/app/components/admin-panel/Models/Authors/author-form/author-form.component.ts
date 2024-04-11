import { Component, Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AuthorService } from '../../../../../services/AuthorService';
import { ModalService } from '../../../../../services/ModalService';
import { Author } from '../../../../../shared/models/Author';

@Component({
  selector: 'app-author-form',
  templateUrl: './author-form.component.html',
  styleUrl: './author-form.component.css'
})
export class AuthorFormComponent {
  @Input() author: Author = new Author();
  AuthorForm: FormGroup;
  constructor(private fb: FormBuilder,
    public modalService: ModalService,
    private authorService: AuthorService) {
    this.AuthorForm = this.fb.group({
      fullName: ['', Validators.compose([Validators.required, Validators.maxLength(256)])]
    });
  }

  onFormSubmit() {
    const frmData: Author = Object.assign(this.AuthorForm.value);
    if (this.author.id != 0) {
      this.authorService.updateAuthor(this.author.id, frmData).subscribe({
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
      this.authorService.addAuthor(frmData).subscribe({
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
    //this.Author = null;
    this.modalService.closeModal();
  }
}
