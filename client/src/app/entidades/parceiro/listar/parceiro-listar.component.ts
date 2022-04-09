import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpParceiroService } from 'src/app/shared/interfaces/IHttppParceiroService';
import { ToastService } from 'src/app/shared/services/toast.service';
import { ParceiroListViewModel } from 'src/app/shared/viewModels/parceiro';

@Component({
  selector: 'app-listarparceiro',
  templateUrl: './parceiro-listar.component.html'
})
export class ParceiroListarComponent implements OnInit {

  listaParceirosTotal: ParceiroListViewModel[];
  listaParceiros: ParceiroListViewModel[];
  parceiroSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router,
    @Inject('IHttpParceiroServiceToken') private servicoParceiro: IHttpParceiroService,
    private servicoModal: NgbModal,
    private toastService: ToastService) {
  }

  ngOnInit(): void {
    this.obterParceiros();
  }

  obterParceiros(): void {
    this.servicoParceiro.obterParceiros()
      .subscribe(parceiros => {
        this.listaParceirosTotal = parceiros;
        this.atualizarParceiros();
      });
  }

  atualizarParceiros() {
    this.listaParceiros = this.listaParceirosTotal
      .map((parceiro, i) => ({ u: i + 1, ...parceiro }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaParceirosTotal.length;
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoParceiro.excluirParceiro(this.parceiroSelecionado)
          .subscribe(
            () => {
              this.toastService.show('Parceiro removido com sucesso!',
                { classname: 'bg-success text-light', delay: 5000 });

              setTimeout(() => {
                this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
                  this.router.navigate(['parceiro/listar']);
                });
              }, 5000);
            },
            erro => {
              this.toastService.show('Erro ao remover parceiro: ' + erro.error.errors["Nome"].toString(),
                { classname: 'bg-danger text-light', delay: 5000 });
            }
          );
      }
    }).catch(erro => erro);
  }
}