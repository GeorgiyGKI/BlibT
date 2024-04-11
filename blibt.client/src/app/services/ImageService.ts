import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ImageService {

  constructor(private http: HttpClient) { }

  uploadImage(imageFile: File) {
    const formData = new FormData();
    formData.append('file', imageFile);
    return this.http.post('/api/images/upload', formData);
  }

  getImage(imageName: string) {
    return this.http.get(`/api/images/${imageName}`, { responseType: 'blob' });
  }
}
