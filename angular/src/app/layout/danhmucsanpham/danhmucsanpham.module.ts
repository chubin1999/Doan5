import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DanhmucsanphamComponent } from './danhmucsanpham.component';
import { DanhmucsanphamRoutingModule } from './danhmucsanpham-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [DanhmucsanphamComponent],
  imports: [
    CommonModule, DanhmucsanphamRoutingModule, PageHeaderModule, FormsModule
  ]
})
export class DanhmucsanphamModule { }
