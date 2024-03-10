import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TermoscondicoesComponent } from './termoscondicoes.component';

describe('TermoscondicoesComponent', () => {
  let component: TermoscondicoesComponent;
  let fixture: ComponentFixture<TermoscondicoesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TermoscondicoesComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TermoscondicoesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
