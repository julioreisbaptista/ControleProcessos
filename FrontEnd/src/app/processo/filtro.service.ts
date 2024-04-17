import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { first } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class FiltroService {
  constructor() { }

  buscarItem<T>(observable: Observable<T>, filtro: (item: T) => boolean): Observable<T> {
    return observable.pipe(
      
      first(filtro)
    );
  }
}
