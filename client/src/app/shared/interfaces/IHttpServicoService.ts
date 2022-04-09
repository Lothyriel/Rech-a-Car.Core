import { Observable } from "rxjs";
import { ServicoCreateViewModel, ServicoDetailsViewModel, ServicoEditViewModel, ServicoListViewModel } from "../viewModels/servico";

export interface IHttpServicoService {

    obterServicos(): Observable<ServicoListViewModel[]>

    adicionarServico(Servico: ServicoCreateViewModel): Observable<ServicoCreateViewModel>

    obterServicoPorId(ServicoId: number): Observable<ServicoDetailsViewModel>

    editarServico(Servico: ServicoEditViewModel): Observable<ServicoEditViewModel>

    excluirServico(ServicoId: number): Observable<number>
}