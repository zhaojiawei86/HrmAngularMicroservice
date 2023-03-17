import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddAccountComponent } from './add-account/add-account.component';
import { AddRoleComponent } from './add-role/add-role.component';
import { AddUserRoleComponent } from './add-user-role/add-user-role.component';
import { ListAccountComponent } from './list-account/list-account.component';
import { ListRoleComponent } from './list-role/list-role.component';
import { ListUserRoleComponent } from './list-user-role/list-user-role.component';

const routes: Routes = [
  {path:'add-account', component:AddAccountComponent},
  {path:'list-account', component:ListAccountComponent},
  {path:'add-role', component:AddRoleComponent},
  {path:'list-role', component:ListRoleComponent},
  {path:'add-userRole', component:AddUserRoleComponent},
  {path:'list-userRole', component:ListUserRoleComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthenRoutingModule { }
