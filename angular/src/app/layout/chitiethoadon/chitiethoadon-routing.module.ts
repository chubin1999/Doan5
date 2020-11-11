import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ChitietblogComponent } from 'src/app/nguoidung/chitietblog/chitietblog.component';



const routes: Routes = [
  {
      path: '', component: ChitietblogComponent
  }
];

@NgModule({
imports: [RouterModule.forChild(routes)],
exports: [RouterModule]
})
export class ChitiethoadonRoutingModule { }
