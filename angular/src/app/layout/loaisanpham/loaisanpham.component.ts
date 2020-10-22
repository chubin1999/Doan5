import { Component, OnInit } from '@angular/core';
import { LoaisanphamService } from '../../shared/services/loaisanpham.service';
import { routerTransition } from '../../router.animations';

@Component({
  selector: 'app-loaisanpham',
  templateUrl: './loaisanpham.component.html',
  styleUrls: ['./loaisanpham.component.css'],
  animations: [routerTransition()]
})
export class LoaisanphamComponent implements OnInit {

  public items: any[];
    constructor(private loaisanphamService: LoaisanphamService) {}

    ngOnInit() {
        this.loaisanphamService.getLink().subscribe((res: any)=>{
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }
    onClick(value:any){
        this.loaisanphamService.postItem(value).subscribe((res)=>{
            alert("Thêm thành công");
        });
    }
    // public style="30px";
    onDelete(id:string){
        var confirmResult = confirm("Bạn có chắc chắn muốn xóa không?");
        if (confirmResult) {
            this.loaisanphamService.deleteItem(id).subscribe(function (response) {
                if (response) {
                    alert('Xóa thành công!');
                   
                }
            });
        }
    }
}
