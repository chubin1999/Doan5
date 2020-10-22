import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SanphamComponent } from './sanpham.component';
import { SanphamRoutingModule } from './sanpham-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';


@NgModule({
  imports: [
    CommonModule, SanphamRoutingModule, PageHeaderModule , FormsModule
  ],
  declarations: [SanphamComponent]
})
export class SanphamModule { }
