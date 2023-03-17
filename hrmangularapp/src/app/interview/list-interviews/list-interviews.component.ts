import { Component, OnInit } from '@angular/core';
import { Interviews } from 'src/app/interface/interviews';
import { InterviewsService } from 'src/app/services/interviews.service';

@Component({
  selector: 'app-list-interviews',
  templateUrl: './list-interviews.component.html',
  styleUrls: ['./list-interviews.component.scss']
})
export class ListInterviewsComponent implements OnInit{
  constructor(private interviewsService:InterviewsService){}
  interviewsCollections:Interviews[] = []
  ngOnInit(): void {
      this.interviewsService.getAllInterviewss().subscribe((data)=>{
        this.interviewsCollections = data;
      });
  }

  deleteInterviews(id:number){
    if(confirm("Are you sure to delete?")) {
      this.interviewsService.deleteInterviewsById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
