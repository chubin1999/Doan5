import { Component, OnInit } from '@angular/core';
import { DanhmucsanphamService } from '../../shared/services/danhmucsanpham.service';
import { routerTransition } from '../../router.animations';

@Component({
  selector: 'app-danhmucsanpham',
  templateUrl: './danhmucsanpham.component.html',
  styleUrls: ['./danhmucsanpham.component.css'],
  animations: [routerTransition()]
})
export class DanhmucsanphamComponent implements OnInit {

  public items: any[];
    constructor(private danhmucsanphamService: DanhmucsanphamService) {}

    ngOnInit() {
        this.danhmucsanphamService.getLink().subscribe((res: any)=>{
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }
    onClick(value:any){
        this.danhmucsanphamService.postItem(value).subscribe((res)=>{
            alert("Thêm thành công");
        });
    }
    // public style="30px";
    onDelete(id:string){
        var confirmResult = confirm("Bạn có chắc chắn muốn xóa không?");
        if (confirmResult) {
            this.danhmucsanphamService.deleteItem(id).subscribe(function (response) {
                if (response) {
                    alert('Xóa thành công!');
                   
                }
            });
        }
    }

}
