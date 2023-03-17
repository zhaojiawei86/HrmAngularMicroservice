import { Component, OnInit } from '@angular/core';
import { EmployeeStatus } from 'src/app/interface/employeestatus';
import { EmployeeStatusService } from 'src/app/services/employee-status.service';

@Component({
  selector: 'app-list-employee-status',
  templateUrl: './list-employee-status.component.html',
  styleUrls: ['./list-employee-status.component.scss']
})
export class ListEmployeeStatusComponent implements OnInit{
  constructor(private employeeStatusService:EmployeeStatusService){}
  employeeStatusCollections:EmployeeStatus[] = []
  ngOnInit(): void {
      this.employeeStatusService.getAllEmployeeStatuss().subscribe((data)=>{
        this.employeeStatusCollections = data;
      });
  }

  deleteEmployeeStatus(id:number){
    if(confirm("Are you sure to delete?")) {
      this.employeeStatusService.deleteEmployeeStatusById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
