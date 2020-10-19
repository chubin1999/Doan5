import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DanhsachsanphamComponent } from './danhsachsanpham.component';
import { DanhsachsanphamRoutingModule } from './danhsachsanpham-routing.module';



@NgModule({
  declarations: [DanhsachsanphamComponent],
  imports: [
    CommonModule,
    DanhsachsanphamRoutingModule
  ]
})
export class DanhsachsanphamModule { }
