import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-teste-listar',
  templateUrl: './teste-listar.component.html',
})
export class TesteListarComponent implements OnInit {
  obterResposta(): Observable<any> {
    return this.http.get<any>(`http://192.168.1.30:5000/api`);
  }

  constructor(private http: HttpClient) { }
  listaNodos = this.obterResposta()
  ngOnInit(): void {
  }

}

