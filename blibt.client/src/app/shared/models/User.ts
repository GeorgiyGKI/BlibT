import { Book } from "./Book";

export class User {
  name: string = '';
  email: string = '';
  password: string = '';
  token?: string;
  roles?: string[];
  books: Book[] = [];
}
