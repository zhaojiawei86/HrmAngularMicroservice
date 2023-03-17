import { Component, OnInit } from '@angular/core';
import { EmployeeCategory } from 'src/app/interface/employeecategory';
import { EmployeeCategoryService } from 'src/app/services/employee-category.service';

@Component({
  selector: 'app-list-employee-category',
  templateUrl: './list-employee-category.component.html',
  styleUrls: ['./list-employee-category.component.scss']
})
export class ListEmployeeCategoryComponent implements OnInit{
  constructor(private employeeCategoryService:EmployeeCategoryService){}
  employeeCategoryCollections:EmployeeCategory[] = []
  ngOnInit(): void {
      this.employeeCategoryService.getAllEmployeeCategorys().subscribe((data)=>{
        this.employeeCategoryCollections = data;
      });
  }

  deleteEmployeeCategory(id:number){
    if(confirm("Are you sure to delete?")) {
      this.employeeCategoryService.deleteEmployeeCategoryById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
