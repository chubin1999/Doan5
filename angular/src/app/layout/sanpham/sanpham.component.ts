import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';
import { SanphamService } from '../../shared/services/sanpham.service';
import {NgForm} from '@angular/forms';

@Component({
    selector: 'app-sanpham',
    templateUrl: './sanpham.component.html',
    styleUrls: ['./sanpham.component.css'],
    animations: [routerTransition()]
})
export class SanphamComponent implements OnInit {
    public items: any[];
    constructor (private sanphamService: SanphamService) {}

    ngOnInit() {
        this.sanphamService.getLink().subscribe((res: any) => {
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }
    onClick(value){
        
        this.sanphamService.postItem(value).subscribe((res)=>{
            alert("Thêm thành công");
        });
    }
}
