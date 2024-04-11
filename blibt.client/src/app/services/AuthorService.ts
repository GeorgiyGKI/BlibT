import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, map } from "rxjs";
import { Author } from "../shared/models/Author";
import { AUTHORS_URL, AUTHOR_BY_ID_URL } from '../shared/constants/urls';

@Injectable({
  providedIn: 'root'
})
export class AuthorService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Author[]> {
    return this.http.get<Author[]>(AUTHORS_URL);
  }

  getAuthorById(AuthorId: number): Observable<Author> {
    return this.http.get<Author>(AUTHOR_BY_ID_URL + AuthorId);
  }

  addAuthor(data: Author) {
    return this.http.post<Author>(AUTHORS_URL, data);
  }
  updateAuthor(id: number, data: Author): Observable<Author> {
    return this.http.put<Author>(AUTHORS_URL + id, data);
  }
  deleteAuthor(id: number): Observable<Author> {
    return this.http.delete<Author>(AUTHORS_URL + id);
  }
}
