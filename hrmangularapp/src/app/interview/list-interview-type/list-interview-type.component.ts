import { Component } from '@angular/core';
import { InterviewType } from 'src/app/interface/interviewtype';
import { InterviewTypeService } from 'src/app/services/interview-type.service';

@Component({
  selector: 'app-list-interview-type',
  templateUrl: './list-interview-type.component.html',
  styleUrls: ['./list-interview-type.component.scss']
})
export class ListInterviewTypeComponent {
  constructor(private interviewTypeService:InterviewTypeService){}
  interviewTypeCollections:InterviewType[] = []
  ngOnInit(): void {
      this.interviewTypeService.getAllInterviewTypes().subscribe((data)=>{
        this.interviewTypeCollections = data;
      });
  }

  deleteInterviewType(id:number){
    if(confirm("Are you sure to delete?")) {
      this.interviewTypeService.deleteInterviewTypeById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
