import { Observable } from "rxjs";
import { CupomCreateViewModel, CupomDetailsViewModel, CupomEditViewModel, CupomListViewModel } from "../viewModels/cupom";

export interface IHttpCupomService {

    obterCupons(): Observable<CupomListViewModel[]>

    adicionarCupom(cupom: CupomCreateViewModel): Observable<CupomCreateViewModel>

    obterCupomPorId(cupomId: number): Observable<CupomDetailsViewModel>

    editarCupom(cupom: CupomEditViewModel): Observable<CupomEditViewModel>

    excluirCupom(cupomId: number): Observable<number>
}