import { TestBed } from '@angular/core/testing';

import { DondathangService } from './dondathang.service';

describe('DondathangService', () => {
  let service: DondathangService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DondathangService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
