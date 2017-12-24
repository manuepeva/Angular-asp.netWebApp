import { Component } from '@angular/core';
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
