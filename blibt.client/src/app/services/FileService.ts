import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class FileService {
  constructor(private http: HttpClient) { }

  CreateFile(bookTitle: string, file: File, email: string) {
    let formData = new FormData();
    formData.append("bookTitle", bookTitle);
    formData.append("file", file ?? "");
    formData.append("email", email);

    //!!! ТО ЧТО В КАВЫЧКАХ ПОМЕНЯТЬ НА РАБОЧИЙ КОД
    return this.http.post("FILE_CREATE", formData);
    }

  GetFile(email: string, bookTitle: string): Observable<File>{
    let body = {
      emal: email,
      bookTitle: bookTitle
    }

    //!!!
    return this.http.get<File>("FILE_GET" + "/{email}/{bookTitle}");
    }
  }

