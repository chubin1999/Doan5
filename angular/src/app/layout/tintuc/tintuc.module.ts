import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TintucComponent } from './tintuc.component';
import { TintucRoutingModule } from './tintuc-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  declarations: [TintucComponent],
  imports: [
    CommonModule, TintucRoutingModule, PageHeaderModule , FormsModule, ModalModule.forRoot()
  ]
})
export class TintucModule { }
