import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListEmployeeCategoryComponent } from './list-employee-category.component';

describe('ListEmployeeCategoryComponent', () => {
  let component: ListEmployeeCategoryComponent;
  let fixture: ComponentFixture<ListEmployeeCategoryComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListEmployeeCategoryComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListEmployeeCategoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
