import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IHttpParceiroService } from 'src/app/shared/interfaces/IHttppParceiroService';
import { ParceiroCreateViewModel, ParceiroDetailsViewModel, ParceiroEditViewModel, ParceiroListViewModel } from 'src/app/shared/viewModels/parceiro';

@Injectable({
    providedIn: 'root'
})
export class HttpParceiroService implements IHttpParceiroService {

    private apiUrl = 'http://localhost:44340/api/parceiro';

    constructor(private http: HttpClient) { }

    public obterParceiros(): Observable<ParceiroListViewModel[]> {
        return this.http.get<ParceiroListViewModel[]>(`${this.apiUrl}`);
    }

    public adicionarParceiro(parceiro: ParceiroCreateViewModel): Observable<ParceiroCreateViewModel> {
        return this.http.post<ParceiroCreateViewModel>(this.apiUrl, parceiro);
    }

    public obterParceiroPorId(parceiroId: number): Observable<ParceiroDetailsViewModel> {
        return this.http.get<ParceiroDetailsViewModel>(`${this.apiUrl}/${parceiroId}`);
    }

    public editarParceiro(parceiro: ParceiroEditViewModel): Observable<ParceiroEditViewModel> {
        return this.http.put<ParceiroEditViewModel>(`${this.apiUrl}/${parceiro.id}`, parceiro);
    }

    public excluirParceiro(parceiroId: number): Observable<number> {
        return this.http.delete<number>(`${this.apiUrl}/${parceiroId}`);
    }
}