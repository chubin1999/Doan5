import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SanphamComponent } from './sanpham.component';
import { SanphamRoutingModule } from './sanpham-routing.module';
import { PageHeaderModule } from '../../shared';



@NgModule({
  imports: [
    CommonModule, SanphamRoutingModule, PageHeaderModule
  ],
  declarations: [SanphamComponent]
})
export class SanphamModule { }
