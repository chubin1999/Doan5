import { Component, OnInit } from '@angular/core';
import { routerTransition } from '../../router.animations';
import { SanphamService } from '../../shared/services/sanpham.service';

@Component({
    selector: 'app-sanpham',
    templateUrl: './sanpham.component.html',
    styleUrls: ['./sanpham.component.css'],
    animations: [routerTransition()]
})
export class SanphamComponent implements OnInit {
    public items: any[];
    constructor(private hangsanxuatService: SanphamService) {}

    ngOnInit() {
        this.hangsanxuatService.getLink().subscribe((res: any) => {
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }
}
