import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { OnboardRoutingModule } from './onboard-routing.module';
import { AddEmployeeComponent } from './add-employee/add-employee.component';
import { ListEmployeeComponent } from './list-employee/list-employee.component';
import { AddEmployeeCategoryComponent } from './add-employee-category/add-employee-category.component';
import { ListEmployeeCategoryComponent } from './list-employee-category/list-employee-category.component';
import { AddEmployeeRoleComponent } from './add-employee-role/add-employee-role.component';
import { ListEmployeeRoleComponent } from './list-employee-role/list-employee-role.component';
import { AddEmployeeStatusComponent } from './add-employee-status/add-employee-status.component';
import { ListEmployeeStatusComponent } from './list-employee-status/list-employee-status.component';
import { EmployeeService } from '../services/employee.service';
import { EmployeeCategoryService } from '../services/employee-category.service';
import { EmployeeRoleService } from '../services/employee-role.service';
import { EmployeeStatusService } from '../services/employee-status.service';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    AddEmployeeComponent,
    ListEmployeeComponent,
    AddEmployeeCategoryComponent,
    ListEmployeeCategoryComponent,
    AddEmployeeRoleComponent,
    ListEmployeeRoleComponent,
    AddEmployeeStatusComponent,
    ListEmployeeStatusComponent
  ],
  imports: [
    CommonModule,
    OnboardRoutingModule,
    ReactiveFormsModule
  ],
  providers:[
    EmployeeService,
    EmployeeCategoryService,
    EmployeeRoleService,
    EmployeeStatusService
  ]
})
export class OnboardModule { }
