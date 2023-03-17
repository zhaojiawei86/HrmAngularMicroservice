import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { EmployeeRole } from '../interface/employeerole';

@Injectable({
  providedIn: 'root'
})
export class EmployeeRoleService {

  constructor(private http:HttpClient) { }
  employeeRoleUrl:string = environment.onboardUrl + 'employeeRole/'

  saveEmployeeRole(employeeRole:EmployeeRole){
    return this.http.post(this.employeeRoleUrl, employeeRole)

  }

  getAllEmployeeRoles():Observable<EmployeeRole[]> {
    return this.http.get<EmployeeRole[]>(this.employeeRoleUrl)
  }

  deleteEmployeeRoleById(id:number){
    return this.http.delete(this.employeeRoleUrl + id)
  }
}
