import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { KhachhangComponent } from './khachhang.component';
import { KhachhangRoutingModule } from './khachhang-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [KhachhangComponent],
  imports: [
    CommonModule, KhachhangRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class KhachhangModule { }
