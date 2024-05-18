import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Author } from '../../../shared/models/Author';
import { Observable } from 'rxjs';
import { AuthorService } from '../../../services/AuthorService';
import { BookService } from '../../../services/BookService';
import { GenreService } from '../../../services/GenreService';
import { Book } from "../../../shared/models/Book";
import { RESOURCES } from '../../../shared/constants/urls';

import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { Subject } from 'rxjs';
import { debounceTime, distinctUntilChanged } from 'rxjs/operators';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})


export class HomeComponent implements OnInit {
  public displayedColumns: string[] = ['title','likes','views','favorits'];

  resoursesUrl: string = RESOURCES;
  books: Book[] = [];
  selectedBook: Book = new Book();

  @ViewChild(MatPaginator) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  filterTextChanged: Subject<string> = new Subject<string>();

  defaultFilterColumn: string = "title";
  filterQuery?: string;
  defaultPageIndex: number = 0;
  defaultPageSize: number = 10;
  public defaultSortColumn: string = "title";
  public defaultSortOrder: "asc" | "desc" = "asc";

  constructor(private authorService: AuthorService,
    activatedRoute: ActivatedRoute,
    private bookService: BookService,
    private genreService: GenreService,
    private router: Router) {
    //this.bookService.getAll().subscribe((books => {
    //  this.books = books;
    //  this.books.forEach(book => {
    //    this.authorService.getAuthorById(book.authorId).subscribe((author => {
    //      book.authorName = author.fullName;
    //    }));
    //    this.genreService.getGenresByBookId(book.id).subscribe((genres => {
    //      book.genres = genres;
    //    }))
    //  });

    //  this.sortedBooks = books;
    //}));
  }

  ngOnInit() {
    this.loadData();
  }

  // debounce filter text changes
  onFilterTextChanged(filterText: string) {
    if (!this.filterTextChanged.observed) {
      this.filterTextChanged
        .pipe(debounceTime(1000), distinctUntilChanged())
        .subscribe(query => {
          this.loadData(query);
        });
    }
    this.filterTextChanged.next(filterText);
  }

  loadData(query?: string) {
    var pageEvent = new PageEvent();
    pageEvent.pageIndex = this.defaultPageIndex;
    pageEvent.pageSize = this.defaultPageSize;
    this.filterQuery = query;
    this.getData(pageEvent);
  }

  getData(event: PageEvent) {

    var sortColumn = (this.sort)
      ? this.sort.active
      : this.defaultSortColumn;

    var sortOrder = (this.sort)
      ? this.sort.direction
      : this.defaultSortOrder;

    var filterColumn = (this.filterQuery)
      ? this.defaultFilterColumn
      : null;

    var filterQuery = (this.filterQuery)
      ? this.filterQuery
      : null;

    this.bookService.getData(
      event.pageIndex,
      event.pageSize,
      sortColumn,
      sortOrder,
      filterColumn,
      filterQuery)
      .subscribe({
        next: (result) => {
          this.paginator.length = result.totalCount;
          this.paginator.pageIndex = result.pageIndex;
          this.paginator.pageSize = result.pageSize;
          this.books = result.data;
        },
        error: (error) =>console.error(error)
      });
  }

  goToAbout(id: number) {
    this.router.navigate(['/about', id]);
  }
}


