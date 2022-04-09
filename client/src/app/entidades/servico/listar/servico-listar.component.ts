import { Component, Inject, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { IHttpServicoService } from 'src/app/shared/interfaces/IHttpServicoService';
import { ServicoListViewModel } from 'src/app/shared/viewModels/servico';

@Component({
  selector: 'app-servico-listar',
  templateUrl: './servico-listar.component.html'
})
export class ServicoListarComponent implements OnInit {

  listaServicos: ServicoListViewModel[];
  listaServicosTotal: ServicoListViewModel[];
  ServicoSelecionado: any;

  page = 1;
  pageSize = 5;
  collectionSize = 0;

  constructor(private router: Router, @Inject('IHttpServicoServiceToken') private servicoServico: IHttpServicoService, private servicoModal: NgbModal) { }

  ngOnInit(): void {
    this.obterservicos();
  }

  obterservicos(): void {
    this.servicoServico.obterServicos()
      .subscribe(servicos => {
        this.listaServicosTotal = servicos;
        this.atualizarservicos();
      });
  }

  atualizarservicos() {
    this.listaServicos = this.listaServicosTotal
      .map((Servico, i) => ({ u: i + 1, ...Servico }))
      .slice((this.page - 1) * this.pageSize, (this.page - 1) * this.pageSize + this.pageSize);

    this.collectionSize = this.listaServicosTotal.length;
  }

  formatarData(data: Date): string {
    return new Date(data).toLocaleDateString();
  }

  abrirConfirmacao(modal: any) {
    this.servicoModal.open(modal).result.then((resultado) => {
      if (resultado == 'Excluir') {
        this.servicoServico.excluirServico(this.ServicoSelecionado)
          .subscribe(() => {
            this.router.navigateByUrl('/', { skipLocationChange: true }).then(() => {
              this.router.navigate(['servico/listar']);
            });
          });
      }
    }).catch(erro => erro);
  }
}