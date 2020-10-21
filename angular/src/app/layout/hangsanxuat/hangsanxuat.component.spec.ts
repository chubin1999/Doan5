import { async, TestBed } from '@angular/core/testing';
import { RouterTestingModule } from '@angular/router/testing';

import { HangsanxuatComponent } from './hangsanxuat.component';
import { HangsanxuatModule } from './hangsanxuat.module';

describe('HangsanxuatComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ HangsanxuatModule, RouterTestingModule ],
    })
    .compileComponents();
  }));

  it('should create', () => {
    const fixture = TestBed.createComponent(HangsanxuatComponent);
    const component = fixture.componentInstance;
    expect(component).toBeTruthy();
  });
});
