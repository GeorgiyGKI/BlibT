import { Component } from '@angular/core';
import { Transaction } from '../../../../../shared/models/Transaction';
import { TransactionService } from '../../../../../services/TransactionService';

@Component({
  selector: 'app-transaction-table',
  templateUrl: './transaction-table.component.html',
  styleUrl: './transaction-table.component.css'
})
export class TransactionTableComponent {
  selectedTransaction: Transaction = new Transaction();
  transactions: Transaction[] = [];

  constructor(private transactionService: TransactionService) {
    this.transactionService.GetAll().subscribe((transactions => {
      this.transactions = transactions;
    }));
  };
}
