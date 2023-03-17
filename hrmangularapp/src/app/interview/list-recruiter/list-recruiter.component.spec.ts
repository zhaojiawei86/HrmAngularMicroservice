import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListRecruiterComponent } from './list-recruiter.component';

describe('ListRecruiterComponent', () => {
  let component: ListRecruiterComponent;
  let fixture: ComponentFixture<ListRecruiterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListRecruiterComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListRecruiterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
