import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddInterviewTypeComponent } from './add-interview-type.component';

describe('AddInterviewTypeComponent', () => {
  let component: AddInterviewTypeComponent;
  let fixture: ComponentFixture<AddInterviewTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddInterviewTypeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AddInterviewTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
