import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Recruiter } from '../interface/recruiter';

@Injectable({
  providedIn: 'root'
})
export class RecruiterService {
  constructor(private http:HttpClient) { }
  recruiterUrl:string = environment.interviewUrl + 'recruiter/'

  saveRecruiter(recruiter:Recruiter){
    return this.http.post(this.recruiterUrl, recruiter)

  }

  getAllRecruiters():Observable<Recruiter[]> {
    return this.http.get<Recruiter[]>(this.recruiterUrl)
  }

  deleteRecruiterById(id:number){
    return this.http.delete(this.recruiterUrl + id)
  }
}
