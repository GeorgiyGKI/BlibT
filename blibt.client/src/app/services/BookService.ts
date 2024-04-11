import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, map } from "rxjs";
import { BOOKS_BY_GENRE_ID, BOOKS_URL, RND_BOOKS_FOR_BP } from '../shared/constants/urls';
import { Book } from "../shared/models/Book";

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Book[]> {
    const a = this.http.get<Book[]>(BOOKS_URL);
    return a;
  }

  getBookById(id: number): Observable<Book> {
    const a = this.http.get<Book>(BOOKS_URL + id);
    return a;
  }
  addBook(data: Book) {
    let formData = new FormData();

    formData.append("title", data.title);
    formData.append("imageFile", data.ImageFile ?? "");
    formData.append("authorId", data.authorId.toString());
    formData.append("description", data.description);
    data.genres.forEach(genreId => { formData.append("genresId", genreId.toString()); });

    return this.http.post<Book>(BOOKS_URL, formData);
  }
  updateBook(id: number, data: Book): Observable<Book> {
    let formData = new FormData();

    formData.append("title", data.title);
    formData.append("imageFile", data.ImageFile ?? "");
    formData.append("authorId", data.authorId.toString());
    formData.append("description", data.description);
    data.genres.forEach(genreId => { formData.append("genresId", genreId.toString()); });

    return this.http.put<Book>(BOOKS_URL + id, formData);
  }
  deleteBook(id: number): Observable<Book> {
    return this.http.delete<Book>(BOOKS_URL + id);
  }

  getBooksByGenreId(genreId: number): Observable<Book[]> {
    return this.http.get<Book[]>(BOOKS_BY_GENRE_ID + genreId)
  }

  getRndBooksForBookPage(): Observable<Book[]> {
    return this.http.get<Book[]>(RND_BOOKS_FOR_BP)
  }
}
