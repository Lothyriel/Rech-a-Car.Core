import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IHttpFuncionarioService } from 'src/app/shared/interfaces/IHttpFuncionarioService';
import { FuncionarioCreateViewModel, FuncionarioDetailsViewModel, FuncionarioEditViewModel, FuncionarioListViewModel } from 'src/app/shared/viewModels/funcionario';

@Injectable({
    providedIn: 'root'
})
export class HttpFuncionarioService implements IHttpFuncionarioService {

    private apiUrl = 'http://localhost:44340/api/Funcionario';

    constructor(private http: HttpClient) { }

    public obterFuncionarios(): Observable<FuncionarioListViewModel[]> {
        return this.http.get<FuncionarioListViewModel[]>(`${this.apiUrl}`);
    }

    public adicionarFuncionario(Funcionario: FuncionarioCreateViewModel): Observable<FuncionarioCreateViewModel> {
        return this.http.post<FuncionarioCreateViewModel>(this.apiUrl, Funcionario);
    }

    public obterFuncionarioPorId(FuncionarioId: number): Observable<FuncionarioDetailsViewModel> {
        return this.http.get<FuncionarioDetailsViewModel>(`${this.apiUrl}/${FuncionarioId}`);
    }

    public editarFuncionario(Funcionario: FuncionarioEditViewModel): Observable<FuncionarioEditViewModel> {
        return this.http.put<FuncionarioEditViewModel>(`${this.apiUrl}/${Funcionario.id}`, Funcionario);
    }

    public excluirFuncionario(FuncionarioId: number): Observable<number> {
        return this.http.delete<number>(`${this.apiUrl}/${FuncionarioId}`);
    }
}