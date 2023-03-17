import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { JobRequirement } from '../interface/jobrequirement';

@Injectable({
  providedIn: 'root'
})
export class JobRequirementService {

  constructor(private http:HttpClient) { }

  jobRequirementUrl:string = environment.recruitUrl + 'jobRequirement/'

  saveJobRequirement(jobRequirement:JobRequirement){
    return this.http.post(this.jobRequirementUrl, jobRequirement)

  }

  getAllJobRequirements():Observable<JobRequirement[]> {
    return this.http.get<JobRequirement[]>(this.jobRequirementUrl)
  }

  deleteJobRequirementById(id:number){
    return this.http.delete(this.jobRequirementUrl + id)

  }
}
