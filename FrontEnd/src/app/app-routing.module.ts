import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AreaComponent } from './area/area.component';
import { TipoprocessoComponent } from './tipoprocesso/tipoprocesso.component';
import { ProcessoComponent } from './processo/processo.component';

const routes: Routes = [
  { path: 'area', component: AreaComponent },
  { path: 'tipoprocesso', component: TipoprocessoComponent },
  { path: 'processo', component: ProcessoComponent },
  { path: '', redirectTo: '/area', pathMatch: 'full' } // Defina a rota padrão
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

