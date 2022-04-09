import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpCupomService } from 'src/app/shared/interfaces/IHttpCupomService';
import { CupomListViewModel } from 'src/app/shared/viewModels/cupom';

@Component({
  selector: 'app-cupom-listar',
  templateUrl: './cupom-listar.component.html'
})
export class CupomListarComponent implements OnInit {

  listaCupons: CupomListViewModel[];
  listaCuponsTotal: CupomListViewModel[];
  cupomSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpCupomServiceToken') private servicoCupom: IHttpCupomService, private servicoModal: NgbModal) { }

  ngOnInit(): void {
    this.obterCupons();
  }

  obterCupons(): void {
    this.servicoCupom.obterCupons()
      .subscribe(cupons => {
        this.listaCuponsTotal = cupons;
        this.atualizarCupons();
      });
  }

  atualizarCupons() {
    this.listaCupons = this.listaCuponsTotal
      .map((cupom, i) => ({ u: i + 1, ...cupom }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaCuponsTotal.length;
  }

  formatarData(data: Date): string {
    return new Date(data).toLocaleDateString();
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoCupom.excluirCupom(this.cupomSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['cupom/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
}