import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { EmployeeStatus } from '../interface/employeestatus';

@Injectable({
  providedIn: 'root'
})
export class EmployeeStatusService {

  constructor(private http:HttpClient) { }
  employeeStatusUrl:string = environment.onboardUrl + 'employeeStatus/'

  saveEmployeeStatus(employeeStatus:EmployeeStatus){
    return this.http.post(this.employeeStatusUrl, employeeStatus)

  }

  getAllEmployeeStatuss():Observable<EmployeeStatus[]> {
    return this.http.get<EmployeeStatus[]>(this.employeeStatusUrl)
  }

  deleteEmployeeStatusById(id:number){
    return this.http.delete(this.employeeStatusUrl + id)
  }
}
