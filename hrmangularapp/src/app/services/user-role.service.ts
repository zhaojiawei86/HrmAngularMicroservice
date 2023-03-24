import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { UserRole } from '../interface/userrole';

@Injectable({
  providedIn: 'root'
})
export class UserRoleService {
  constructor(private http:HttpClient) { }
  userRoleUrl:string = environment.url + 'userRole'

  saveUserRole(userRole:UserRole){
    return this.http.post(this.userRoleUrl, userRole)

  }

  getAllUserRoles():Observable<UserRole[]> {
    return this.http.get<UserRole[]>(this.userRoleUrl)
  }

  deleteUserRoleById(id:number){
    return this.http.delete(this.userRoleUrl + '/' + id)
  }
}
