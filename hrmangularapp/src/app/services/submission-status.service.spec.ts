import { TestBed } from '@angular/core/testing';

import { SubmissionStatusService } from './submission-status.service';

describe('SubmissionStatusService', () => {
  let service: SubmissionStatusService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SubmissionStatusService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
