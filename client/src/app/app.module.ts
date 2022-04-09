import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FooterComponent } from './navegacao/footer/footer.component';
import { HeaderComponent } from './navegacao/header/header.component';
import { MenuComponent } from './navegacao/menu/menu.component';
import { HomeComponent } from './home/home.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { CupomCriarComponent } from './entidades/cupom/criar/cupom-criar.component';
import { CupomEditarComponent } from './entidades/cupom/editar/cupom-editar.component';
import { CupomListarComponent } from './entidades/cupom/listar/cupom-listar.component';
import { HttpCupomService } from './entidades/cupom/services/http-cupom-service';
import { FuncionarioCriarComponent } from './entidades/funcionario/criar/funcionario-criar.component';
import { FuncionarioEditarComponent } from './entidades/funcionario/editar/funcionario-editar.component';
import { FuncionarioListarComponent } from './entidades/funcionario/listar/funcionario-listar.component';
import { HttpFuncionarioService } from './entidades/funcionario/services/http-funcionario-service';
import { ParceiroCriarComponent } from './entidades/parceiro/criar/parceiro-criar.component';
import { ParceiroEditarComponent } from './entidades/parceiro/editar/parceiro-editar.component';
import { ParceiroListarComponent } from './entidades/parceiro/listar/parceiro-listar.component';
import { HttpParceiroService } from './entidades/parceiro/services/http-parceiro-service';
import { HttpServicoService } from './entidades/servico/services/http-servico-service';
import { ServicoCriarComponent } from './entidades/servico/criar/servico-criar.component';
import { ServicoListarComponent } from './entidades/servico/listar/servico-listar.component';
import { ServicoEditarComponent } from './entidades/servico/editar/servico-editar.component';
import { ToastContainerComponent } from './shared/components/toast-container/toast-container.component';
import { TesteListarComponent } from './entidade/teste/listar/teste-listar.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    MenuComponent,
    HomeComponent,
    ParceiroListarComponent,
    ParceiroCriarComponent,
    ParceiroEditarComponent,
    CupomListarComponent,
    CupomCriarComponent,
    CupomEditarComponent,
    FuncionarioCriarComponent,
    FuncionarioEditarComponent,
    FuncionarioListarComponent,
    ServicoCriarComponent,
    ServicoListarComponent,
    ServicoEditarComponent,
    ToastContainerComponent,
    TesteListarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    RouterModule,
    FormsModule,
    NgbModule
  ],
  providers: [
    { provide: 'IHttpParceiroServiceToken', useClass: HttpParceiroService },
    { provide: 'IHttpCupomServiceToken', useClass: HttpCupomService },
    { provide: 'IHttpFuncionarioServiceToken', useClass: HttpFuncionarioService },
    { provide: 'IHttpServicoServiceToken', useClass: HttpServicoService },
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }