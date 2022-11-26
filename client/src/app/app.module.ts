import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatIconModule} from '@angular/material/icon';
import {MatButtonModule} from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { ViewPostComponent } from './view-post/view-post.component';
import { CreatePostComponent } from './create-post/create-post.component';
import { ViewExpenseComponent } from './view-expense/view-expense.component';
import { CreateExpenseComponent } from './create-expense/create-expense.component';
import { UpdateExpenseComponent } from './update-expense/update-expense.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ViewPostComponent,
    CreatePostComponent,
    ViewExpenseComponent,
    CreateExpenseComponent,
    UpdateExpenseComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatToolbarModule,
    MatIconModule,
    MatButtonModule,
    FormsModule,
    MatFormFieldModule,
    MatInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
