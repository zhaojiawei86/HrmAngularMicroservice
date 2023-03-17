import { Component, OnInit } from '@angular/core';
import { JobCategory } from 'src/app/interface/jobcategory';
import { JobCategoryService } from 'src/app/services/job-category.service';

@Component({
  selector: 'app-list-job-category',
  templateUrl: './list-job-category.component.html',
  styleUrls: ['./list-job-category.component.scss']
})
export class ListJobCategoryComponent implements OnInit {
  constructor(private jobCategoryService:JobCategoryService){}
  jobCategoryCollections:JobCategory[] = []
  ngOnInit(): void {
      this.jobCategoryService.getAllJobCategorys().subscribe((data)=>{
        this.jobCategoryCollections = data;
      });
  }

  deleteJobCategory(id:number){
    if(confirm("Are you sure to delete?")) {
      this.jobCategoryService.deleteJobCategoryById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
