import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Submission } from 'src/app/interface/submission';
import { SubmissionService } from 'src/app/services/submission.service';

@Component({
  selector: 'app-add-submission',
  templateUrl: './add-submission.component.html',
  styleUrls: ['./add-submission.component.scss']
})
export class AddSubmissionComponent {
  submission:Submission={
    id: 0,
    candidateId: undefined,
    jobRequirementId: undefined,
    appliedDate: undefined,
    confirmedOn: undefined,
    rejectedOn: undefined,
    submissionStatusId: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private submissionService:SubmissionService){}

  addSubmissionFormGroup = this.fb.group({
    candidateId: new FormControl('', [Validators.required]),
    jobRequirementId: new FormControl(''),
    appliedDate: new FormControl('', [Validators.required]),
    confirmedOn: new FormControl('', [Validators.required]),
    rejectedOn: new FormControl('', [Validators.required]),
    submissionStatusId: new FormControl('', [Validators.required]),
  })

  get candidateId() {
    return this.addSubmissionFormGroup.get('candidateId')
  }

  get jobRequirementId() {
    return this.addSubmissionFormGroup.get('jobRequirementId')
  }

  get appliedDate() {
    return this.addSubmissionFormGroup.get('appliedDate')
  }

  get confirmedOn() {
    return this.addSubmissionFormGroup.get('confirmedOn')
  }

  get rejectedOn() {
    return this.addSubmissionFormGroup.get('rejectedOn')
  }

  get submissionStatusId() {
    return this.addSubmissionFormGroup.get('submissionStatusId')
  }

  saveSubmission() {
    this.submission.candidateId=this.addSubmissionFormGroup.value.candidateId
    this.submission.jobRequirementId=this.addSubmissionFormGroup.value.jobRequirementId
    this.submission.appliedDate=this.addSubmissionFormGroup.value.appliedDate
    this.submission.confirmedOn=this.addSubmissionFormGroup.value.confirmedOn
    this.submission.rejectedOn=this.addSubmissionFormGroup.value.rejectedOn
    this.submission.submissionStatusId=this.addSubmissionFormGroup.value.submissionStatusId

    this.submissionService.saveSubmission(this.submission).subscribe((data)=>{
      alert("submission has been saved")
      this.addSubmissionFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }

}
