import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddEmployeeStatusComponent } from './add-employee-status.component';

describe('AddEmployeeStatusComponent', () => {
  let component: AddEmployeeStatusComponent;
  let fixture: ComponentFixture<AddEmployeeStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddEmployeeStatusComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddEmployeeStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
