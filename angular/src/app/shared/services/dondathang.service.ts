import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';

const HeadersOptions = {
  headers: new HttpHeaders({ "Content-Type": "application/json" })
};
@Injectable({
  providedIn: 'root'
})
export class DondathangService {

  //b1: khai báo biến chỉ đường dẫn api
  public urlAPI = "https://localhost:44350/api/dondathangs";
  //b2: khởi tạo một biến httpclient
  constructor(private _http: HttpClient) { }
  //b3: viết hàm gọi phương thức
  getLink(): Observable<any[]>{
    return this._http.get<any[]>(this.urlAPI).pipe(map(res => {
        return res;
    }));
  }
  getLinkChild(id: any): Observable<any[]>{
    return this._http.get<any[]>(this.urlAPI + "/" + id).pipe(map(res => {
        return res;
    }));
  }
 //lay theo ma
 getItem(id: string):Observable<any>{
  return this._http.get<any>(this.urlAPI + "/" + id).pipe(map(res => {
    return res;
  }));
}
//post
postItem(data: any): Observable<any> {
  return this._http.post<any>(this.urlAPI, data).pipe(map(res => {
    return res;
  }));
}
//put
editItem(id: any, data: any): Observable<any> {
  return this._http.put<any>(this.urlAPI + "/" + id, data, HeadersOptions).pipe(map(res => {
    return res;
  }));
}
//delete
deleteItem(id: string): Observable<any> {
  return this._http.delete<any>(this.urlAPI + "/" + id).pipe(map(res => {
    return res;
  }));
}
}
