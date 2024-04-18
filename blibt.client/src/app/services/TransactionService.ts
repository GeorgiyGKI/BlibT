import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Transaction } from "../shared/models/Transaction";
import { TRANSACTIONS_URL } from "../shared/constants/urls";
import { Observable } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class TransactionService {

  constructor(private http: HttpClient) { }

  GetAll(): Observable<Transaction[]> {
    return this.http.get<Transaction[]>(TRANSACTIONS_URL);
  }
}
