import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Interviewer } from 'src/app/interface/interviewer';
import { InterviewerService } from 'src/app/services/interviewer.service';

@Component({
  selector: 'app-add-interviewer',
  templateUrl: './add-interviewer.component.html',
  styleUrls: ['./add-interviewer.component.scss']
})
export class AddInterviewerComponent {
  interviewer:Interviewer={
    id: 0,
    firstName: undefined,
    lastName: undefined,
    employeeId: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private interviewerService:InterviewerService){}

  addInterviewerFormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    employeeId: new FormControl('', [Validators.required]),
  })

  get firstName() {
    return this.addInterviewerFormGroup.get('firstName')
  }

  get lastName() {
    return this.addInterviewerFormGroup.get('lastName')
  }

  get employeeId() {
    return this.addInterviewerFormGroup.get('employeeId')
  }



  saveInterviewer() {
    this.interviewer.firstName=this.addInterviewerFormGroup.value.firstName
    this.interviewer.lastName=this.addInterviewerFormGroup.value.lastName
    this.interviewer.employeeId=this.addInterviewerFormGroup.value.employeeId

    this.interviewerService.saveInterviewer(this.interviewer).subscribe((data)=>{
      alert("interviewer has been saved")
      this.addInterviewerFormGroup.reset()
    },(err)=>{
      console.log(err)
    })




  }
}
