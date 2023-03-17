import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListInterviewerComponent } from './list-interviewer.component';

describe('ListInterviewerComponent', () => {
  let component: ListInterviewerComponent;
  let fixture: ComponentFixture<ListInterviewerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListInterviewerComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListInterviewerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
