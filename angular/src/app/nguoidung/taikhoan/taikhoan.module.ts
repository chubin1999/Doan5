import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TaikhoanComponent } from './taikhoan.component';
import { TaikhoanRoutingModule } from './taikhoan-routing.module';



@NgModule({
  declarations: [TaikhoanComponent],
  imports: [
    CommonModule, TaikhoanRoutingModule
  ]
})
export class TaikhoanModule { }
