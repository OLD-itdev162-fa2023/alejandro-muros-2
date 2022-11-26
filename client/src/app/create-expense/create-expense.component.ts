import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-create-expense',
  templateUrl: './create-expense.component.html',
  styleUrls: ['./create-expense.component.css']
})
export class CreateExpenseComponent implements OnInit {
  model: any = {}

  constructor(
    private http: HttpClient,
    private route: Router) { }

  ngOnInit(): void {
  }

  createExpense() {
    
    this.http.post('http://localhost:5263/api/expenses', this.model).subscribe(
      response => { this.home() },
      error => { console.log(error) }
    );
  }

  cancel() {
    this.home();
  }

  home() {
    this.route.navigate(["/"]);
  }
}
