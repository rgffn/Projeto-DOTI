import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { HttpModule } from '@angular/http';

import { DetalhePage } from './detalhe.page';

import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    component: DetalhePage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    HttpModule,
    RouterModule.forChild(routes)
  ],
  declarations: [DetalhePage]
})
export class DetalhePageModule {}
