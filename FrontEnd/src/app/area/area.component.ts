import { Component } from '@angular/core';
import { AreaService } from './area.service';
import { Area } from '../Model/area.model';
import { Observable } from 'rxjs';



@Component({
  selector: 'app-area',
  templateUrl: './area.component.html',
  styleUrl: './area.component.css'
})
export class AreaComponent {

  id = 0;
  nome = '';


  //Areas: Area[] = [];
  Areas$ = new Observable<Area[]>();

  restartForm() {

    this.id = 0;
    this.nome = '';
  }

  constructor(private areaService: AreaService) {
    this.getAreasCad();
  }

  getAreasCad() {
    //this.areaService.getAreas()
    //  .subscribe(Areas => this.Areas = Areas)
    this.Areas$ = this.areaService.getAreas();
  }
  buttonClick() {
    if (!this.nome)
      return;

      if (this.id) {
        this.areaService.putArea({ id: this.id, nome: this.nome })
          .subscribe(_ => this.getAreasCad());
          return
      }

    this.areaService.postArea({ id: this.id, nome: this.nome })
      .subscribe(_ => this.getAreasCad())

  }

  changeForm(area: Area) {
    this.id = area.id as number;
    this.nome = area.nome;
  }

  putArea(area: Area) {
    if (!this.nome)
      return;

    this.areaService.putArea(area)
      .subscribe(_ => this.getAreasCad());
  }
  deleteArea(id: number) {
    this.areaService.deleteArea(id)
      .subscribe(_ => this.getAreasCad());
  }
  

}

