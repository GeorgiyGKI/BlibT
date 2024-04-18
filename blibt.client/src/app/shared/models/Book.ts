import { Genre } from "./Genre";

export class Book {
  id: number = 0;
  pages: Array<string> = [];
  title: string = '';
  genres: Array<Genre> = [];
  description: string = '';
  likes: number = 0;
  views: number = 0;
  favorits: number = 0;
  authorName: string = '';
  productImageName: string = '';
  ImageFile?: File;
  price: number = 10;

  authorId: number=0;
}
