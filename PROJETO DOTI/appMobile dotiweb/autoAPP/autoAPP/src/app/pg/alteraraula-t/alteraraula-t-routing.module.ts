import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AlteraraulaTPage } from './alteraraula-t.page';

const routes: Routes = [
  {
    path: '',
    component: AlteraraulaTPage
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AlteraraulaTPageRoutingModule {}
