import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChildreenComponent } from './childreen.component';

describe('ChildreenComponent', () => {
  let component: ChildreenComponent;
  let fixture: ComponentFixture<ChildreenComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChildreenComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChildreenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
