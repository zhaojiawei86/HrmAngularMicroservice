import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environment/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthenticatioinService {

  constructor(private httpClient: HttpClient) { }

  login(loginCredentials:any){
    return this.httpClient.post(environment.url + 'account', loginCredentials)
  }
}
