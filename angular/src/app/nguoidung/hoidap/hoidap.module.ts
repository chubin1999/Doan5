import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HoidapComponent } from './hoidap.component';
import { HoidapRoutingModule } from './hoidap-routing.module';


@NgModule({
  declarations: [HoidapComponent],
  imports: [
    CommonModule,HoidapRoutingModule
  ]
})
export class HoidapModule { }
