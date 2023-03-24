import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../environment/environment';
import { Account } from '../interface/account';

@Injectable({
  providedIn: 'root'
})
export class AccountService {

  constructor(private http:HttpClient) { }
  accountUrl:string = environment.url + 'account'

  saveAccount(account:Account){
    return this.http.post(this.accountUrl, account)

  }

  getAllAccounts():Observable<Account[]> {
    return this.http.get<Account[]>(this.accountUrl)
  }

  deleteAccountById(id:number){
    return this.http.delete(this.accountUrl + '/' + id)
  }
}
