import { Component } from '@angular/core';
<<<<<<< HEAD
import { EmployeesComponent } from './employee/employees.component';

@Component({
  selector: 'my-app',
  template: `
            <div>
                Name: <input [(ngModel)]='name'/>
                <br/>
                You Entered : {{name}}
            </div>
              `
})
export class AppComponent  {
    name: string = 'Tom';
}
=======

@Component({
  selector: 'my-app',
  template: `<h1>Hello {{name}}</h1>`,
})
export class AppComponent  { name = 'Angular'; }
>>>>>>> 75023a1490b9af23c33c7b79d6b76516a70f45fa
