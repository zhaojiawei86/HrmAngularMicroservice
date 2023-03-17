import { Component, OnInit } from '@angular/core';
import { SubmissionStatus } from 'src/app/interface/submissionstatus';
import { SubmissionStatusService } from 'src/app/services/submission-status.service';

@Component({
  selector: 'app-list-submission-status',
  templateUrl: './list-submission-status.component.html',
  styleUrls: ['./list-submission-status.component.scss']
})
export class ListSubmissionStatusComponent implements OnInit {
  constructor(private submissionStatusService:SubmissionStatusService){}
  submissionStatusCollections:SubmissionStatus[] = []
  ngOnInit(): void {
      this.submissionStatusService.getAllSubmissionStatuss().subscribe((data)=>{
        this.submissionStatusCollections = data;
      });
  }

  deleteSubmissionStatus(id:number){
    if(confirm("Are you sure to delete?")) {
      this.submissionStatusService.deleteSubmissionStatusById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
