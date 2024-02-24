import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EventoListaComponent } from './EventoListaComponent';

describe('EventoListaComponent', () => {
  let component: EventoListaComponent;
  let fixture: ComponentFixture<EventoListaComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [EventoListaComponent]
    });
    fixture = TestBed.createComponent(EventoListaComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
