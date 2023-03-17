import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { EmployeeRole } from 'src/app/interface/employeerole';
import { EmployeeRoleService } from 'src/app/services/employee-role.service';

@Component({
  selector: 'app-add-employee-role',
  templateUrl: './add-employee-role.component.html',
  styleUrls: ['./add-employee-role.component.scss']
})
export class AddEmployeeRoleComponent {
  employeeRole:EmployeeRole={
    id: 0,
    title: undefined,
    abbr: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private employeeRoleService:EmployeeRoleService){}

  addEmployeeRoleFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    abbr: new FormControl('', [Validators.required]),
  })

  get title() {
    return this.addEmployeeRoleFormGroup.get('title')
  }

  get abbr() {
    return this.addEmployeeRoleFormGroup.get('abbr')
  }



  saveEmployeeRole() {
    this.employeeRole.title=this.addEmployeeRoleFormGroup.value.title
    this.employeeRole.abbr=this.addEmployeeRoleFormGroup.value.abbr

    this.employeeRoleService.saveEmployeeRole(this.employeeRole).subscribe((data)=>{
      alert("employeeRole has been saved")
      this.addEmployeeRoleFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
