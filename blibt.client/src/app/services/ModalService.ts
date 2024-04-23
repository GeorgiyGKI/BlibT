import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ModalService {
  modalInfoVisible: boolean = false;
  modalFormVisible: boolean = false;


  constructor() { }

  openFormModal() {
    this.modalFormVisible = true;
  }
  openInfoModal() {
    this.modalInfoVisible = true;
  }

  closeModal() {
    this.modalInfoVisible = false;
    this.modalFormVisible = false;
  }
}
