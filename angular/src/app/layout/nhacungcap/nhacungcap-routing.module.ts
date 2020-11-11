import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NhacungcapComponent } from './nhacungcap.component';

const routes: Routes = [
    {
        path: '', component: NhacungcapComponent,
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class NhacungcapRoutingModule {
}
