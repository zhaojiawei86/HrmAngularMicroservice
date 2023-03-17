import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { JobCategory } from 'src/app/interface/jobcategory';
import { JobCategoryService } from 'src/app/services/job-category.service';

@Component({
  selector: 'app-add-job-category',
  templateUrl: './add-job-category.component.html',
  styleUrls: ['./add-job-category.component.scss']
})
export class AddJobCategoryComponent {
  jobCategory:JobCategory={
    id: 0,
    title: undefined,
    isActive: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private jobCategoryService:JobCategoryService){}

  addJobCategoryFormGroup = this.fb.group({
    title: new FormControl('', [Validators.required]),
    isActive: new FormControl(false),
  })

  get title() {
    return this.addJobCategoryFormGroup.get('title')
  }

  get isActive() {
    return this.addJobCategoryFormGroup.get('isActive')
  }

  saveJobCategory() {
    this.jobCategory.title=this.addJobCategoryFormGroup.value.title
    this.jobCategory.isActive=this.addJobCategoryFormGroup.value.isActive

    this.jobCategoryService.saveJobCategory(this.jobCategory).subscribe((data)=>{
      alert("jobCategory has been saved")
      this.addJobCategoryFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
