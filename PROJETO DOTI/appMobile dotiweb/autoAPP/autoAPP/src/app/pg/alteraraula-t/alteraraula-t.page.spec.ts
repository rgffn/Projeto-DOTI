import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { IonicModule } from '@ionic/angular';

import { AlteraraulaTPage } from './alteraraula-t.page';

describe('AlteraraulaTPage', () => {
  let component: AlteraraulaTPage;
  let fixture: ComponentFixture<AlteraraulaTPage>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ AlteraraulaTPage ],
      imports: [IonicModule.forRoot()]
    }).compileComponents();

    fixture = TestBed.createComponent(AlteraraulaTPage);
    component = fixture.componentInstance;
    fixture.detectChanges();
  }));

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
