import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HangsanxuatComponent } from './hangsanxuat.component';

const routes: Routes = [
    {
        path: '', component: HangsanxuatComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class HangsanxuatRoutingModule {
}
