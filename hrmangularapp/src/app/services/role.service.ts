import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Role } from '../interface/role';

@Injectable({
  providedIn: 'root'
})
export class RoleService {

  constructor(private http:HttpClient) { }
  roleUrl:string = environment.url + 'role'

  saveRole(role:Role){
    return this.http.post(this.roleUrl, role)

  }

  getAllRoles():Observable<Role[]> {
    return this.http.get<Role[]>(this.roleUrl)
  }

  deleteRoleById(id:number){
    return this.http.delete(this.roleUrl + '/' + id)
  }
}
