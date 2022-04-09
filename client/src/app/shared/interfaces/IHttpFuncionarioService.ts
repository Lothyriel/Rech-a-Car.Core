import { Observable } from "rxjs";
import { FuncionarioCreateViewModel, FuncionarioDetailsViewModel, FuncionarioEditViewModel, FuncionarioListViewModel } from "../viewModels/funcionario";

export interface IHttpFuncionarioService {

    obterFuncionarios(): Observable<FuncionarioListViewModel[]>

    adicionarFuncionario(Funcionario: FuncionarioCreateViewModel): Observable<FuncionarioCreateViewModel>

    obterFuncionarioPorId(FuncionarioId: number): Observable<FuncionarioDetailsViewModel>

    editarFuncionario(Funcionario: FuncionarioEditViewModel): Observable<FuncionarioEditViewModel>

    excluirFuncionario(FuncionarioId: number): Observable<number>
}