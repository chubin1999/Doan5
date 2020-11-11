import { Component, OnInit, ViewChild } from '@angular/core';
import { routerTransition } from '../../router.animations';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { KhachhangService } from '../../shared/services/khachhang.service';

@Component({
  selector: 'app-khachhang',
  templateUrl: './khachhang.component.html',
  styleUrls: ['./khachhang.component.css'],
  animations: [routerTransition()]
})
export class KhachhangComponent implements OnInit {

  @ViewChild('AddEditModal') public AddEditModal: ModalDirective;
    public items: any[];
    public entity: any;
    public Id: any;
    constructor(private khachhangService: KhachhangService) {}

    ngOnInit() {
        this.loadData();
    }
    //hien thi form AddEditModal khong du lieu
    showAdd() {
        //cho doi tuong entity rong
        this.entity = {};
        //dat id =0
        this.Id = 0;
        //hien thi modal
        this.AddEditModal.show();
    }
    //hien thi form AddEditModal co du lieu
    showEdit(id: string) {
        this.AddEditModal.show();
        this.Id = 1;
        this.getSingled(id);
    }
    //hien thi du lieu theo ma
    getSingled(id: string) {
        this.khachhangService.getItem(id).subscribe((res) => {
            this.entity = res;
        });
    }

    //load lại trang, hien thi du lieu
    loadData() {
        this.khachhangService.getLink().subscribe((res: any) => {
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }

    //su kien them va sua
    onClick(value: any) {
        //neu Id = 0 thi thuc hien them moi
        console.log(value.ngaycapnhat);
        if (this.Id == 0) {
            this.khachhangService.postItem(value).subscribe((res) => {
                alert('Thêm thành công');
                this.AddEditModal.hide();
                this.loadData();
            });
        } else {
            console.log(value);
            this.khachhangService.editItem(value.mahang, value).subscribe((res) => {
                alert('edit success!');
                this.AddEditModal.hide();
                this.loadData();
            });
        }
    }
    //su kien xoa
    onDelete(id: string) {
        var confirmResult = confirm('Bạn có chắc chắn muốn xóa không?');
        if (confirmResult) {
            this.khachhangService.deleteItem(id).subscribe((response) => {
                if (response) {
                    alert('Xóa thành công!');
                    this.loadData();
                }
            });
        }
    }
}
