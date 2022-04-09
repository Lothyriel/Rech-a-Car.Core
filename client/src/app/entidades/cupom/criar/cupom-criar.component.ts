import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { IHttpCupomService } from 'src/app/shared/interfaces/IHttpCupomService';
import { IHttpParceiroService } from 'src/app/shared/interfaces/IHttppParceiroService';
import { CupomCreateViewModel } from 'src/app/shared/viewModels/cupom';
import { ParceiroListViewModel } from 'src/app/shared/viewModels/parceiro';

@Component({
  selector: 'app-cupom-criar',
  templateUrl: './cupom-criar.component.html'
})
export class CupomCriarComponent implements OnInit {

  cadastroForm: FormGroup;

  cupom: CupomCreateViewModel;
  listaParceiros: ParceiroListViewModel[];

  constructor(@Inject('IHttpCupomServiceToken') private servicoCupom: IHttpCupomService,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private router: Router) { }

  ngOnInit(): void {
    this.cadastroForm = new FormGroup({
      nome: new FormControl(''),
      codigo: new FormControl(''),
      valor: new FormControl(''),
      tipo: new FormControl(''),
      validade: new FormControl(''),
      idParceiro: new FormControl(''),
      meio: new FormControl(''),
      valorMinimo: new FormControl(''),
    });

    this.carregarParceiros();
  }

  adicionarCupom() {
    this.cupom = Object.assign({}, this.cupom, this.cadastroForm.value);

    this.servicoCupom.adicionarCupom(this.cupom)
      .subscribe(() => {
        this.router.navigate(['cupom/listar']);
      });
  }

  carregarParceiros(): void {
    this.servicoParceiro.obterParceiros()
      .subscribe(parceiros => {
        this.listaParceiros = parceiros;
      });
  }

  cancelar(): void {
    this.router.navigate(['cupom/listar']);
  }
}