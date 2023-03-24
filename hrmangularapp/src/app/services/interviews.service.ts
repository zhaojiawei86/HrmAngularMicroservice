import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Interviews } from '../interface/interviews';

@Injectable({
  providedIn: 'root'
})
export class InterviewsService {
  constructor(private http:HttpClient) { }
  interviewsUrl:string = environment.url + 'interviews'

  saveInterviews(interviews:Interviews){
    return this.http.post(this.interviewsUrl, interviews)

  }

  getAllInterviewss():Observable<Interviews[]> {
    return this.http.get<Interviews[]>(this.interviewsUrl)
  }

  deleteInterviewsById(id:number){
    return this.http.delete(this.interviewsUrl + '/' + id)
  }
}
