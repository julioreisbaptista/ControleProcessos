import { Component } from '@angular/core';
import { ProcessoService } from './processo.service';
import { AreaService } from '../area/area.service';
import { TipoprocessoService } from '../tipoprocesso/tipoprocesso.service';
import { Processo } from '../Model/processo.model';
import { Area } from '../Model/area.model';
import { Tipoprocesso } from '../Model/tipoprocesso.model';

import { Observable } from 'rxjs';
import { filter, first } from 'rxjs/operators';

@Component({
  selector: 'app-processo',
  templateUrl: './processo.component.html',
  styleUrl: './processo.component.css'
})
export class ProcessoComponent {

  id = 0;
  nome = '';
  areaid = 0;
  processotipoid = 0;
  subprocessos = '';

  

  //Processos: Processo[] = [];
  Processos$ = new Observable<Processo[]>();
  Areas$ = new Observable<Area[]>();
  Tipoprocessos$ = new Observable<Tipoprocesso[]>();

  constructor(private ProcessoService: ProcessoService, private AreaService: AreaService, private TipoprocessoService: TipoprocessoService) {
    this.getProcessosCad();
   
  }

  getSubCad() {
    this.Tipoprocessos$ = this.TipoprocessoService.getTipoprocesso();
    this.Areas$ = this.AreaService.getAreas();

  }

 
  getProcessosCad() {
    this.getSubCad();
    this.Processos$ = this.ProcessoService.getProcessos();
  }
  buttonClick() {
    if (!this.nome)
      return;

    if (this.id) {
      this.ProcessoService.putProcesso({
        id: this.id, nome: this.nome,
        areaId: this.areaid, processoTipoId: this.processotipoid,
        subprocessos: this.subprocessos?.toString().split(',').map(Number)
      })
        .subscribe(_ => this.getProcessosCad());
      return
    }

    this.ProcessoService.postProcesso({
      id: this.id, nome: this.nome,
      areaId: this.areaid, processoTipoId: this.processotipoid,
      subprocessos: this.subprocessos.toString().split(',').map(Number)
    })
      .subscribe(_ => this.getProcessosCad())

  }

  changeForm(processo: Processo) {
    this.id = processo.id as number;
    this.nome = processo.nome;
    this.areaid = processo.areaId as number;
    this.processotipoid = processo.processoTipoId as number;
    this.subprocessos = processo.subprocessos.toString();
   
  }

  putProcesso(processo: Processo) {
    if (!this.nome)
      return;

    this.ProcessoService.putProcesso(processo)
      .subscribe(_ => this.getProcessosCad());
  }
  deleteProcesso(id: number) {
    this.ProcessoService.deleteProcesso(id)
      .subscribe(_ => this.getProcessosCad());
  }



}


