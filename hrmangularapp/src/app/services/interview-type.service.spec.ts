import { TestBed } from '@angular/core/testing';

import { InterviewTypeService } from './interview-type.service';

describe('InterviewTypeService', () => {
  let service: InterviewTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(InterviewTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
