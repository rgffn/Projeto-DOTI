import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { IonicModule } from '@ionic/angular';

import { HttpModule } from '@angular/http';

import { Routes, RouterModule } from '@angular/router';

import { QuizPageRoutingModule } from './quiz-routing.module';

import { QuizPage } from './quiz.page';

const routes: Routes = [
  {
    path:'',
    component: QuizPage
  }
];

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    IonicModule,
    QuizPageRoutingModule,
    HttpModule,
    RouterModule.forChild(routes)
  ],
  declarations: [QuizPage]
})
export class QuizPageModule {}
