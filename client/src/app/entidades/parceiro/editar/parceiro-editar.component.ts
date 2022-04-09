import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { IHttpParceiroService } from 'src/app/shared/interfaces/IHttppParceiroService';
import { ToastService } from 'src/app/shared/services/toast.service';
import { CupomListViewModel } from 'src/app/shared/viewModels/cupom';
import { ParceiroDetailsViewModel, ParceiroEditViewModel } from 'src/app/shared/viewModels/parceiro';

@Component({
  selector: 'app-parceiro-editar',
  templateUrl: './parceiro-editar.component.html'
})
export class ParceiroEditarComponent implements OnInit {

  sub: any;
  id: any;
  parceiro: ParceiroEditViewModel;
  cupons: CupomListViewModel[];
  cadastroForm: FormGroup;

  constructor(private _Activatedroute: ActivatedRoute,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private router: Router,
    private toastService: ToastService) { }

  ngOnInit(): void {
    this.id = this._Activatedroute.snapshot.paramMap.get("id");

    this.cadastroForm = new FormGroup({
      id: new FormControl(''),
      nome: new FormControl('')
    });

    this.carregarParceiro();
  }

  carregarParceiro() {
    this.servicoParceiro.obterParceiroPorId(this.id)
      .subscribe((parceiro: ParceiroDetailsViewModel) => {
        this.carregarFormulario(parceiro);
      });
  }

  atualizarParceiro() {
    this.parceiro = Object.assign({}, this.parceiro, this.cadastroForm.value);
    this.parceiro.id = this.id;

    this.servicoParceiro.editarParceiro(this.parceiro)
      .subscribe(
        parceiro => {
          this.toastService.show('Parceiro ' + parceiro.nome + ' editado com sucesso!',
            { classname: 'bg-success text-light', delay: 5000 });
          setTimeout(() => {
            this.router.navigate(['parceiro/listar']);
          }, 5000);
        },
        erro => {
          this.toastService.show('Erro ao editar parceiro: ' + erro.error.errors["Nome"].toString(),
            { classname: 'bg-danger text-light', delay: 5000 });
        });
  }

  cancelar(): void {
    this.router.navigate(['parceiro/listar']);
  }

  carregarFormulario(parceiro: ParceiroDetailsViewModel) {

    this.cadastroForm = new FormGroup({
      id: new FormControl(parceiro.id),
      nome: new FormControl(parceiro.nome, Validators.required),
    });

    this.cupons = parceiro.cupons;
  }
}