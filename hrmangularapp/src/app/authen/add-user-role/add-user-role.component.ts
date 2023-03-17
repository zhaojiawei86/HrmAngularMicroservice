import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { UserRole } from 'src/app/interface/userrole';
import { UserRoleService } from 'src/app/services/user-role.service';

@Component({
  selector: 'app-add-user-role',
  templateUrl: './add-user-role.component.html',
  styleUrls: ['./add-user-role.component.scss']
})
export class AddUserRoleComponent {
  userRole:UserRole={
    id: 0,
    roleId: undefined,
    accountId: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private userRoleService:UserRoleService){}

  addUserRoleFormGroup = this.fb.group({
    roleId: new FormControl('', [Validators.required]),
    accountId: new FormControl('', [Validators.required]),
  })

  get roleId() {
    return this.addUserRoleFormGroup.get('roleId')
  }

  get accountId() {
    return this.addUserRoleFormGroup.get('accountId')
  }


  saveUserRole() {
    this.userRole.roleId=this.addUserRoleFormGroup.value.roleId
    this.userRole.accountId=this.addUserRoleFormGroup.value.accountId

    this.userRoleService.saveUserRole(this.userRole).subscribe((data)=>{
      alert("userRole has been saved")
      this.addUserRoleFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
