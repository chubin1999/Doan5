import { TestBed } from '@angular/core/testing';

import { HangsanxuatService } from './hangsanxuat.service';

describe('HangsanxuatService', () => {
  let service: HangsanxuatService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HangsanxuatService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
