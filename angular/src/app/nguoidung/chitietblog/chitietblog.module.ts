import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ChitietblogComponent } from './chitietblog.component';
import { ChitietRoutingModule } from './chitietblog-routing.module';



@NgModule({
  declarations: [ChitietblogComponent],
  imports: [
    CommonModule,
    ChitietRoutingModule
  ]
})
export class ChitietblogModule { }
