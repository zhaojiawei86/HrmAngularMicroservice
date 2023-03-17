import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCandidateComponent } from './add-candidate/add-candidate.component';
import { AddJobCategoryComponent } from './add-job-category/add-job-category.component';
import { AddJobRequirementComponent } from './add-job-requirement/add-job-requirement.component';
import { AddSubmissionStatusComponent } from './add-submission-status/add-submission-status.component';
import { AddSubmissionComponent } from './add-submission/add-submission.component';
import { ListCandidateComponent } from './list-candidate/list-candidate.component';
import { ListJobCategoryComponent } from './list-job-category/list-job-category.component';
import { ListJobRequirementComponent } from './list-job-requirement/list-job-requirement.component';
import { ListSubmissionStatusComponent } from './list-submission-status/list-submission-status.component';
import { ListSubmissionComponent } from './list-submission/list-submission.component';

const routes: Routes = [
  {path:'add-candidate', component:AddCandidateComponent},
  {path:'list-candidate', component:ListCandidateComponent},
  {path:'add-submission', component:AddSubmissionComponent},
  {path:'list-submission', component:ListSubmissionComponent},
  {path:'add-jobRequirement', component:AddJobRequirementComponent},
  {path:'list-jobRequirement', component:ListJobRequirementComponent},
  {path:'add-submissionStatus', component:AddSubmissionStatusComponent},
  {path:'list-submissionStatus', component:ListSubmissionStatusComponent},
  {path:'add-jobCategory', component:AddJobCategoryComponent},
  {path:'list-jobCategory', component:ListJobCategoryComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RecruitRoutingModule { }
