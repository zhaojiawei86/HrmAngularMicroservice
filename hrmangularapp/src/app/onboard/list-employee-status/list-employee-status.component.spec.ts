import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmployeeStatusComponent } from './list-employee-status.component';

describe('ListEmployeeStatusComponent', () => {
  let component: ListEmployeeStatusComponent;
  let fixture: ComponentFixture<ListEmployeeStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmployeeStatusComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmployeeStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
