import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { EmployeeCategory } from 'src/app/interface/employeecategory';
import { EmployeeCategoryService } from 'src/app/services/employee-category.service';

@Component({
  selector: 'app-add-employee-category',
  templateUrl: './add-employee-category.component.html',
  styleUrls: ['./add-employee-category.component.scss']
})
export class AddEmployeeCategoryComponent {
  employeeCategory:EmployeeCategory={
    id: 0,
    title: undefined,
    isActive: undefined,
    description: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private employeeCategoryService:EmployeeCategoryService){}

  addEmployeeCategoryFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    description: new FormControl('', [Validators.required]),
    isActive: new FormControl(false),
  })

  get title() {
    return this.addEmployeeCategoryFormGroup.get('title')
  }

  get description() {
    return this.addEmployeeCategoryFormGroup.get('description')
  }
  get isActive() {
    return this.addEmployeeCategoryFormGroup.get('isActive')
  }


  saveEmployeeCategory() {
    this.employeeCategory.title=this.addEmployeeCategoryFormGroup.value.title
    this.employeeCategory.description=this.addEmployeeCategoryFormGroup.value.description
    this.employeeCategory.isActive=this.addEmployeeCategoryFormGroup.value.isActive

    this.employeeCategoryService.saveEmployeeCategory(this.employeeCategory).subscribe((data)=>{
      alert("employeeCategory has been saved")
      this.addEmployeeCategoryFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
