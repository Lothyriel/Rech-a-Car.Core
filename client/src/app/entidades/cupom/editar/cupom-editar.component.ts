import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpCupomService } from 'src/app/shared/interfaces/IHttpCupomService';
import { IHttpParceiroService } from 'src/app/shared/interfaces/IHttppParceiroService';
import { CupomEditViewModel, CupomDetailsViewModel } from 'src/app/shared/viewModels/cupom';
import { ParceiroListViewModel } from 'src/app/shared/viewModels/parceiro';

@Component({
  selector: 'app-cupom-editar',
  templateUrl: './cupom-editar.component.html'
})
export class CupomEditarComponent implements OnInit {

  cadastroForm: FormGroup;
  id: any;
  cupom: CupomEditViewModel;
  listaParceiros: ParceiroListViewModel[];

  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpCupomServiceToken') private servicoCupom: IHttpCupomService,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private router: Router) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      meio: new FormControl(''),
      codigo: new FormControl(''),
      nome: new FormControl(''),
      valor: new FormControl(''),
      valorMinimo: new FormControl(''),
      validade: new FormControl(''),
      idParceiro: new FormControl(''),
      tipo: new FormControl('')
    });

    this.carregarParceiros();
    this.carregarCupom();
  }

  carregarParceiros(): void {
    this.servicoParceiro.obterParceiros()
      .subscribe(parceiros => {
        this.listaParceiros = parceiros;
      });
  }

  carregarCupom(): void {
    this.servicoCupom.obterCupomPorId(this.id)
      .subscribe((cupom: CupomDetailsViewModel) => {
        this.carregarFormulario(cupom);
      });
  }

  carregarFormulario(cupom: CupomDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(cupom.id),
    });
  }

  atualizarCupom() {
    this.cupom = Object.assign({}, this.cupom, this.cadastroForm.value);
    this.cupom.id = this.id;

    this.servicoCupom.editarCupom(this.cupom)
      .subscribe(() => {
        this.router.navigate(['cupom/listar']);
      });
  }

  cancelar(): void {
    this.router.navigate(['cupom/listar']);
  }
}