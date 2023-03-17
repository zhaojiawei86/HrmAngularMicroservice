import { Component, OnInit } from '@angular/core';
import { InterviewFeedback } from 'src/app/interface/interviewfeedback';
import { InterviewFeedbackService } from 'src/app/services/interview-feedback.service';

@Component({
  selector: 'app-list-interview-feedback',
  templateUrl: './list-interview-feedback.component.html',
  styleUrls: ['./list-interview-feedback.component.scss']
})
export class ListInterviewFeedbackComponent implements OnInit{
  constructor(private interviewFeedbackService:InterviewFeedbackService){}
  interviewFeedbackCollections:InterviewFeedback[] = []
  ngOnInit(): void {
      this.interviewFeedbackService.getAllInterviewFeedbacks().subscribe((data)=>{
        this.interviewFeedbackCollections = data;
      });
  }

  deleteInterviewFeedback(id:number){
    if(confirm("Are you sure to delete?")) {
      this.interviewFeedbackService.deleteInterviewFeedbackById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
