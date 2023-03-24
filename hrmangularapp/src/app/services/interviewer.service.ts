import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Interviewer } from '../interface/interviewer';

@Injectable({
  providedIn: 'root'
})
export class InterviewerService {

  constructor(private http:HttpClient) { }
  interviewerUrl:string = environment.url + 'interviewer'

  saveInterviewer(interviewer:Interviewer){
    return this.http.post(this.interviewerUrl, interviewer)
  }

  getAllInterviewers():Observable<Interviewer[]> {
    return this.http.get<Interviewer[]>(this.interviewerUrl)
  }

  deleteInterviewerById(id:number){
    return this.http.delete(this.interviewerUrl + '/' + id)
  }
}
