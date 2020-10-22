import { TestBed } from '@angular/core/testing';

import { DanhmucsanphamService } from './danhmucsanpham.service';

describe('DanhmucsanphamService', () => {
  let service: DanhmucsanphamService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DanhmucsanphamService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
