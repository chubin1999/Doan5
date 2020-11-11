import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChitietdondathangComponent } from './chitietdondathang.component';
import { ChitietdondathangRoutingModule } from './chitietdondathang-routing.module';
import { PageHeaderModule } from 'src/app/shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';



@NgModule({
  declarations: [ChitietdondathangComponent],
  imports: [
    CommonModule, ChitietdondathangRoutingModule, PageHeaderModule, FormsModule, ModalModule.forRoot()],
})
export class ChitietdondathangModule { }
