import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginnguoidungComponent } from './loginnguoidung.component';

describe('LoginnguoidungComponent', () => {
  let component: LoginnguoidungComponent;
  let fixture: ComponentFixture<LoginnguoidungComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LoginnguoidungComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginnguoidungComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
