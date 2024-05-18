import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { FILE_CREATE_URL, FILE_GET_URL } from "../shared/constants/urls";

@Injectable({
  providedIn: 'root'
})
export class FileService {
  constructor(private http: HttpClient) { }

  CreateFile(bookId: number, file: File) {
    let formData = new FormData();
    formData.append("BookId", bookId.toString());
    formData.append("FormFile", file ?? "");
    formData.append("Email", "");

    return this.http.post(FILE_CREATE_URL, formData);

  }

  GetFile(email: string | undefined, bookTitle: string){
    let body = {
      emal: email,
      bookTitle: bookTitle
    }

    let url = "https://localhost:7148/docx/2dc4ccd6-a6c0-4cd7-babb-cd7407ec9beb.docx";
    return this.http.get(url, { responseType: 'blob' });
    }
  }

