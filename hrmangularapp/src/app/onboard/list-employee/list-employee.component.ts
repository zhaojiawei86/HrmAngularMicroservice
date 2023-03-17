import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/interface/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-list-employee',
  templateUrl: './list-employee.component.html',
  styleUrls: ['./list-employee.component.scss']
})
export class ListEmployeeComponent implements OnInit{
  constructor(private employeeService:EmployeeService){}
  employeeCollections:Employee[] = []
  ngOnInit(): void {
      this.employeeService.getAllEmployees().subscribe((data)=>{
        this.employeeCollections = data;
      });
  }

  deleteEmployee(id:number){
    if(confirm("Are you sure to delete?")) {
      this.employeeService.deleteEmployeeById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
