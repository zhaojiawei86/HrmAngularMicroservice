import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddInterviewFeedbackComponent } from './add-interview-feedback/add-interview-feedback.component';
import { AddInterviewTypeComponent } from './add-interview-type/add-interview-type.component';
import { AddInterviewerComponent } from './add-interviewer/add-interviewer.component';
import { AddInterviewsComponent } from './add-interviews/add-interviews.component';
import { AddRecruiterComponent } from './add-recruiter/add-recruiter.component';
import { ListInterviewFeedbackComponent } from './list-interview-feedback/list-interview-feedback.component';
import { ListInterviewTypeComponent } from './list-interview-type/list-interview-type.component';
import { ListInterviewerComponent } from './list-interviewer/list-interviewer.component';
import { ListInterviewsComponent } from './list-interviews/list-interviews.component';
import { ListRecruiterComponent } from './list-recruiter/list-recruiter.component';

const routes: Routes = [
  {path:'add-interviewer', component:AddInterviewerComponent},
  {path:'list-interviewer', component:ListInterviewerComponent},
  {path:'add-interviewFeedback', component:AddInterviewFeedbackComponent},
  {path:'list-interviewFeedback', component:ListInterviewFeedbackComponent},
  {path:'add-interviews', component:AddInterviewsComponent},
  {path:'list-interviews', component:ListInterviewsComponent},
  {path:'add-interviewType', component:AddInterviewTypeComponent},
  {path:'list-interviewType', component:ListInterviewTypeComponent},
  {path:'add-recruiter', component:AddRecruiterComponent},
  {path:'list-recruiter', component:ListRecruiterComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InterviewRoutingModule { }
