import { Component, Input } from '@angular/core';
import { ModalService } from '../../../../../services/ModalService';
import { Book } from '../../../../../shared/models/Book';
import { RESOURCES } from '../../../../../shared/constants/urls';

@Component({
  selector: 'app-book-info-form',
  templateUrl: './book-info-form.component.html'
})
export class BookInfoFormComponent {
  resoursesUrl = RESOURCES;

  @Input() book: Book = new Book();
  constructor(
    public modalService: ModalService) {  }

  closeModal() {
    this.modalService.closeModal();
  }
}
