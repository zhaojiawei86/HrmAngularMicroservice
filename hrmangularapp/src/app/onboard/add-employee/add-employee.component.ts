import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Employee } from 'src/app/interface/employee';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.scss']
})
export class AddEmployeeComponent {
  employee:Employee={
    id: 0,
    firstName: undefined,
    middleName: undefined,
    lastName: undefined,
    ssn: undefined,
    hireDate: undefined,
    endDate: undefined,
    employeeCategoryId: undefined,
    employeeStatusId: undefined,
    address: undefined,
    email: undefined,
    employeeRoleId: undefined,
    dob: undefined,
    phone: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private employeeService:EmployeeService){}

  addEmployeeFormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    middleName: new FormControl(''),
    lastName: new FormControl('', [Validators.required]),
    ssn: new FormControl('', [Validators.required]),
    hireDate:new FormControl('', [Validators.required]),
    endDate:new FormControl('', [Validators.required]),
    employeeCategoryId:new FormControl('', [Validators.required]),
    employeeStatusId:new FormControl('', [Validators.required]),
    address: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    employeeRoleId:new FormControl('', [Validators.required]),
    dob:new FormControl('', [Validators.required]),
    phone:new FormControl('', [Validators.required]),
  })

  get firstName() {
    return this.addEmployeeFormGroup.get('firstName')
  }

  get middleName() {
    return this.addEmployeeFormGroup.get('middleName')
  }

  get lastName() {
    return this.addEmployeeFormGroup.get('lastName')
  }

  get ssn() {
    return this.addEmployeeFormGroup.get('ssn')
  }

  get email() {
    return this.addEmployeeFormGroup.get('email')
  }

  get address() {
    return this.addEmployeeFormGroup.get('address')
  }

  get hireDate() {
    return this.addEmployeeFormGroup.get('hireDate')
  }
  get endDate() {
    return this.addEmployeeFormGroup.get('endDate')
  }
  get employeeCategoryId() {
    return this.addEmployeeFormGroup.get('employeeCategoryId')
  }
  get employeeStatusId() {
    return this.addEmployeeFormGroup.get('employeeStatusId')
  }
  get employeeRoleId() {
    return this.addEmployeeFormGroup.get('employeeRoleId')
  }
  get dob() {
    return this.addEmployeeFormGroup.get('dob')
  }
  get phone() {
    return this.addEmployeeFormGroup.get('phone')
  }


  saveEmployee() {
    this.employee.firstName=this.addEmployeeFormGroup.value.firstName
    this.employee.middleName=this.addEmployeeFormGroup.value.middleName
    this.employee.lastName=this.addEmployeeFormGroup.value.lastName
    this.employee.ssn=this.addEmployeeFormGroup.value.ssn
    this.employee.email=this.addEmployeeFormGroup.value.email
    this.employee.address=this.addEmployeeFormGroup.value.address
    this.employee.employeeRoleId=this.addEmployeeFormGroup.value.employeeRoleId
    this.employee.hireDate=this.addEmployeeFormGroup.value.hireDate
    this.employee.endDate=this.addEmployeeFormGroup.value.endDate
    this.employee.employeeCategoryId=this.addEmployeeFormGroup.value.employeeCategoryId
    this.employee.employeeStatusId=this.addEmployeeFormGroup.value.employeeStatusId
    this.employee.dob=this.addEmployeeFormGroup.value.dob
    this.employee.phone=this.addEmployeeFormGroup.value.phone

    console.log(this.addEmployeeFormGroup.value.employeeRoleId)

    this.employeeService.saveEmployee(this.employee).subscribe((data)=>{
      alert("employee has been saved")
      this.addEmployeeFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
