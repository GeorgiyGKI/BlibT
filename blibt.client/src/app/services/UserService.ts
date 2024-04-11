import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Book } from "../shared/models/Book";
import { Observable } from "rxjs";
import { USER_FAVBOOKS_URL } from "../shared/constants/urls";

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http: HttpClient) { }

  getFavoritBooks(email: string | undefined): Observable<Book[]> {
    return this.http.get<Book[]>(USER_FAVBOOKS_URL + email);
  }
  getLikedBooks(email: string | undefined): Observable<number[]> {
    return this.http.get<number[]>('https://localhost:7148/api/user/likedBooks/moderator@test.com');
  }
 
}
