import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { IonicModule } from '@ionic/angular';

import { AulasPageRoutingModule } from './aulas-routing.module';

import { AulasPage } from './aulas.page';

import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    component: AulasPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    RouterModule.forChild(routes),
    HttpModule
  ],
  declarations: [AulasPage]
})
export class AulasPageModule {}
