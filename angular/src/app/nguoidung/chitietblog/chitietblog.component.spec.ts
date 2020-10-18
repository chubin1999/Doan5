import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChitietblogComponent } from './chitietblog.component';

describe('ChitietblogComponent', () => {
  let component: ChitietblogComponent;
  let fixture: ComponentFixture<ChitietblogComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChitietblogComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChitietblogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
