import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { EmployeeCategory } from '../interface/employeecategory';

@Injectable({
  providedIn: 'root'
})
export class EmployeeCategoryService {

  constructor(private http:HttpClient) { }
  employeeCategoryUrl:string = environment.onboardUrl + 'employeeCategory/'

  saveEmployeeCategory(employeeCategory:EmployeeCategory){
    return this.http.post(this.employeeCategoryUrl, employeeCategory)

  }

  getAllEmployeeCategorys():Observable<EmployeeCategory[]> {
    return this.http.get<EmployeeCategory[]>(this.employeeCategoryUrl)
  }

  deleteEmployeeCategoryById(id:number){
    return this.http.delete(this.employeeCategoryUrl + id)
  }
}
