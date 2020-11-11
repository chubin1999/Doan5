import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DondathangComponent } from './dondathang.component';
import { DondathangRoutingModule } from './dondathang-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
  declarations: [DondathangComponent],
  imports: [
    CommonModule, DondathangRoutingModule , PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class DondathangModule { }
