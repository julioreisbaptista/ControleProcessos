import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Tipoprocesso } from '../Model/tipoprocesso.model';

@Injectable({
  providedIn: 'root'
})
export class TipoprocessoService {

  private url = 'https://localhost:7250/api/ProcessoTipoes';


  constructor(private httpclient: HttpClient) {

  }

  getTipoprocesso() {
    return this.httpclient.get<Tipoprocesso[]>(this.url);
  }

  postTipoprocesso(tipoprocesso: Tipoprocesso) {
    return this.httpclient.post<Tipoprocesso>(this.url, tipoprocesso);

  }

  putTipoprocesso(tipoprocesso: Tipoprocesso) {
    return this.httpclient.put<Tipoprocesso>(this.url + '/', tipoprocesso);
  }

  deleteTipoprocesso(id: number) {
    return this.httpclient.delete<void>(this.url + '/'+  id);
  }
}
