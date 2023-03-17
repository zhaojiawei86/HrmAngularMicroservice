import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Recruiter } from 'src/app/interface/recruiter';
import { RecruiterService } from 'src/app/services/recruiter.service';

@Component({
  selector: 'app-add-recruiter',
  templateUrl: './add-recruiter.component.html',
  styleUrls: ['./add-recruiter.component.scss']
})
export class AddRecruiterComponent {
  recruiter:Recruiter={
    id: 0,
    firstName: undefined,
    lastName: undefined,
    employeeId: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private recruiterService:RecruiterService){}

  addRecruiterFormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    employeeId: new FormControl('', [Validators.required]),
  })

  get firstName() {
    return this.addRecruiterFormGroup.get('firstName')
  }

  get lastName() {
    return this.addRecruiterFormGroup.get('lastName')
  }

  get employeeId() {
    return this.addRecruiterFormGroup.get('employeeId')
  }



  saveRecruiter() {
    this.recruiter.firstName=this.addRecruiterFormGroup.value.firstName
    this.recruiter.lastName=this.addRecruiterFormGroup.value.lastName
    this.recruiter.employeeId=this.addRecruiterFormGroup.value.employeeId

    this.recruiterService.saveRecruiter(this.recruiter).subscribe((data)=>{
      alert("recruiter has been saved")
      this.addRecruiterFormGroup.reset()
    },(err)=>{
      console.log(err)
    })




  }
}
