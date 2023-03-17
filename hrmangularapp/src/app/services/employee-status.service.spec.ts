import { TestBed } from '@angular/core/testing';

import { EmployeeStatusService } from './employee-status.service';

describe('EmployeeStatusService', () => {
  let service: EmployeeStatusService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EmployeeStatusService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
