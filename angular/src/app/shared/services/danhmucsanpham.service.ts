import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {map} from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class DanhmucsanphamService {

  //b1: khai báo biến chỉ đường dẫn api
  public urlAPI = "https://localhost:44350/api/Danhmucsanphams";
  //b2: khởi tạo một biến httpclient
  constructor(private _http: HttpClient) { }
  //b3: viết hàm gọi phương thức
  getLink(): Observable<any[]>{
    return this._http.get<any[]>(this.urlAPI).pipe(map(res => {
        return res;
    }));
  }

  //post
  postItem(data: any):Observable<any>{
    return this._http.post<any>(this.urlAPI, data).pipe(map(res=>{
      return res;
    }));
  }
  deleteItem(id:string):Observable<any>{
    debugger;
    return this._http.delete<any>(this.urlAPI + "/" + id).pipe(map(res=>{
      return res;
    }));
  }
}
