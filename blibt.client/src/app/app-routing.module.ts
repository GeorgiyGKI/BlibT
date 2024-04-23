import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './components/pages/home/home.component';
import { BodyComponent } from './components/admin-panel/body/body.component';
import { DataTableComponent } from './components/admin-panel/Models/Books/books-table/data-table.component';
import { GenreTableComponent } from './components/admin-panel/Models/Genres/genre-table/genre-table.component';
import { AuthorTableComponent } from './components/admin-panel/Models/Authors/author-table/author-table.component';
import { LoginPageComponent } from './components/pages/login-page/login-page.component';
import { RegisterPageComponent } from './components/pages/register-page/register-page.component';
import { AuthGuard } from './shared/quards/authGuard';
import { UserProfileComponent } from './components/pages/user-profile/user-profile.component';
import { BookPageComponent } from './components/pages/book-page/book-page.component';
import { CartPageComponent } from './components/pages/cart-page/cart-page.component';
import { TransactionTableComponent } from './components/admin-panel/Models/Transactions/transaction-table/transaction-table.component';
import { RoleGuard } from './shared/quards/roleGuard';

const routes: Routes = [
  {
    path: '', component: HomeComponent,
  },
  { path: 'login', component: LoginPageComponent },
  { path: 'registration', component: RegisterPageComponent },
  {
    path: 'admin', component: BodyComponent,
    canActivate: [AuthGuard, RoleGuard],
    children: [
      { path: 'books', component: DataTableComponent },
      { path: 'genres', component: GenreTableComponent },
      { path: 'authors', component: AuthorTableComponent },
      { path: 'transactions', component: TransactionTableComponent },
    ],
    data: {
      role: ["Administrator", "Moderator"]
    }
  },
  {
    path: 'profile', component: UserProfileComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'about/:id', component: BookPageComponent,
    canActivate: [AuthGuard],
  },
  {
    path: 'cart', component: CartPageComponent,
    canActivate: [AuthGuard],
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
