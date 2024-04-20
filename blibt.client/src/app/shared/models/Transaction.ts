import { Book } from "./Book";

export class Transaction {
  userEmail?: string;
  sum?: number;
  books?: Book[];
  dateTime?: Date;
}
