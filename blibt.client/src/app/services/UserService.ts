import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Book } from "../shared/models/Book";
import { Observable } from "rxjs";
import { USER_FAVBOOKS_URL, USER_ISFAVORITECHECK_URL, USER_ISLIKEDCHECK_URL, USER_LIKEDBOOKS_URL, USER_REMOVE_FAVORITE_URL, USER_REMOVE_LIKE, USER_SETFAV_URL, USER_SETLIKE_URL } from "../shared/constants/urls";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getFavoritBooks(email: string | undefined): Observable<Book[]> {
    return this.http.get<Book[]>(USER_FAVBOOKS_URL + email);
  }
  getLikedBooks(email: string | undefined): Observable< Book[]> {
    return this.http.get<Book[]>(USER_LIKEDBOOKS_URL + email);
  }
  setLike(email: string | undefined, bookId: number) {
    let data = {
      email: email,
      bookId: bookId
    }
    return this.http.patch(USER_SETLIKE_URL, data);
  }
  setFav(email: string | undefined, bookId: number){
    let data = {
      email: email,
      bookId: bookId
    }
    return this.http.patch(USER_SETFAV_URL, data);
  }

  isLikedBookForUser(email: string | undefined, bookId: number): Observable<boolean> {
    let data = {
      email: email,
      bookId: bookId
    }
    return this.http.post<boolean>(USER_ISLIKEDCHECK_URL, data)
  }

  isFavoriteBookForUser(email: string | undefined, bookId: number): Observable<boolean> {
    let data = {
      email: email,
      bookId: bookId
    }
    return this.http.post<boolean>(USER_ISFAVORITECHECK_URL, data)
  }

  removeLike(email: string | undefined, bookId: number) {
    let data = {
      email: email,
      bookId: bookId
    }

    return this.http.patch(USER_REMOVE_LIKE, data);
  }
  removeFav(email: string | undefined, bookId: number) {
    let data = {
      email: email,
      bookId: bookId
    }

    return this.http.patch(USER_REMOVE_FAVORITE_URL, data);
  }
}
