import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddInterviewerComponent } from './add-interviewer.component';

describe('AddInterviewerComponent', () => {
  let component: AddInterviewerComponent;
  let fixture: ComponentFixture<AddInterviewerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddInterviewerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddInterviewerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
