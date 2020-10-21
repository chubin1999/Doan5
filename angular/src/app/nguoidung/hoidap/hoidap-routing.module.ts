import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HoidapComponent } from './hoidap.component';
const routes: Routes = [
    {
        path: '', component: HoidapComponent
    }
];
@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class HoidapRoutingModule {
}
