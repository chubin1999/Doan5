import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoaisanphamComponent } from './loaisanpham.component';
import { LoaisanphamRoutingModule } from './loaisanpham-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  declarations: [LoaisanphamComponent],
  imports: [
    CommonModule, LoaisanphamRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()],
})
export class LoaisanphamModule { }
