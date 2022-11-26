import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  expenses: any;

  constructor(private http: HttpClient, private route: ActivatedRoute, private router: Router) { }

  ngOnInit(): void{
    this.http.get('http://localhost:5263/api/expenses').subscribe(
      response =>{ this.expenses = response; },
      error => { console.log(error) }
    );
  }

  deleteExpense(eId:string) {
    this.http.delete(`http://localhost:5263/api/expenses/${eId}`).subscribe(
      response => { this.refreshPage() },
      error => { console.log(error) }
    );
  }

  refreshPage() {
    location.reload();
  }
}
