import { Component, OnInit } from '@angular/core';
import { Recruiter } from 'src/app/interface/recruiter';
import { RecruiterService } from 'src/app/services/recruiter.service';

@Component({
  selector: 'app-list-recruiter',
  templateUrl: './list-recruiter.component.html',
  styleUrls: ['./list-recruiter.component.scss']
})
export class ListRecruiterComponent implements OnInit{
  constructor(private recruiterService:RecruiterService){}
  recruiterCollections:Recruiter[] = []
  ngOnInit(): void {
      this.recruiterService.getAllRecruiters().subscribe((data)=>{
        this.recruiterCollections = data;
      });
  }

  deleteRecruiter(id:number){
    if(confirm("Are you sure to delete?")) {
      this.recruiterService.deleteRecruiterById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
