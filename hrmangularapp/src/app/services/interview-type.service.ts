import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { InterviewType } from '../interface/interviewtype';

@Injectable({
  providedIn: 'root'
})
export class InterviewTypeService {

  constructor(private http:HttpClient) { }
  interviewTypeUrl:string = environment.interviewUrl + 'interviewType/'

  saveInterviewType(interviewType:InterviewType){
    return this.http.post(this.interviewTypeUrl, interviewType)

  }

  getAllInterviewTypes():Observable<InterviewType[]> {
    return this.http.get<InterviewType[]>(this.interviewTypeUrl)
  }

  deleteInterviewTypeById(id:number){
    return this.http.delete(this.interviewTypeUrl + id)
  }
}
