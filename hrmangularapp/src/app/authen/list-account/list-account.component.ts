import { Component, OnInit } from '@angular/core';
import { Account } from 'src/app/interface/account';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-list-account',
  templateUrl: './list-account.component.html',
  styleUrls: ['./list-account.component.scss']
})
export class ListAccountComponent implements OnInit{
  constructor(private accountService:AccountService){}
  accountCollections:Account[] = []
  ngOnInit(): void {
      this.accountService.getAllAccounts().subscribe((data)=>{
        this.accountCollections = data;
      });
  }

  deleteAccount(id:number){
    if(confirm("Are you sure to delete?")) {
      this.accountService.deleteAccountById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
