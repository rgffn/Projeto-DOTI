import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AlteraraulaPage } from './alteraraula.page';

const routes: Routes = [
  {
    path: '',
    component: AlteraraulaPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AlteraraulaPageRoutingModule {}
