import { Injectable } from "@angular/core";
import { map, Observable } from "rxjs";
import { StartNumberCrunchModel } from "src/app/modules/number-crunch/components/start/start-number-crunchModel";
import { ApiService } from "../base/api.service";
import { BaseService } from "../base/base.service";
import { JsonActionResult } from "../models/json-action-result";
import { NumberCrunchVm } from "../ViewModels/numberCrunchVm";

@Injectable({
  providedIn: 'root'
})
  export class NumberCrunchService extends BaseService {
    constructor(apiService: ApiService) {
      super(apiService, 'NumberCrunch');
    }

    submit(model: StartNumberCrunchModel): Observable<JsonActionResult<number>> {
      return this.post('', { body: model }).pipe(map(res => res as JsonActionResult<number>));
    }

    getNumberCrunchList(id: number): Observable<JsonActionResult<NumberCrunchVm[]>> {
      return this.get(id.toString()).pipe(map(res => res as JsonActionResult<NumberCrunchVm[]>));
    }

}
