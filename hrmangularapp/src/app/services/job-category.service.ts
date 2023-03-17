import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { JobCategory } from '../interface/jobcategory';

@Injectable({
  providedIn: 'root'
})
export class JobCategoryService {

  constructor(private http:HttpClient) { }
  jobCategoryUrl:string = environment.recruitUrl + 'jobCategory/'

  saveJobCategory(jobCategory:JobCategory){
    return this.http.post(this.jobCategoryUrl, jobCategory)
  }

  getAllJobCategorys():Observable<JobCategory[]> {
    return this.http.get<JobCategory[]>(this.jobCategoryUrl)
  }

  deleteJobCategoryById(id:number){
    return this.http.delete(this.jobCategoryUrl+ id)
  }
}
