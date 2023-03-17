import { Component, OnInit } from '@angular/core';
import { Role } from 'src/app/interface/role';
import { RoleService } from 'src/app/services/role.service';

@Component({
  selector: 'app-list-role',
  templateUrl: './list-role.component.html',
  styleUrls: ['./list-role.component.scss']
})
export class ListRoleComponent implements OnInit{
  constructor(private roleService:RoleService){}
  roleCollections:Role[] = []
  ngOnInit(): void {
      this.roleService.getAllRoles().subscribe((data)=>{
        this.roleCollections = data;
      });
  }

  deleteRole(id:number){
    if(confirm("Are you sure to delete?")) {
      this.roleService.deleteRoleById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
