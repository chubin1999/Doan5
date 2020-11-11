import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NhanvienComponent } from './nhanvien.component';
import { NhanvienRoutingModule } from './nhanvien-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [NhanvienComponent],
  imports: [
    CommonModule,  NhanvienRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class NhanvienModule { }
