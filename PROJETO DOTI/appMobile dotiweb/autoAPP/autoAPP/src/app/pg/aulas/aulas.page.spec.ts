import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { AulasPage } from './aulas.page';

describe('AulasPage', () => {
  let component: AulasPage;
  let fixture: ComponentFixture<AulasPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AulasPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(AulasPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
