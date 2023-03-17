import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListJobCategoryComponent } from './list-job-category.component';

describe('ListJobCategoryComponent', () => {
  let component: ListJobCategoryComponent;
  let fixture: ComponentFixture<ListJobCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListJobCategoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListJobCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
