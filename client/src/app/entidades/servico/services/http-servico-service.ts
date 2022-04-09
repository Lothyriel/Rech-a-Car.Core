import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IHttpServicoService } from 'src/app/shared/interfaces/IHttpServicoService';
import { ServicoCreateViewModel, ServicoDetailsViewModel, ServicoEditViewModel, ServicoListViewModel } from 'src/app/shared/viewModels/servico';

@Injectable({
    providedIn: 'root'
})
export class HttpServicoService implements IHttpServicoService {

    private apiUrl = 'http://localhost:44340/api/servico';

    constructor(private http: HttpClient) { }

    public obterServicos(): Observable<ServicoListViewModel[]> {
        return this.http.get<ServicoListViewModel[]>(`${this.apiUrl}`);
    }

    public adicionarServico(Servico: ServicoCreateViewModel): Observable<ServicoCreateViewModel> {
        return this.http.post<ServicoCreateViewModel>(this.apiUrl, Servico);
    }

    public obterServicoPorId(ServicoId: number): Observable<ServicoDetailsViewModel> {
        return this.http.get<ServicoDetailsViewModel>(`${this.apiUrl}/${ServicoId}`);
    }

    public editarServico(Servico: ServicoEditViewModel): Observable<ServicoEditViewModel> {
        return this.http.put<ServicoEditViewModel>(`${this.apiUrl}/${Servico.id}`, Servico);
    }

    public excluirServico(ServicoId: number): Observable<number> {
        return this.http.delete<number>(`${this.apiUrl}/${ServicoId}`);
    }
}