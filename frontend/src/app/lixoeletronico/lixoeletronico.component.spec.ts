import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LixoeletronicoComponent } from './lixoeletronico.component';

describe('LixoeletronicoComponent', () => {
  let component: LixoeletronicoComponent;
  let fixture: ComponentFixture<LixoeletronicoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LixoeletronicoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LixoeletronicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
