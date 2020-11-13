import { Component, OnInit, Renderer2, ViewChild } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap/modal';
import { SanphamService } from '../../shared/services/sanpham.service';

@Component({
  selector: 'app-danhsachsanpham',
  templateUrl: './danhsachsanpham.component.html',
  styleUrls: ['./danhsachsanpham.component.css']
})
export class DanhsachsanphamComponent implements OnInit {
  @ViewChild('AddEditModal', { static: false }) AddEditModal: ModalDirective;
  constructor(private renderer: Renderer2 , private sanphamService: SanphamService) { }
  public items: any[];
  ngOnInit(): void {
    this.loadData();
  }
  loadData() {
    this.sanphamService.getLink().subscribe((res: any) => {
        this.items = res;
    });
}

}
