import { Injectable } from '@angular/core';
import { Book } from '../shared/models/Book';
import { CartItem } from '../shared/models/CartItem';
import { HttpClient } from '@angular/common/http';
import { TRANSACTIONS_URL} from '../shared/constants/urls';


@Injectable({
  providedIn: 'root'
})
export class CartService {
  cartItems: CartItem[] = [];

  constructor(private http: HttpClient) { }

  addToCart(book: Book) {
    let item = this.cartItems.find(item => item.book?.id === book.id);
    if (!item) {
      let id = this.cartItems.length;
      this.cartItems.push({ id, book });
    }
  }

  removeFromCart(index: number) {
    this.cartItems.splice(index, 1);
  }

  createTransaction(sum: number, email: string | undefined) {
    let books: Book[] = [];
    for (var i = 0; i < this.cartItems.length; i++) {
      books.push(this.cartItems[i].book)
    }

    let data = {
      userEmail: email,
      books: books,
      sum: sum,
      dateTime: null
    };

    return this.http.post(TRANSACTIONS_URL, data);
  }

  GetSum(): number{
    let sum: number = 0;
    this.cartItems.forEach((el) => sum += el.book.price);
    return sum
  }

  clearCart() {
    this.cartItems = [];
  }
}
