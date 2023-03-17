import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { JobRequirement } from 'src/app/interface/jobrequirement';
import { JobRequirementService } from 'src/app/services/job-requirement.service';

@Component({
  selector: 'app-add-job-requirement',
  templateUrl: './add-job-requirement.component.html',
  styleUrls: ['./add-job-requirement.component.scss']
})
export class AddJobRequirementComponent {
  jobRequirement:JobRequirement={
    id: 0,
    title: undefined,
    description: undefined,
    noOfPosition: undefined,
    hiringManagerId: undefined,
    hiringManagerName: undefined,
    createdOn: undefined,
    closedOn: undefined,
    startDate: undefined,
    isActive: undefined,
    jobCategoryId: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private jobRequirementService:JobRequirementService){}

  addJobRequirementFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    description: new FormControl('', [Validators.required]),
    noOfPosition: new FormControl('', [Validators.required]),
    hiringManagerId: new FormControl('', [Validators.required]),
    hiringManagerName: new FormControl('', [Validators.required]),
    createdOn: new FormControl('', [Validators.required]),
    closedOn: new FormControl('', [Validators.required]),
    startDate: new FormControl('', [Validators.required]),
    isActive: new FormControl(false),
    jobCategoryId: new FormControl('', [Validators.required]),
  })

  get title() {
    return this.addJobRequirementFormGroup.get('title')
  }

  get description() {
    return this.addJobRequirementFormGroup.get('description')
  }

  get noOfPosition() {
    return this.addJobRequirementFormGroup.get('noOfPosition')
  }

  get hiringManagerId() {
    return this.addJobRequirementFormGroup.get('hiringManagerId')
  }

  get hiringManagerName() {
    return this.addJobRequirementFormGroup.get('hiringManagerName')
  }

  get createdOn() {
    return this.addJobRequirementFormGroup.get('createdOn')
  }
  get closedOn() {
    return this.addJobRequirementFormGroup.get('closedOn')
  }
  get startDate() {
    return this.addJobRequirementFormGroup.get('startDate')
  }
  get isActive() {
    return this.addJobRequirementFormGroup.get('isActive')
  }
  get jobCategoryId() {
    return this.addJobRequirementFormGroup.get('jobCategoryId')
  }



  saveJobRequirement() {
    this.jobRequirement.title=this.addJobRequirementFormGroup.value.title
    this.jobRequirement.description=this.addJobRequirementFormGroup.value.description
    this.jobRequirement.noOfPosition=this.addJobRequirementFormGroup.value.noOfPosition
    this.jobRequirement.hiringManagerId=this.addJobRequirementFormGroup.value.hiringManagerId
    this.jobRequirement.hiringManagerName=this.addJobRequirementFormGroup.value.hiringManagerName
    this.jobRequirement.createdOn=this.addJobRequirementFormGroup.value.createdOn
    this.jobRequirement.closedOn=this.addJobRequirementFormGroup.value.closedOn
    this.jobRequirement.startDate=this.addJobRequirementFormGroup.value.startDate
    this.jobRequirement.isActive=this.addJobRequirementFormGroup.value.isActive
    this.jobRequirement.jobCategoryId=this.addJobRequirementFormGroup.value.jobCategoryId

    this.jobRequirementService.saveJobRequirement(this.jobRequirement).subscribe((data)=>{
      alert("jobRequirement has been saved")
      this.addJobRequirementFormGroup.reset()
    },(err)=>{
      console.log(err)
    })




  }
}
