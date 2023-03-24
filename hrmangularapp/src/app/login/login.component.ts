import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthenticatioinService } from '../services/authenticatioin.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  providers:[AuthenticatioinService]
})
export class LoginComponent {
  login={
    username:'',
    password:''
  }

  constructor(private authService: AuthenticatioinService, private router:Router){}
  data:any
  loginUser(loginForm:NgForm) {
    this.authService.login(loginForm.value).subscribe((d)=>{
      // console.log(d);
      this.data = d;
      localStorage.setItem("token", this.data.token)
      this.router.navigateByUrl('')
    })
  }

}
