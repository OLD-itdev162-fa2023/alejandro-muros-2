import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-view-expense',
  templateUrl: './view-expense.component.html',
  styleUrls: ['./view-expense.component.css']
})
export class ViewExpenseComponent implements OnInit {
  expense: any = {}

  constructor(private http: HttpClient, private route: ActivatedRoute) { }

  ngOnInit(): void {
    this.getExpense();
  }

  getExpense() {
    let id = this.route.snapshot.paramMap.get('id');
    this.http.get(`http://localhost:5263/api/expenses/${id}`).subscribe(expense => {
      this.expense = expense;
    }
    );
  }
}
