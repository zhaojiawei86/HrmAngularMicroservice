import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { SubmissionStatus } from 'src/app/interface/submissionstatus';
import { SubmissionStatusService } from 'src/app/services/submission-status.service';

@Component({
  selector: 'app-add-submission-status',
  templateUrl: './add-submission-status.component.html',
  styleUrls: ['./add-submission-status.component.scss']
})
export class AddSubmissionStatusComponent {
  submissionStatus:SubmissionStatus={
    id: 0,
    title: undefined,
    isActive: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private submissionStatusService:SubmissionStatusService){}

  addSubmissionStatusFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    isActive: new FormControl(false),
  })

  get title() {
    return this.addSubmissionStatusFormGroup.get('title')
  }

  get isActive() {
    return this.addSubmissionStatusFormGroup.get('isActive')
  }

  saveSubmissionStatus() {
    this.submissionStatus.title=this.addSubmissionStatusFormGroup.value.title
    this.submissionStatus.isActive=this.addSubmissionStatusFormGroup.value.isActive

    this.submissionStatusService.saveSubmissionStatus(this.submissionStatus).subscribe((data)=>{
      alert("submissionStatus has been saved")
      this.addSubmissionStatusFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }

}
