import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HoadonComponent } from './hoadon.component';
import { HoadonRoutingModule } from './hoadon-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';

@NgModule({
  declarations: [HoadonComponent],
  imports: [
    CommonModule , HoadonRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class HoadonModule { }
