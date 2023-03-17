import { TestBed } from '@angular/core/testing';

import { InterviewFeedbackService } from './interview-feedback.service';

describe('InterviewFeedbackService', () => {
  let service: InterviewFeedbackService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InterviewFeedbackService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
