import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { FaleConoscoComponent } from './faleconosco/faleconosco.component';
import { LixoEletronicoComponent } from './lixoeletronico/lixoeletronico.component';
import { SobreNosComponent } from './sobrenos/sobrenos.component';
import { TermosCondicoesComponent } from './termoscondicoes/termoscondicoes.component';

export const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'home', component: HomeComponent },
  { path: 'fale-conosco', component: FaleConoscoComponent },
  { path: 'lixo-eletronico', component: LixoEletronicoComponent },
  { path: 'sobre-nos', component: SobreNosComponent },
  { path: 'termos-condicoes', component: TermosCondicoesComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
