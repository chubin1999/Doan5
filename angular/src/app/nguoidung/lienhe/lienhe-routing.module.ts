import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LienheComponent } from './lienhe.component';
const routes: Routes = [
    {
        path: '', component: LienheComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LienheRoutingModule {
}
