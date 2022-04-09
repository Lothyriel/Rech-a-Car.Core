import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CupomCriarComponent } from './entidades/cupom/criar/cupom-criar.component';
import { CupomEditarComponent } from './entidades/cupom/editar/cupom-editar.component';
import { CupomListarComponent } from './entidades/cupom/listar/cupom-listar.component';
import { ParceiroCriarComponent } from './entidades/parceiro/criar/parceiro-criar.component';
import { ParceiroEditarComponent } from './entidades/parceiro/editar/parceiro-editar.component';
import { ParceiroListarComponent } from './entidades/parceiro/listar/parceiro-listar.component';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'parceiro/listar', component: ParceiroListarComponent },
  { path: 'parceiro/criar', component: ParceiroCriarComponent },
  { path: 'parceiro/editar/:id', component: ParceiroEditarComponent },
  { path: 'cupom/listar', component: CupomListarComponent },
  { path: 'cupom/criar', component: CupomCriarComponent },
  { path: 'cupom/editar/:id', component: CupomEditarComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }