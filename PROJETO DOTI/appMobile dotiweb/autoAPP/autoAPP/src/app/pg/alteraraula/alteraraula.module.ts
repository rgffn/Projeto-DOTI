import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AlteraraulaPageRoutingModule } from './alteraraula-routing.module';

import { HttpModule } from '@angular/http';

import { AlteraraulaPage } from './alteraraula.page';

import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    component: AlteraraulaPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    ReactiveFormsModule,
    HttpModule,
    RouterModule.forChild(routes)
  ],
  declarations: [AlteraraulaPage]
})
export class AlteraraulaPageModule {}
