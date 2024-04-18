import { Component, Injectable } from '@angular/core';
import { Book } from '../../../shared/models/Book';
import { CartItem } from '../../../shared/models/CartItem';
import { CartService } from '../../../services/CartService';
import { RESOURCES } from '../../../shared/constants/urls';
import { authService } from '../../../services/AuthService';

@Component({
  selector: 'app-cart-page',
  templateUrl: './cart-page.component.html',
  styleUrl: './cart-page.component.css'
})

@Injectable({
  providedIn: 'root'
})

export class CartPageComponent {
  cartItems: CartItem[] = [];
  resoursesUrl: string = RESOURCES;
  sum: number = 0;

  constructor(private cartService: CartService,
    private authService: authService) {
    this.cartItems = this.cartService.cartItems
    this.sum = this.cartService.GetSum();
  }

  buy() {
    let userEmail = this.authService.userValue?.email;
    this.cartService.createTransaction(this.sum, userEmail).subscribe({
      next: (val: any) => {
        console.log(val)
        this.cartService.clearCart();
        window.location.href = '/';
      },
      error: (err: any) => {
        console.error(err);
      },
    });
  }

  removeItem(id: number) {
    this.cartService.removeFromCart(id);
    this.sum = this.cartService.GetSum();
  }
}
