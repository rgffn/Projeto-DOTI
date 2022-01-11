import { NgModule } from '@angular/core';
import { PreloadAllModules, RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'perfil',
    pathMatch: 'full'
  },
  {
    path: 'home',
    loadChildren: () => import('./pg/home/home.module').then( m => m.HomePageModule)
  },
  {
    path: 'login',
    loadChildren: () => import('./pg/login/login.module').then( m => m.LoginPageModule)
  },
  {
    path: 'cadastro',
    loadChildren: () => import('./pg/cadastro/cadastro.module').then( m => m.CadastroPageModule)
  },
  {
    path: 'contato',
    loadChildren: () => import('./pg/contato/contato.module').then( m => m.ContatoPageModule)
  },
  {
    path: 'perfil',
    loadChildren: () => import('./pg/perfil/perfil.module').then( m => m.PerfilPageModule)
  },
  {
    path: 'servicos',
    loadChildren: () => import('./pg/servicos/servicos.module').then( m => m.ServicosPageModule)
  },
  {
    path: 'detalhe/:id',
    loadChildren: () => import('./pg/detalhe/detalhe.module').then( m => m.DetalhePageModule)
  },
  {
    path: 'quiz/:id',
    loadChildren: () => import('./pg/quiz/quiz.module').then( m => m.QuizPageModule)
  },
  {
    path: 'aulas/:id',
    loadChildren: () => import('./pg/aulas/aulas.module').then( m => m.AulasPageModule)
  },
  {
    path: 'inicio',
    loadChildren: () => import('./pg/inicio/inicio.module').then( m => m.InicioPageModule)
  },
  {
    path: 'alteraraula/:id',
    loadChildren: () => import('./pg/alteraraula/alteraraula.module').then( m => m.AlteraraulaPageModule)
  },
  {
    path: 'alteraraula-t/:id',
    loadChildren: () => import('./pg/alteraraula-t/alteraraula-t.module').then( m => m.AlteraraulaTPageModule)
  }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })
  ],
  exports: [RouterModule]
})
export class AppRoutingModule {}
