import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MainComponent } from './main/main.component';
import { NguoidungComponent } from './nguoidung.component';

const routes: Routes = [
    {
        path: '', component: NguoidungComponent, children: [
            { path: '', loadChildren: () => import('./main/main.module').then(m => m.MainModule) },
            { path: 'main', loadChildren: () => import('./main/main.module').then(m => m.MainModule) },
            { path: 'aboutus', loadChildren: () => import('./aboutus/aboutus.module').then(m => m.AboutusModule) },
            { path: 'blog', loadChildren: () => import('./blog/blog.module').then(m => m.BlogModule) },
            { path: 'checkout', loadChildren: () => import('./checkout/checkout.module').then(m => m.CheckoutModule) },
            { path: 'chitietblog', loadChildren: () => import('./chitietblog/chitietblog.module').then(m => m.ChitietblogModule) },
            { path: 'chitietsanpham', loadChildren: () => import('./chitietsanpham/chitietsanpham.module').then(m => m.ChitietsanphamModule) },
            { path: 'danhsachsanpham', loadChildren: () => import('./danhsachsanpham/danhsachsanpham.module').then(m => m.DanhsachsanphamModule) },
            { path: 'giohang', loadChildren: () => import('./giohang/giohang.module').then(m => m.GiohangModule) },
            { path: 'lienhe', loadChildren: () => import('./lienhe/lienhe.module').then(m => m.LienheModule) },
            { path: 'hoidap', loadChildren: () => import('./hoidap/hoidap.module').then(m => m.HoidapModule) },
            { path: 'taikhoan', loadChildren: () => import('./taikhoan/taikhoan.module').then(m => m.TaikhoanModule) },
            { path: 'loginnguoidung', loadChildren: () => import('../loginnguoidung/loginnguoidung.module').then(m => m.LoginnguoidungModule) },
        ]

    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class NguoiDungRoutingModule {}
