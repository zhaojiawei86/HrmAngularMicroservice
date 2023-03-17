import { TestBed } from '@angular/core/testing';

import { EmployeeCategoryService } from './employee-category.service';

describe('EmployeeCategoryService', () => {
  let service: EmployeeCategoryService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EmployeeCategoryService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
