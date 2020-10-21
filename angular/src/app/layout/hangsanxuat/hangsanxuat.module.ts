import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HangsanxuatRoutingModule } from './hangsanxuat-routing.module';
import { HangsanxuatComponent } from './hangsanxuat.component';
import { PageHeaderModule } from '../../shared';
import { FormsModule } from '@angular/forms';

@NgModule({
    imports: [CommonModule, HangsanxuatRoutingModule, PageHeaderModule,FormsModule],
    declarations: [HangsanxuatComponent]
})
export class HangsanxuatModule {}
