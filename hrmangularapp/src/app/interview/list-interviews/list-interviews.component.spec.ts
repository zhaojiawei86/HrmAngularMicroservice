import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListInterviewsComponent } from './list-interviews.component';

describe('ListInterviewsComponent', () => {
  let component: ListInterviewsComponent;
  let fixture: ComponentFixture<ListInterviewsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListInterviewsComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListInterviewsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
