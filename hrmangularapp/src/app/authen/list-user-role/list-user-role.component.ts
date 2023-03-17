import { Component, OnInit } from '@angular/core';
import { UserRole } from 'src/app/interface/userrole';
import { UserRoleService } from 'src/app/services/user-role.service';

@Component({
  selector: 'app-list-user-role',
  templateUrl: './list-user-role.component.html',
  styleUrls: ['./list-user-role.component.scss']
})
export class ListUserRoleComponent implements OnInit{
  constructor(private userRoleService:UserRoleService){}
  userRoleCollections:UserRole[] = []
  ngOnInit(): void {
      this.userRoleService.getAllUserRoles().subscribe((data)=>{
        this.userRoleCollections = data;
      });
  }

  deleteUserRole(id:number){
    if(confirm("Are you sure to delete?")) {
      this.userRoleService.deleteUserRoleById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
