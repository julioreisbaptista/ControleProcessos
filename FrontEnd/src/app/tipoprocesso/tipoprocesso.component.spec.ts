import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TipoprocessoComponent } from './tipoprocesso.component';

describe('TipoprocessoComponent', () => {
  let component: TipoprocessoComponent;
  let fixture: ComponentFixture<TipoprocessoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [TipoprocessoComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(TipoprocessoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
