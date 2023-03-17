import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeCategoryComponent } from './add-employee-category/add-employee-category.component';
import { AddEmployeeRoleComponent } from './add-employee-role/add-employee-role.component';
import { AddEmployeeStatusComponent } from './add-employee-status/add-employee-status.component';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { ListEmployeeCategoryComponent } from './list-employee-category/list-employee-category.component';
import { ListEmployeeRoleComponent } from './list-employee-role/list-employee-role.component';
import { ListEmployeeStatusComponent } from './list-employee-status/list-employee-status.component';
import { ListEmployeeComponent } from './list-employee/list-employee.component';

const routes: Routes = [
  {path:'add-employee', component:AddEmployeeComponent},
  {path:'list-employee', component:ListEmployeeComponent},
  {path:'add-employeeCategory', component:AddEmployeeCategoryComponent},
  {path:'list-employeeCategory', component:ListEmployeeCategoryComponent},
  {path:'add-employeeRole', component:AddEmployeeRoleComponent},
  {path:'list-employeeRole', component:ListEmployeeRoleComponent},
  {path:'add-employeeStatus', component:AddEmployeeStatusComponent},
  {path:'list-employeeStatus', component:ListEmployeeStatusComponent},
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class OnboardRoutingModule { }
