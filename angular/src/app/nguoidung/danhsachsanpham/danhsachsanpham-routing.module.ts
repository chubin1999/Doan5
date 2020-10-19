import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DanhsachsanphamComponent } from './danhsachsanpham.component';

const routes: Routes = [
    {
        path: '', component: DanhsachsanphamComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class DanhsachsanphamRoutingModule {
}
