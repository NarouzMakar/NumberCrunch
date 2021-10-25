import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { DataServiceBaseService } from "../base/dataServiceBase.service";

@Injectable({
  providedIn: 'root'
})
export class FirstService {

  constructor(private dataSvc: DataServiceBaseService) {
  }

  getOperations(): Observable<any>{
    return this.dataSvc.get(`Operation`);
  }

}
