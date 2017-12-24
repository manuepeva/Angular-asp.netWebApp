import { Component } from '@angular/core'

@Component({

    selector: 'my-employee',
    templateUrl: 'app/employee/employee.component.html'
})

export class EmployeesComponent {
    columnSpan: number = 2;
    firstName: string = 'Tom';
    lastName: string = 'Julius';
    Gender: string = 'Male';
    Age: number = 20;
}
