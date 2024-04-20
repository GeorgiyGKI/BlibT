import { Genre } from "./Genre";

export class Book {
  id: number = 0;
  authorId: number=0;
  title: string = '';
  productImageName: string = '';
  genresIds: Array<string> = [];;
  description: string = '';
  likes: number = 0;
  views: number = 0;
  favorits: number = 0;
  price: number = 0
  ImageFile?: File;


  genres: Array<Genre> = [];
  authorName: string = '';

}
