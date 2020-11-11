import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DondathangComponent } from './dondathang.component';

const routes: Routes = [
    {
        path: '', component: DondathangComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DondathangRoutingModule {
}
