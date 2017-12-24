import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
<<<<<<< HEAD
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { EmployeesComponent } from './employee/employees.component';

@NgModule({
    imports: [BrowserModule, FormsModule ],
  declarations: [AppComponent, EmployeesComponent ],
=======

import { AppComponent }  from './app.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent ],
>>>>>>> 75023a1490b9af23c33c7b79d6b76516a70f45fa
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
