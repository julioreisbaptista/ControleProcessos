import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Area } from '../Model/area.model';

@Injectable({
  providedIn: 'root'
})
export class AreaService {

  private url = 'https://localhost:7250/api/area';


  constructor(private httpclient: HttpClient) {

  }

  getAreas() {
    return this.httpclient.get<Area[]>(this.url);
  }

  postArea(area: Area) {
    return this.httpclient.post<Area>(this.url, area);

  }

  putArea(area: Area) {
    return this.httpclient.put<Area>(this.url + '/' , area);
  }

  deleteArea(id: number) {
    return this.httpclient.delete<void>(this.url + '/'+  id);
  }
}
