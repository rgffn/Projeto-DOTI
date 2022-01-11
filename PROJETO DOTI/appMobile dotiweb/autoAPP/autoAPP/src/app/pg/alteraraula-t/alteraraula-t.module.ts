import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { AlteraraulaTPageRoutingModule } from './alteraraula-t-routing.module';

import { HttpModule } from '@angular/http';

import { AlteraraulaTPage } from './alteraraula-t.page';

import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    component: AlteraraulaTPage
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
  declarations: [AlteraraulaTPage]
})
export class AlteraraulaTPageModule {}
