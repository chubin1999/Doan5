import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LienheComponent } from './lienhe.component';
import { LienheRoutingModule } from './lienhe-routing.module';



@NgModule({
  declarations: [LienheComponent],
  imports: [
    CommonModule,
    LienheRoutingModule
  ]
})
export class LienheModule { }
