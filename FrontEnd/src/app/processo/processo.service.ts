import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Processo } from '../Model/processo.model';

@Injectable({
  providedIn: 'root'
})
export class ProcessoService {

  private url = 'https://localhost:7250/api/Processo';


  constructor(private httpclient: HttpClient) {

  }

  getProcessos() {
    return this.httpclient.get<Processo[]>(this.url);
  }

  postProcesso(area: Processo) {
    return this.httpclient.post<Processo>(this.url, area);

  }

  putProcesso(processo: Processo) {
    return this.httpclient.put<Processo>(this.url + '/' , processo);
  }

  deleteProcesso(id: number) {
    return this.httpclient.delete<void>(this.url + '/'+  id);
  }
}
