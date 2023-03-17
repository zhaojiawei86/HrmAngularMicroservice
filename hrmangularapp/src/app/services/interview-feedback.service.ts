import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { InterviewFeedback } from '../interface/interviewfeedback';

@Injectable({
  providedIn: 'root'
})
export class InterviewFeedbackService {

  constructor(private http:HttpClient) { }
  interviewFeedbackUrl:string = environment.interviewUrl + 'interviewFeedback/'

  saveInterviewFeedback(interviewFeedback:InterviewFeedback){
    return this.http.post(this.interviewFeedbackUrl, interviewFeedback)

  }

  getAllInterviewFeedbacks():Observable<InterviewFeedback[]> {
    return this.http.get<InterviewFeedback[]>(this.interviewFeedbackUrl)
  }

  deleteInterviewFeedbackById(id:number){
    return this.http.delete(this.interviewFeedbackUrl + id)
  }
}
