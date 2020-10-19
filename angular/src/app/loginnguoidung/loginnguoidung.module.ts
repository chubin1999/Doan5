import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginnguoidungComponent } from './loginnguoidung.component';
import { LoginnguoidungRoutingModule } from './loginnguoidung-routing.module';



@NgModule({
  declarations: [LoginnguoidungComponent],
  imports: [
    CommonModule,
    LoginnguoidungRoutingModule
  ]
})
export class LoginnguoidungModule { }
