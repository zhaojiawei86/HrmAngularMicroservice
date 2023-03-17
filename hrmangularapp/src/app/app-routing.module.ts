import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MasterlayoutComponent } from './layout/masterlayout/masterlayout.component';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';

const routes: Routes = [
  {path:'', component:MasterlayoutComponent,
    children:[
      {path:'recruit', loadChildren:()=>import('./recruit/recruit.module').then(m=>m.RecruitModule)},
      {path:'interview', loadChildren:()=>import('./interview/interview.module').then(m=>m.InterviewModule )},
      {path:'onboard', loadChildren:()=>import('./onboard/onboard.module').then(m=>m.OnboardModule )},
      {path:'authen', loadChildren:()=>import('./authen/authen.module').then(m=>m.AuthenModule )}
    ]
  },
  {path:'login', component:LoginComponent},
  {path:'**', component:PageNotFoundComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
