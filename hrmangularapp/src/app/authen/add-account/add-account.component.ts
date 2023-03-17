import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Account } from 'src/app/interface/account';
import { AccountService } from 'src/app/services/account.service';

@Component({
  selector: 'app-add-account',
  templateUrl: './add-account.component.html',
  styleUrls: ['./add-account.component.scss']
})
export class AddAccountComponent {
  account:Account={
    id: 0,
    firstName: undefined,
    lastName: undefined,
    emloyeeId: undefined,
    email: undefined,
    hashPassword: undefined,
    salt: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private accountService:AccountService){}

  addAccountFormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    emloyeeId: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    hashPassword: new FormControl('', [Validators.required]),
    salt: new FormControl('',[Validators.required]),
  })

  get firstName() {
    return this.addAccountFormGroup.get('firstName')
  }

  get lastName() {
    return this.addAccountFormGroup.get('lastName')
  }

  get emloyeeId() {
    return this.addAccountFormGroup.get('emloyeeId')
  }

  get email() {
    return this.addAccountFormGroup.get('email')
  }

  get hashPassword() {
    return this.addAccountFormGroup.get('hashPassword')
  }

  get salt() {
    return this.addAccountFormGroup.get('salt')
  }


  saveAccount() {
    this.account.firstName=this.addAccountFormGroup.value.firstName
    this.account.lastName=this.addAccountFormGroup.value.lastName
    this.account.emloyeeId=this.addAccountFormGroup.value.emloyeeId
    this.account.email=this.addAccountFormGroup.value.email
    this.account.hashPassword=this.addAccountFormGroup.value.hashPassword
    this.account.salt=this.addAccountFormGroup.value.salt

    console.log(this.addAccountFormGroup.value.salt)

    this.accountService.saveAccount(this.account).subscribe((data)=>{
      alert("account has been saved")
      this.addAccountFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
