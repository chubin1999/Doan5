import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { KhuyenmaiComponent } from './khuyenmai.component';
import { KhuyenmaiRoutingModule } from './khuyenmai-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [KhuyenmaiComponent],
  imports: [
    CommonModule, KhuyenmaiRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class KhuyenmaiModule { }
