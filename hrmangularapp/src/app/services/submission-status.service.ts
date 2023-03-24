import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { SubmissionStatus } from '../interface/submissionstatus';

@Injectable({
  providedIn: 'root'
})
export class SubmissionStatusService {

  constructor(private http:HttpClient) { }
  submissionStatusUrl:string = environment.url + 'submissionStatus'

  saveSubmissionStatus(submissionStatus:SubmissionStatus){
    return this.http.post(this.submissionStatusUrl, submissionStatus)
  }

  getAllSubmissionStatuss():Observable<SubmissionStatus[]> {
    return this.http.get<SubmissionStatus[]>(this.submissionStatusUrl)
  }

  deleteSubmissionStatusById(id:number){
    return this.http.delete(this.submissionStatusUrl+ '/' + id)
  }
}
