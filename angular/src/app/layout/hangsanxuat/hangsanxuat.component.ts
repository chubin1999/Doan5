import { Component, OnInit } from '@angular/core';
import { HangsanxuatService } from '../../shared/services/hangsanxuat.service';
import { routerTransition } from '../../router.animations';
import {NgForm} from '@angular/forms';

@Component({
    selector: 'app-hangsanxuat',
    templateUrl: './hangsanxuat.component.html',
    styleUrls: ['./hangsanxuat.component.scss'],
    animations: [routerTransition()]
})
export class HangsanxuatComponent implements OnInit {

    public items: any[];
    constructor(private hangsanxuatService: HangsanxuatService) {}

    ngOnInit() {
        this.hangsanxuatService.getLink().subscribe((res: any)=>{
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }
    onClick(value:any){
        this.hangsanxuatService.postItem(value).subscribe((res)=>{
            alert("Thêm thành công");
        });
    }
    // public style="30px";
}
