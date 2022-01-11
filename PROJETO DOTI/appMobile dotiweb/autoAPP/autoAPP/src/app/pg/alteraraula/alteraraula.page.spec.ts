import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { AlteraraulaPage } from './alteraraula.page';

describe('AlteraraulaPage', () => {
  let component: AlteraraulaPage;
  let fixture: ComponentFixture<AlteraraulaPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlteraraulaPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(AlteraraulaPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
