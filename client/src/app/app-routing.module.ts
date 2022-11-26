import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateExpenseComponent } from './create-expense/create-expense.component';
import { HomeComponent } from './home/home.component';
import { ViewExpenseComponent } from './view-expense/view-expense.component';
import { UpdateExpenseComponent } from './update-expense/update-expense.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'expenses/:id', component: ViewExpenseComponent},
  {path: 'create', component: CreateExpenseComponent},
  {path: 'update/:id', component: UpdateExpenseComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
