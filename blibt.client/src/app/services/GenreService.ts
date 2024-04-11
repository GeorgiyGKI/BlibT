import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable, map } from "rxjs";
import { Author } from "../shared/models/Author";
import { AUTHORS_URL, AUTHOR_BY_ID_URL, GENRES_BY_BOOK_ID, GENRES_URL, GENRE_BY_ID_URL } from '../shared/constants/urls';
import { Genre } from "../shared/models/Genre";

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Genre[]> {
    return this.http.get<Genre[]>(GENRES_URL);
  }

  getGenreById(genreId: number): Observable<Genre> {
    return this.http.get<Genre>(GENRE_BY_ID_URL + genreId);
  }

  getGenresByBookId(GenreId: number): Observable<Genre[]> {
    return this.http.get<Genre[]>(GENRES_BY_BOOK_ID + GenreId)
  }

  addGenre(data: Genre) {
    return this.http.post<Genre>(GENRES_URL, data);
  }
  updateGenre(id: number, data: Genre): Observable<Genre> {
    return this.http.put<Genre>(GENRES_URL + id, data);
  }
  deleteGenre(id: number): Observable<Genre> {
    return this.http.delete<Genre>(GENRES_URL + id);
  }
}
