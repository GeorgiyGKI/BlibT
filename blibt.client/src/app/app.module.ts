import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/partials/header/header.component'
import { NotFoundComponent } from './components/partials/not-found/not-found.component';
import { LoadingComponent } from './components/partials/loading/loading.component';
import { HomeComponent } from './components/pages/home/home.component';
import { LoginPageComponent } from './components/pages/login-page/login-page.component';
import { RegisterPageComponent } from './components/pages/register-page/register-page.component';
import { BookPageComponent } from './components/pages/book-page/book-page.component';
import { LoadingInterceptor } from './shared/interceptors/loading.interceptor';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataTableComponent } from './components/admin-panel/Models/Books/books-table/data-table.component';
import { LeftHeaderComponent } from './components/admin-panel/left-header/left-header.component';
import { BodyComponent } from './components/admin-panel/body/body.component';
import { MatListModule } from '@angular/material/list';
import { BookFormComponent } from './components/admin-panel/Models/Books/book-form/book-form.component'
import { BookInfoFormComponent } from './components/admin-panel/Models/Books/book-info-form/book-info-form.component';
import { GenreFormComponent } from './components/admin-panel/Models/Genres/genre-form/genre-form.component';
import { GenreTableComponent } from './components/admin-panel/Models/Genres/genre-table/genre-table.component';
import { AuthorTableComponent } from './components/admin-panel/Models/Authors/author-table/author-table.component';
import { AuthorFormComponent } from './components/admin-panel/Models/Authors/author-form/author-form.component';
import { JwtInterceptor } from './shared/interceptors/authInterceptor';
import { UserProfileComponent } from './components/pages/user-profile/user-profile.component';
import { CartPageComponent } from './components/pages/cart-page/cart-page.component';
import { TransactionTableComponent } from './components/admin-panel/Models/Transactions/transaction-table/transaction-table.component';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    NotFoundComponent,
    LoadingComponent,
    HomeComponent,
    LoginPageComponent,
    RegisterPageComponent,
    BookPageComponent,
    DataTableComponent,
    LeftHeaderComponent,
    BodyComponent,
    BookFormComponent,
    BookInfoFormComponent,
    GenreFormComponent,
    GenreTableComponent,
    AuthorTableComponent,
    AuthorFormComponent,
    UserProfileComponent,
    CartPageComponent,
    TransactionTableComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    MatListModule
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: LoadingInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: JwtInterceptor, multi: true }

  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
