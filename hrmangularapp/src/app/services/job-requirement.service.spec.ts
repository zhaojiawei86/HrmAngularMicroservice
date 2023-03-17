import { TestBed } from '@angular/core/testing';

import { JobRequirementService } from './job-requirement.service';

describe('JobRequirementService', () => {
  let service: JobRequirementService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(JobRequirementService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
