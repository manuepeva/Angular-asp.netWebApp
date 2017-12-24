import { Injectable } from '@angular/core';
import { EmployeesComponent } from './employee/employees.component';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';


@Injectable()
export class EmployeeService {

    constructor(private _http: Http) {

    }

    getEmployees(): Observable<EmployeesComponent[]> {
        return this._http.get("http://localhost:56152/api/employees").
            map((response: Response) => <EmployeesComponent[]>response.json())
    }
}
