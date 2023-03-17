import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddSubmissionStatusComponent } from './add-submission-status.component';

describe('AddSubmissionStatusComponent', () => {
  let component: AddSubmissionStatusComponent;
  let fixture: ComponentFixture<AddSubmissionStatusComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddSubmissionStatusComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddSubmissionStatusComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
