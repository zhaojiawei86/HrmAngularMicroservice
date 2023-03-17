import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Candidate } from 'src/app/interface/candidate';
import { CandidateService } from 'src/app/services/candidate.service';

@Component({
  selector: 'app-add-candidate',
  templateUrl: './add-candidate.component.html',
  styleUrls: ['./add-candidate.component.scss']
})
export class AddCandidateComponent {
  candidate:Candidate={
    id: 0,
    firstName: '',
    middleName: '',
    lastName: '',
    mobile: '',
    email: '',
    currentAddress: '',
    resumeUrl: '',
    fileName: ''
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private candidateService:CandidateService){}

  addCandidateFormGroup = this.fb.group({
    firstName: new FormControl('', [Validators.required]),
    middleName: new FormControl(''),
    lastName: new FormControl('', [Validators.required]),
    mobile: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required, Validators.email]),
    currentAddress: new FormControl('', [Validators.required]),
    resumeUrl: new FormControl(''),
    fileName: new FormControl()
  })

  get firstName() {
    return this.addCandidateFormGroup.get('firstName')
  }

  get middleName() {
    return this.addCandidateFormGroup.get('middleName')
  }

  get lastName() {
    return this.addCandidateFormGroup.get('lastName')
  }

  get mobile() {
    return this.addCandidateFormGroup.get('mobile')
  }

  get email() {
    return this.addCandidateFormGroup.get('email')
  }

  get currentAddress() {
    return this.addCandidateFormGroup.get('currentAddress')
  }

  get resumeUrl() {
    return this.addCandidateFormGroup.get('resumeUrl')
  }


  saveCandidate() {
    this.candidate.firstName=this.addCandidateFormGroup.value.firstName
    this.candidate.middleName=this.addCandidateFormGroup.value.middleName
    this.candidate.lastName=this.addCandidateFormGroup.value.lastName
    this.candidate.mobile=this.addCandidateFormGroup.value.mobile
    this.candidate.email=this.addCandidateFormGroup.value.email
    this.candidate.currentAddress=this.addCandidateFormGroup.value.currentAddress
    this.candidate.resumeUrl=this.addCandidateFormGroup.value.resumeUrl

    console.log(this.addCandidateFormGroup.value.resumeUrl)

    this.candidateService.saveCandidate(this.candidate).subscribe((data)=>{
      alert("candidate has been saved")
      this.addCandidateFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }

  fileUpload(target:any){
      console.log(target)
  }


}
