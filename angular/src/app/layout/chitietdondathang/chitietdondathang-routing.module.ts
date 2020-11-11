import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DondathangComponent } from '../dondathang/dondathang.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
      path: '', component: DondathangComponent
  }
];

@NgModule({
imports: [RouterModule.forChild(routes)],
exports: [RouterModule]
})
export class ChitietdondathangRoutingModule { }
