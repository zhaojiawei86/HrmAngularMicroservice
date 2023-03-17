import { Component, OnInit } from '@angular/core';
import { JobRequirement } from 'src/app/interface/jobrequirement';
import { JobRequirementService } from 'src/app/services/job-requirement.service';

@Component({
  selector: 'app-list-job-requirement',
  templateUrl: './list-job-requirement.component.html',
  styleUrls: ['./list-job-requirement.component.scss']
})
export class ListJobRequirementComponent implements OnInit {
  constructor(private jobRequirementService:JobRequirementService){}
  jobRequirementCollections:JobRequirement[] = []
  ngOnInit(): void {
      this.jobRequirementService.getAllJobRequirements().subscribe((data)=>{
        this.jobRequirementCollections = data;
      });
  }

  deleteJobRequirement(id:number){
    if(confirm("Are you sure to delete?")) {
      this.jobRequirementService.deleteJobRequirementById(id).subscribe((data)=>{
        window.location.reload()
      })
    }
  }
}
