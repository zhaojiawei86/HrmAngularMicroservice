import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListInterviewFeedbackComponent } from './list-interview-feedback.component';

describe('ListInterviewFeedbackComponent', () => {
  let component: ListInterviewFeedbackComponent;
  let fixture: ComponentFixture<ListInterviewFeedbackComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListInterviewFeedbackComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListInterviewFeedbackComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
