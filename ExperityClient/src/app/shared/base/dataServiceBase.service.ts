import { Injectable } from '@angular/core';
import { baseUrl }  from '../../../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
export const loadString = 'Retrieving data...';

@Injectable()
export class DataServiceBaseService{
    constructor(
        private http:HttpClient,
    ) {}

    public get(url:string) : Observable<any> {
        let _url = baseUrl + url;
        return this.http.get(_url, {}) as Observable<any>;
    }

    public post(url:string, data:any):Observable<any>{
        let _url = baseUrl + url;
        let json = JSON.stringify(data);
        return this.http.post(_url, data, {}) as Observable<any>;
    }
    public put(url:string):Observable<any>{
        let _url = baseUrl + url;
        return this.http.put(_url,{}) as Observable<any>;
    }
    public getAndForget(url:string){
        this.get(url).subscribe(() => {});
    }
    public postAndForget(url:string, data:any){
        this.post(url, data).subscribe(()=>{});
    }
    public putAndForget(url:string){
        this.put(url).subscribe(()=>{});
    }
}
