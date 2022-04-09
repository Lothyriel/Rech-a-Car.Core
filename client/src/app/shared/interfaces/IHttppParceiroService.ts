import { Observable } from "rxjs";
import { ParceiroCreateViewModel, ParceiroDetailsViewModel, ParceiroEditViewModel, ParceiroListViewModel } from "../viewModels/parceiro";

export interface IHttpParceiroService {

    obterParceiros(): Observable<ParceiroListViewModel[]>

    adicionarParceiro(parceiro: ParceiroCreateViewModel): Observable<ParceiroCreateViewModel>

    obterParceiroPorId(parceiroId: number): Observable<ParceiroDetailsViewModel>

    editarParceiro(parceiro: ParceiroEditViewModel): Observable<ParceiroEditViewModel>

    excluirParceiro(parceiroId: number): Observable<number>
}