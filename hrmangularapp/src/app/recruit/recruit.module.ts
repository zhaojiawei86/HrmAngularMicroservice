import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RecruitRoutingModule } from './recruit-routing.module';
import { AddCandidateComponent } from './add-candidate/add-candidate.component';
import { ListCandidateComponent } from './list-candidate/list-candidate.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CandidateService } from '../services/candidate.service';
import { AddSubmissionComponent } from './add-submission/add-submission.component';
import { ListSubmissionComponent } from './list-submission/list-submission.component';
import { AddJobRequirementComponent } from './add-job-requirement/add-job-requirement.component';
import { ListJobRequirementComponent } from './list-job-requirement/list-job-requirement.component';
import { AddJobCategoryComponent } from './add-job-category/add-job-category.component';
import { ListJobCategoryComponent } from './list-job-category/list-job-category.component';
import { AddSubmissionStatusComponent } from './add-submission-status/add-submission-status.component';
import { ListSubmissionStatusComponent } from './list-submission-status/list-submission-status.component';
import { JobCategoryService } from '../services/job-category.service';
import { JobRequirementService } from '../services/job-requirement.service';
import { SubmissionService } from '../services/submission.service';
import { SubmissionStatusService } from '../services/submission-status.service';


@NgModule({
  declarations: [
    AddCandidateComponent,
    ListCandidateComponent,
    AddSubmissionComponent,
    ListSubmissionComponent,
    AddJobRequirementComponent,
    ListJobRequirementComponent,
    AddJobCategoryComponent,
    ListJobCategoryComponent,
    AddSubmissionStatusComponent,
    ListSubmissionStatusComponent,
  ],
  imports: [
    CommonModule,
    RecruitRoutingModule,
    ReactiveFormsModule
  ],
  providers:[
    CandidateService,
    JobCategoryService,
    JobRequirementService,
    SubmissionService,
    SubmissionStatusService
  ]
})
export class RecruitModule { }
