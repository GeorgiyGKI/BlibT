import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BooksListComponent } from './books-list/books-list.component';
import { HeaderComponent } from './header/header.component';
import { OpenBookComponent } from './open-book/open-book.component';
import { TranslateBookComponent } from './translate-book/translate-book.component';
import { SearchComponent } from './components/partials/search/search.component';
import { TextInputComponent } from './components/partials/text-input/text-input.component';
import { TagsComponent } from './components/partials/tags/tags.component';
import { NotFoundComponent } from './components/partials/not-found/not-found.component';
import { LoadingComponent } from './components/partials/loading/loading.component';
import { InputValidationComponent } from './components/partials/input-validation/input-validation.component';
import { DefaultButtonComponent } from './components/partials/default-button/default-button.component';
import { HomeComponent } from './components/pages/home/home.component';
import { LoginPageComponent } from './components/pages/login-page/login-page.component';
import { RegisterPageComponent } from './components/pages/register-page/register-page.component';
import { BookPageComponent } from './components/pages/book-page/book-page.component';
import { BookListPageComponent } from './components/pages/book-list-page/book-list-page.component';


@NgModule({
  declarations: [
    AppComponent,
    BooksListComponent,
    HeaderComponent,
    OpenBookComponent,
    TranslateBookComponent,
    SearchComponent,
    TextInputComponent,
    TagsComponent,
    NotFoundComponent,
    LoadingComponent,
    InputValidationComponent,
    DefaultButtonComponent,
    HomeComponent,
    LoginPageComponent,
    RegisterPageComponent,
    BookPageComponent,
    BookListPageComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
