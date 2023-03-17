import { Component, OnInit } from '@angular/core';
import { Interviewer } from 'src/app/interface/interviewer';
import { InterviewerService } from 'src/app/services/interviewer.service';

@Component({
  selector: 'app-list-interviewer',
  templateUrl: './list-interviewer.component.html',
  styleUrls: ['./list-interviewer.component.scss']
})
export class ListInterviewerComponent implements OnInit{
  constructor(private interviewerService:InterviewerService){}
  interviewerCollections:Interviewer[] = []
  ngOnInit(): void {
      this.interviewerService.getAllInterviewers().subscribe((data)=>{
        this.interviewerCollections = data;
      });
  }

  deleteInterviewer(id:number){
    if(confirm("Are you sure to delete?")) {
      this.interviewerService.deleteInterviewerById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
