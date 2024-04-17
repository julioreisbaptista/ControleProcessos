import { Component } from '@angular/core';
import { TipoprocessoService } from './tipoprocesso.service';
import { Tipoprocesso } from '../Model/tipoprocesso.model';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-tipoprocesso',
  templateUrl: './tipoprocesso.component.html',
  styleUrl: './tipoprocesso.component.css'
})
export class TipoprocessoComponent {


  id = 0;
  nome = '';
  


  //Areas: Area[] = [];
  Tipoprocesso$: Observable<Tipoprocesso[]> = new Observable<Tipoprocesso[]>();

  constructor(private tipoprocessoService: TipoprocessoService) {
    this.getTipoprocessoCad();
  }

  getTipoprocessoCad() {
    //this.areaService.getAreas()
    //  .subscribe(Areas => this.Areas = Areas)
    this.Tipoprocesso$ = this.tipoprocessoService.getTipoprocesso();
  }
  buttonClick() {
    if (!this.nome)
      return;

    if (this.id) {
      this.tipoprocessoService.putTipoprocesso({ id: this.id, nome: this.nome })
        .subscribe(_ => this.getTipoprocessoCad());
      return
    }

    this.tipoprocessoService.postTipoprocesso({ id: this.id, nome: this.nome })
      .subscribe(_ => this.getTipoprocessoCad())

  }

  changeForm(tipoprocesso: Tipoprocesso) {
    this.id = tipoprocesso.id as number;
    this.nome = tipoprocesso.nome;
  }

  putTipoprocesso(tipoprocesso: Tipoprocesso) {
    if (!this.nome)
      return;

    this.tipoprocessoService.putTipoprocesso(tipoprocesso)
      .subscribe(_ => this.getTipoprocessoCad());
  }
  deleteTipoprocesso(id: number) {
    this.tipoprocessoService.deleteTipoprocesso(id)
      .subscribe(_ => this.getTipoprocessoCad());
  }



}



