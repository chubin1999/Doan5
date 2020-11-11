import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NhacungcapComponent } from './nhacungcap.component';
import { NhacungcapRoutingModule } from './nhacungcap-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [NhacungcapComponent],
  imports: [
    CommonModule, NhacungcapRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()
  ]
})
export class NhacungcapModule { }
