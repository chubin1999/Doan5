import { Component, OnInit, ViewChild } from '@angular/core';
import { routerTransition } from '../../router.animations';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { NhacungcapService } from '../../shared/services/nhacungcap.service';

@Component({
  selector: 'app-nhacungcap',
  templateUrl: './nhacungcap.component.html',
  styleUrls: ['./nhacungcap.component.css'],
  animations: [routerTransition()]
})
export class NhacungcapComponent implements OnInit {

  @ViewChild('AddEditModal') public AddEditModal: ModalDirective;
    public items: any[];
    public entity: any;
    public Id: any;
    constructor(private nhacungcapService: NhacungcapService) {}

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
        this.nhacungcapService.getItem(id).subscribe((res) => {
            this.entity = res;
        });
    }

    //load lại trang, hien thi du lieu
    loadData() {
        this.nhacungcapService.getLink().subscribe((res: any) => {
            //đẩy dữ liệu lấy được từ items
            this.items = res;
        });
    }

    //su kien them va sua
    onClick(value: any) {
        //neu Id = 0 thi thuc hien them moi
        console.log(value.ngaycapnhat);
        if (this.Id == 0) {
            this.nhacungcapService.postItem(value).subscribe((res) => {
                alert('Thêm thành công');
                this.AddEditModal.hide();
                this.loadData();
            });
        } else {
            console.log(value);
            this.nhacungcapService.editItem(value.mahang, value).subscribe((res) => {
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
            this.nhacungcapService.deleteItem(id).subscribe((response) => {
                if (response) {
                    alert('Xóa thành công!');
                    this.loadData();
                }
            });
        }
    }

}
