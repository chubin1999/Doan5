import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SliderComponent } from './slider.component';
import { SliderRoutingModule } from './slider-routing.module';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';
import { ModalModule } from 'ngx-bootstrap/modal';


@NgModule({
  declarations: [SliderComponent],
  imports: [
    CommonModule, SliderRoutingModule, PageHeaderModule , FormsModule, ModalModule.forRoot()
  ]
})
export class SliderModule { }
