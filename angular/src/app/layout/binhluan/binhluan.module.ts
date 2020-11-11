import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BinhluanComponent } from './binhluan.component';
import { BinhluanRoutingModule } from './binhluan-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [BinhluanComponent],
  imports: [
    CommonModule, BinhluanRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()],
})
export class BinhluanModule { }
