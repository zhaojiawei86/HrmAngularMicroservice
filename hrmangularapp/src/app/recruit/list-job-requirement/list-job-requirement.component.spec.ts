import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListJobRequirementComponent } from './list-job-requirement.component';

describe('ListJobRequirementComponent', () => {
  let component: ListJobRequirementComponent;
  let fixture: ComponentFixture<ListJobRequirementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListJobRequirementComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListJobRequirementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
