import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SanphamComponent } from './sanpham.component';
import { SanphamRoutingModule } from './sanpham-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  imports: [
    CommonModule, SanphamRoutingModule, PageHeaderModule , FormsModule, ModalModule.forRoot()
  ],
  declarations: [SanphamComponent]
})
export class SanphamModule { }
