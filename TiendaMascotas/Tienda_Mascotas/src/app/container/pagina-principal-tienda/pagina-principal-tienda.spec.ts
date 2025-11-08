import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PaginaPrincipalTienda } from './pagina-principal-tienda';

describe('PaginaPrincipalTienda', () => {
  let component: PaginaPrincipalTienda;
  let fixture: ComponentFixture<PaginaPrincipalTienda>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [PaginaPrincipalTienda]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PaginaPrincipalTienda);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
