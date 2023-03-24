import { TestBed } from '@angular/core/testing';

import { AuthenticatioinService } from './authenticatioin.service';

describe('AuthenticatioinService', () => {
  let service: AuthenticatioinService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AuthenticatioinService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
