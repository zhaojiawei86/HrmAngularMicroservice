import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { InterviewFeedback } from 'src/app/interface/interviewfeedback';
import { InterviewFeedbackService } from 'src/app/services/interview-feedback.service';

@Component({
  selector: 'app-add-interview-feedback',
  templateUrl: './add-interview-feedback.component.html',
  styleUrls: ['./add-interview-feedback.component.scss']
})
export class AddInterviewFeedbackComponent {
  interviewFeedback:InterviewFeedback={
    id: 0,
    raring: undefined,
    comment: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private interviewFeedbackService:InterviewFeedbackService){}

  addInterviewFeedbackFormGroup = this.fb.group({
    raring: new FormControl('', [Validators.required]),
    comment: new FormControl('', [Validators.required]),
  })

  get raring() {
    return this.addInterviewFeedbackFormGroup.get('raring')
  }

  get comment() {
    return this.addInterviewFeedbackFormGroup.get('comment')
  }

  saveInterviewFeedback() {
    this.interviewFeedback.raring=this.addInterviewFeedbackFormGroup.value.raring
    this.interviewFeedback.comment=this.addInterviewFeedbackFormGroup.value.comment

    this.interviewFeedbackService.saveInterviewFeedback(this.interviewFeedback).subscribe((data)=>{
      alert("interviewFeedback has been saved")
      this.addInterviewFeedbackFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }

}

