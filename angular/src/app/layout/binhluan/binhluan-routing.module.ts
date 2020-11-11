import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BinhluanComponent } from './binhluan.component';

const routes: Routes = [
    {
        path: '', component: BinhluanComponent
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BinhluanRoutingModule { }
