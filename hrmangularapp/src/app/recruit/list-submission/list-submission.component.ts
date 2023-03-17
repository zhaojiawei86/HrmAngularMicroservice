import { Component, OnInit } from '@angular/core';
import { Submission } from 'src/app/interface/submission';
import { SubmissionService } from 'src/app/services/submission.service';

@Component({
  selector: 'app-list-submission',
  templateUrl: './list-submission.component.html',
  styleUrls: ['./list-submission.component.scss']
})
export class ListSubmissionComponent implements OnInit{
  constructor(private submissionService:SubmissionService){}
  submissionCollections:Submission[] = []
  ngOnInit(): void {
      this.submissionService.getAllSubmissions().subscribe((data)=>{
        this.submissionCollections = data;
      });
  }

  deleteSubmission(id:number){
    if(confirm("Are you sure to delete?")) {
      this.submissionService.deleteSubmissionById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
