import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NguoidungComponent } from './nguoidung.component';

const routes: Routes = [
    {
        path: '', component: NguoidungComponent, children: [
            { path: '', redirectTo: 'main', pathMatch: 'full' },
            { path: 'main', loadChildren: () => import('./main/main.module').then(m => m.MainModule) },
            { path: 'aboutus', loadChildren: () => import('./aboutus/aboutus.module').then(m => m.AboutusModule) },
        ]

    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class NguoiDungRoutingModule {}
