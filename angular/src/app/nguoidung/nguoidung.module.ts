import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NguoidungComponent } from './nguoidung.component';

import { NguoiDungRoutingModule } from './nguoidung-routing.module';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';


@NgModule({
  imports: [
      CommonModule,
      NguoiDungRoutingModule
  ],
  declarations: [NguoidungComponent, HeaderComponent, FooterComponent]
})
export class NguoidungModule { }
