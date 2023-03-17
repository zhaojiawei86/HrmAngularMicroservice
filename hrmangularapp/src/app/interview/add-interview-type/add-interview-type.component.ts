import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { InterviewType } from 'src/app/interface/interviewtype';
import { InterviewTypeService } from 'src/app/services/interview-type.service';

@Component({
  selector: 'app-add-interview-type',
  templateUrl: './add-interview-type.component.html',
  styleUrls: ['./add-interview-type.component.scss']
})
export class AddInterviewTypeComponent {
  interviewType:InterviewType={
    id: 0,
    title: undefined,
    isActive: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private interviewTypeService:InterviewTypeService){}

  addInterviewTypeFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    isActive: new FormControl(false),
  })

  get title() {
    return this.addInterviewTypeFormGroup.get('title')
  }

  get isActive() {
    return this.addInterviewTypeFormGroup.get('isActive')
  }

  saveInterviewType() {
    this.interviewType.title=this.addInterviewTypeFormGroup.value.title
    this.interviewType.isActive=this.addInterviewTypeFormGroup.value.isActive

    this.interviewTypeService.saveInterviewType(this.interviewType).subscribe((data)=>{
      alert("interviewType has been saved")
      this.addInterviewTypeFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
