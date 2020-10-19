import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChitietsanphamComponent } from './chitietsanpham.component';
import { ChitietsanphamRoutingModule } from '../chitietsanpham/chitietsanpham-routing.module';



@NgModule({
  declarations: [ChitietsanphamComponent],
  imports: [
    CommonModule,
    ChitietsanphamRoutingModule
  ]
})
export class ChitietsanphamModule { }
