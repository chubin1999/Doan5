import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoaisanphamComponent } from './loaisanpham.component';

const routes: Routes = [
    {
        path: '', component: LoaisanphamComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LoaisanphamRoutingModule {
}
