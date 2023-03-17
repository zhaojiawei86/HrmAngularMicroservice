import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { EmployeeStatus } from 'src/app/interface/employeestatus';
import { EmployeeStatusService } from 'src/app/services/employee-status.service';

@Component({
  selector: 'app-add-employee-status',
  templateUrl: './add-employee-status.component.html',
  styleUrls: ['./add-employee-status.component.scss']
})
export class AddEmployeeStatusComponent {
  employeeStatus:EmployeeStatus={
    id: 0,
    title: undefined,
    abbr: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private employeeStatusService:EmployeeStatusService){}

  addEmployeeStatusFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    abbr: new FormControl('', [Validators.required]),
  })

  get title() {
    return this.addEmployeeStatusFormGroup.get('title')
  }

  get abbr() {
    return this.addEmployeeStatusFormGroup.get('abbr')
  }



  saveEmployeeStatus() {
    this.employeeStatus.title=this.addEmployeeStatusFormGroup.value.title
    this.employeeStatus.abbr=this.addEmployeeStatusFormGroup.value.abbr

    this.employeeStatusService.saveEmployeeStatus(this.employeeStatus).subscribe((data)=>{
      alert("employeeStatus has been saved")
      this.addEmployeeStatusFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
