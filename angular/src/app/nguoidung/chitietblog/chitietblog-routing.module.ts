import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChitietblogComponent } from './chitietblog.component';

const routes: Routes = [
    {
        path: '', component: ChitietblogComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class ChitietRoutingModule {
}
