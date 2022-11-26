import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';


@Component({
  selector: 'app-update-expense',
  templateUrl: './update-expense.component.html',
  styleUrls: ['./update-expense.component.css']
})
export class UpdateExpenseComponent implements OnInit {
  expense: any = {}
  model: any = {}

  constructor(
    private http: HttpClient, private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
    this.getExpense();
  }

  updateExpense() {
    this.model.id = this.expense.id;

    if(this.model.expenseName == undefined)
    {
      this.model.expenseName = this.expense.expenseName;
    }

    if(this.model.business == undefined)
    {
      this.model.business = this.expense.business;
    }

    if(this.model.amount == undefined)
    {
      this.model.amount = this.expense.amount;
    }

    if(this.model.paymentStatus == undefined)
    {
      this.model.paymentStatus = this.expense.paymentStatus;
    }

    console.log(this.model);

    if(this.model.expenseName === this.expense.expenseName && this.model.business === this.expense.business && 
      this.model.amount === this.expense.amount && this.model.paymentStatus === this.expense.paymentStatus)
      {
        this.home();
      }

      else
      {
        this.http.put('http://localhost:5263/api/expenses', this.model).subscribe(
          response => { this.home() },
          error => { console.log(error) }
        );
      }
  }

  cancel() {
    this.home();
  }

  home() {
    this.router.navigate(["/"]);
  }

  getExpense() {
    let id = this.route.snapshot.paramMap.get('id');
    this.http.get(`http://localhost:5263/api/expenses/${id}`).subscribe(expense => {
      this.expense = expense;
    }
  );
  }
}