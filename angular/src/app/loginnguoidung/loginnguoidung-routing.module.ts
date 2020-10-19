import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginnguoidungComponent } from './loginnguoidung.component';

const routes: Routes = [
    {
        path: '', component: LoginnguoidungComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LoginnguoidungRoutingModule {
}
