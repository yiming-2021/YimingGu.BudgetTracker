import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AllExpenditureComponent } from './all-expenditure.component';

describe('AllExpenditureComponent', () => {
  let component: AllExpenditureComponent;
  let fixture: ComponentFixture<AllExpenditureComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AllExpenditureComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AllExpenditureComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
