import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LayoutComponent } from './layout.component';

const routes: Routes = [
    {
        path: '',
        component: LayoutComponent,
        children: [
            { path: '', redirectTo: 'dashboard', pathMatch: 'prefix' },
            { path: 'dashboard', loadChildren: () => import('./dashboard/dashboard.module').then(m => m.DashboardModule) },
            { path: 'charts', loadChildren: () => import('./charts/charts.module').then(m => m.ChartsModule) },
            { path: 'binhluan', loadChildren: () => import('./binhluan/binhluan.module').then(m => m.BinhluanModule) },
            { path: 'danhmucsanpham', loadChildren: () => import('./danhmucsanpham/danhmucsanpham.module').then(m => m.DanhmucsanphamModule) },
            { path: 'dondathang', loadChildren: () => import('./dondathang/dondathang.module').then(m => m.DondathangModule) },
            { path: 'hangsanxuat', loadChildren: () => import('./hangsanxuat/hangsanxuat.module').then(m => m.HangsanxuatModule) },
            { path: 'hoadon', loadChildren: () => import('./hoadon/hoadon.module').then(m => m.HoadonModule) },
            { path: 'khachhang', loadChildren: () => import('./khachhang/khachhang.module').then(m => m.KhachhangModule) },
            { path: 'khuyenmai', loadChildren: () => import('./khuyenmai/khuyenmai.module').then(m => m.KhuyenmaiModule) },
            { path: 'loaisanpham', loadChildren: () => import('./loaisanpham/loaisanpham.module').then(m => m.LoaisanphamModule) },
            { path: 'nhacungcap', loadChildren: () => import('./nhacungcap/nhacungcap.module').then(m => m.NhacungcapModule) },
            { path: 'nhanvien', loadChildren: () => import('./nhanvien/nhanvien.module').then(m => m.NhanvienModule) },
            { path: 'sanpham', loadChildren: () => import('./sanpham/sanpham.module').then(m => m.SanphamModule) },
            { path: 'slider', loadChildren: () => import('./slider/slider.module').then(m => m.SliderModule) },
            { path: 'tintuc', loadChildren: () => import('./tintuc/tintuc.module').then(m => m.TintucModule) },
            { path: 'forms', loadChildren: () => import('./form/form.module').then(m => m.FormModule) },
            { path: 'bs-element', loadChildren: () => import('./bs-element/bs-element.module').then(m => m.BsElementModule) },
            { path: 'grid', loadChildren: () => import('./grid/grid.module').then(m => m.GridModule) },
            { path: 'components', loadChildren: () => import('./bs-component/bs-component.module').then(m => m.BsComponentModule) },
            { path: 'blank-page', loadChildren: () => import('./blank-page/blank-page.module').then(m => m.BlankPageModule) }
        ]
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class LayoutRoutingModule {}
