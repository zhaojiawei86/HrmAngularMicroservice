import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Candidate } from '../interface/candidate';
import { HttpClient } from '@angular/common/http'
import { environment } from '../environment/environment';

@Injectable({
  providedIn: 'root'
})
export class CandidateService {

  constructor(private http:HttpClient) { }
  candidateUrl:string = environment.url + 'candidate'

  saveCandidate(candidate:Candidate){
    return this.http.post(this.candidateUrl, candidate)

  }

  getAllCandidates():Observable<Candidate[]> {
    return this.http.get<Candidate[]>(this.candidateUrl)
  }

  deleteCandidateById(id:number){
    return this.http.delete(this.candidateUrl + '/' + id)
  }
}
