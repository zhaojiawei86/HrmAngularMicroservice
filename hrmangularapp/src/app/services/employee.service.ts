import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Employee } from '../interface/employee';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  constructor(private http:HttpClient) { }
  employeeUrl:string = environment.onboardUrl + 'employee/'

  saveEmployee(employee:Employee){
    return this.http.post(this.employeeUrl, employee)

  }

  getAllEmployees():Observable<Employee[]> {
    return this.http.get<Employee[]>(this.employeeUrl)
  }

  deleteEmployeeById(id:number){
    return this.http.delete(this.employeeUrl + id)
  }
}
