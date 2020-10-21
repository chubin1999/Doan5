import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SanphamComponent } from './sanpham.component';

const routes: Routes = [
    {
        path: '', component: SanphamComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class SanphamRoutingModule {
}
