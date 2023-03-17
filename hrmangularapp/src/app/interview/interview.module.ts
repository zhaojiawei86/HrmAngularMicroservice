import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { InterviewRoutingModule } from './interview-routing.module';
import { AddInterviewerComponent } from './add-interviewer/add-interviewer.component';
import { ListInterviewerComponent } from './list-interviewer/list-interviewer.component';
import { ListInterviewFeedbackComponent } from './list-interview-feedback/list-interview-feedback.component';
import { AddInterviewFeedbackComponent } from './add-interview-feedback/add-interview-feedback.component';
import { AddInterviewsComponent } from './add-interviews/add-interviews.component';
import { ListInterviewsComponent } from './list-interviews/list-interviews.component';
import { AddInterviewTypeComponent } from './add-interview-type/add-interview-type.component';
import { ListInterviewTypeComponent } from './list-interview-type/list-interview-type.component';
import { ListRecruiterComponent } from './list-recruiter/list-recruiter.component';
import { AddRecruiterComponent } from './add-recruiter/add-recruiter.component';
import { ReactiveFormsModule } from '@angular/forms';
import { InterviewerService } from '../services/interviewer.service';
import { InterviewFeedbackService } from '../services/interview-feedback.service';
import { InterviewsService } from '../services/interviews.service';
import { InterviewTypeService } from '../services/interview-type.service';
import { RecruiterService } from '../services/recruiter.service';


@NgModule({
  declarations: [
    AddInterviewerComponent,
    ListInterviewerComponent,
    ListInterviewFeedbackComponent,
    AddInterviewFeedbackComponent,
    AddInterviewsComponent,
    ListInterviewsComponent,
    AddInterviewTypeComponent,
    ListInterviewTypeComponent,
    ListRecruiterComponent,
    AddRecruiterComponent
  ],
  imports: [
    CommonModule,
    InterviewRoutingModule,
    ReactiveFormsModule
  ],
  providers:[
    InterviewerService,
    InterviewFeedbackService,
    InterviewsService,
    InterviewTypeService,
    RecruiterService
  ]
})
export class InterviewModule { }
