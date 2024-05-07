import { HttpClient, HttpParams } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, map } from "rxjs";
import { BOOKS_ALL, BOOKS_BY_GENRE_ID, BOOKS_URL, RND_BOOKS_FOR_BP } from '../shared/constants/urls';
import { Book } from "../shared/models/Book";
import { ApiResult } from "../shared/models/ApiResult";

@Injectable({
  providedIn: 'root'
})
export class BookService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Book[]> {
    return this.http.get<Book[]>(BOOKS_ALL);
  }

  getBookById(id: number): Observable<Book> {
    return this.http.get<Book>(BOOKS_URL + id);
  }
  addBook(data: Book) {
    let formData = new FormData();

    formData.append("title", data.title);
    formData.append("authorId", data.authorId.toString());
    formData.append("description", data.description);
    formData.append("price", data.price.toString());
    formData.append("imageFile", data.ImageFile ?? "");

    data.genresIds.forEach(genreId => { formData.append("genresIds", genreId.toString()); });

    return this.http.post(BOOKS_URL, formData);
  }
  updateBook(id: number, data: Book) {
    let formData = new FormData();
    let bool = data.ImageFile != undefined 
    bool ? formData.append("imageFile", data.ImageFile ?? "")
      : formData.append("productImageName", data.productImageName);

    formData.append("title", data.title);
    formData.append("authorId", data.authorId.toString());
    formData.append("description", data.description);
    formData.append("price", data.price.toString());
    formData.append("likes", data.likes.toString());
    formData.append("views", data.views.toString());
    formData.append("favorits", data.favorits.toString());
    data.genresIds.forEach(genreId => { formData.append("genresIds", genreId.toString()); });

    return this.http.put(BOOKS_URL + id, formData);
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


  getData(
    pageIndex: number,
    pageSize: number,
    sortColumn: string,
    sortOrder: string,
    filterColumn: string | null,
    filterQuery: string | null
  ): Observable<ApiResult<Book>> {
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn)
      .set("sortOrder", sortOrder);

    if (filterColumn && filterQuery) {
      params = params
        .set("filterColumn", filterColumn)
        .set("filterQuery", filterQuery);
    }

    return this.http.get<ApiResult<Book>>(BOOKS_URL, { params });
  }
}
