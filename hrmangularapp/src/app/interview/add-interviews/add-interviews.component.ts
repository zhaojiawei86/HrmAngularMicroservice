import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Interviews } from 'src/app/interface/interviews';
import { InterviewsService } from 'src/app/services/interviews.service';

@Component({
  selector: 'app-add-interviews',
  templateUrl: './add-interviews.component.html',
  styleUrls: ['./add-interviews.component.scss']
})
export class AddInterviewsComponent {
  interviews:Interviews={
    id: 0,
    recruiterId: undefined,
    submissionId: undefined,
    interviewTypeId: undefined,
    interviewRound: undefined,
    interviewDate: undefined,
    interviewerId: undefined,
    interviewFeedbackId: undefined,
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private interviewsService:InterviewsService){}

  addInterviewsFormGroup = this.fb.group({
    recruiterId: new FormControl('', [Validators.required]),
    submissionId: new FormControl('', [Validators.required]),
    interviewTypeId: new FormControl('', [Validators.required]),
    interviewRound: new FormControl('', [Validators.required]),
    interviewDate: new FormControl('', [Validators.required]),
    interviewerId: new FormControl('', [Validators.required]),
    interviewFeedbackId: new FormControl('', [Validators.required]),
  })

  get recruiterId() {
    return this.addInterviewsFormGroup.get('recruiterId')
  }

  get submissionId() {
    return this.addInterviewsFormGroup.get('submissionId')
  }

  get interviewTypeId() {
    return this.addInterviewsFormGroup.get('interviewTypeId')
  }

  get interviewRound() {
    return this.addInterviewsFormGroup.get('interviewRound')
  }

  get interviewDate() {
    return this.addInterviewsFormGroup.get('interviewDate')
  }

  get interviewerId() {
    return this.addInterviewsFormGroup.get('interviewerId')
  }

  get interviewFeedbackId() {
    return this.addInterviewsFormGroup.get('interviewFeedbackId')
  }

  saveInterviews() {
    this.interviews.recruiterId=this.addInterviewsFormGroup.value.recruiterId
    this.interviews.submissionId=this.addInterviewsFormGroup.value.submissionId
    this.interviews.interviewTypeId=this.addInterviewsFormGroup.value.interviewTypeId
    this.interviews.interviewRound=this.addInterviewsFormGroup.value.interviewRound
    this.interviews.interviewDate=this.addInterviewsFormGroup.value.interviewDate
    this.interviews.interviewerId=this.addInterviewsFormGroup.value.interviewerId
    this.interviews.interviewFeedbackId=this.addInterviewsFormGroup.value.interviewFeedbackId


    this.interviewsService.saveInterviews(this.interviews).subscribe((data)=>{
      alert("interviews has been saved")
      this.addInterviewsFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
