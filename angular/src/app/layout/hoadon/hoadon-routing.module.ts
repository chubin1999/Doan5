import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HoadonComponent } from './hoadon.component';

const routes: Routes = [
    {
        path: '', component: HoadonComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class HoadonRoutingModule {
}
