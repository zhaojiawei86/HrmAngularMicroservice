import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { Role } from 'src/app/interface/role';
import { RoleService } from 'src/app/services/role.service';

@Component({
  selector: 'app-add-role',
  templateUrl: './add-role.component.html',
  styleUrls: ['./add-role.component.scss']
})
export class AddRoleComponent {
  role:Role={
    id: 0,
    name: undefined,
    description: undefined
  }

  file:File | null = null;

  constructor(private fb:FormBuilder, private roleService:RoleService){}

  addRoleFormGroup = this.fb.group({
    name: new FormControl('', [Validators.required]),
    description: new FormControl('', [Validators.required]),
  })

  get name() {
    return this.addRoleFormGroup.get('name')
  }

  get description() {
    return this.addRoleFormGroup.get('description')
  }

  saveRole() {
    this.role.name=this.addRoleFormGroup.value.name
    this.role.description=this.addRoleFormGroup.value.description

    this.roleService.saveRole(this.role).subscribe((data)=>{
      alert("role has been saved")
      this.addRoleFormGroup.reset()
    },(err)=>{
      console.log(err)
    })
  }
}
