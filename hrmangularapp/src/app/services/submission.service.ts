import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Submission } from '../interface/submission';

@Injectable({
  providedIn: 'root'
})
export class SubmissionService {

  constructor(private http:HttpClient) { }
  submissionUrl:string = environment.url + 'submission'

  saveSubmission(submission:Submission){
    return this.http.post(this.submissionUrl, submission)
  }

  getAllSubmissions():Observable<Submission[]> {
    return this.http.get<Submission[]>(this.submissionUrl)
  }

  deleteSubmissionById(id:number){
    return this.http.delete(this.submissionUrl+ '/' + id)
  }
}
