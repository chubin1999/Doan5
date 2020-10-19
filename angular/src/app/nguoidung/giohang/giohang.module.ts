import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GiohangComponent } from './giohang.component';
import { GiohangRoutingModule } from './giohang-routing.module';



@NgModule({
  declarations: [GiohangComponent],
  imports: [
    CommonModule,
    GiohangRoutingModule
  ]
})
export class GiohangModule { }
