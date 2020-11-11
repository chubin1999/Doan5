import { TestBed } from '@angular/core/testing';

import { ChitietdondathangService } from './chitietdondathang.service';

describe('ChitietdondathangService', () => {
  let service: ChitietdondathangService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChitietdondathangService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
