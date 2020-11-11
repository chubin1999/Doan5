import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChitiethoadonComponent } from './chitiethoadon.component';
import { ChitietdondathangRoutingModule } from '../chitietdondathang/chitietdondathang-routing.module';
import { PageHeaderModule } from 'src/app/shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [ChitiethoadonComponent],
  imports: [
    CommonModule, ChitietdondathangRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class ChitiethoadonModule { }
