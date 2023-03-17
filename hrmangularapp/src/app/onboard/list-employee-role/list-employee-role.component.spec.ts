import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmployeeRoleComponent } from './list-employee-role.component';

describe('ListEmployeeRoleComponent', () => {
  let component: ListEmployeeRoleComponent;
  let fixture: ComponentFixture<ListEmployeeRoleComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmployeeRoleComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmployeeRoleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
