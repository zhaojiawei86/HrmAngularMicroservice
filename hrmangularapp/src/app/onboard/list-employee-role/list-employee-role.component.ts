import { Component, OnInit } from '@angular/core';
import { EmployeeRole } from 'src/app/interface/employeerole';
import { EmployeeRoleService } from 'src/app/services/employee-role.service';

@Component({
  selector: 'app-list-employee-role',
  templateUrl: './list-employee-role.component.html',
  styleUrls: ['./list-employee-role.component.scss']
})
export class ListEmployeeRoleComponent implements OnInit{
  constructor(private employeeRoleService:EmployeeRoleService){}
  employeeRoleCollections:EmployeeRole[] = []
  ngOnInit(): void {
      this.employeeRoleService.getAllEmployeeRoles().subscribe((data)=>{
        this.employeeRoleCollections = data;
      });
  }

  deleteEmployeeRole(id:number){
    if(confirm("Are you sure to delete?")) {
      this.employeeRoleService.deleteEmployeeRoleById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
