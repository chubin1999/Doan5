import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { KhuyenmaiComponent } from './khuyenmai.component';

const routes: Routes = [
    {
        path: '', component: KhuyenmaiComponent,
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class KhuyenmaiRoutingModule {
}
