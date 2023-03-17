import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AuthenRoutingModule } from './authen-routing.module';
import { AddAccountComponent } from './add-account/add-account.component';
import { ListAccountComponent } from './list-account/list-account.component';
import { AddRoleComponent } from './add-role/add-role.component';
import { ListRoleComponent } from './list-role/list-role.component';
import { AddUserRoleComponent } from './add-user-role/add-user-role.component';
import { ListUserRoleComponent } from './list-user-role/list-user-role.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AccountService } from '../services/account.service';
import { RoleService } from '../services/role.service';
import { UserRoleService } from '../services/user-role.service';


@NgModule({
  declarations: [
    AddAccountComponent,
    ListAccountComponent,
    AddRoleComponent,
    ListRoleComponent,
    AddUserRoleComponent,
    ListUserRoleComponent
  ],
  imports: [
    CommonModule,
    AuthenRoutingModule,
    ReactiveFormsModule
  ],
  providers:[
    AccountService,
    RoleService,
    UserRoleService
  ]
})
export class AuthenModule { }
