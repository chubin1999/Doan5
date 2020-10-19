import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChitietsanphamComponent } from './chitietsanpham.component';

const routes: Routes = [
    {
        path: '', component: ChitietsanphamComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ChitietsanphamRoutingModule {
}
