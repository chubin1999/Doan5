import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AuthGuard } from './shared';

const routes: Routes = [
    { path: '', loadChildren: () => import('./nguoidung/nguoidung.module').then(m => m.NguoidungModule) },
    { path: 'nguoidung', loadChildren: () => import('./nguoidung/nguoidung.module').then(m => m.NguoidungModule) },
    { path: 'admin', loadChildren: () => import('./layout/layout.module').then(m => m.LayoutModule), canActivate: [AuthGuard] },
    { path: 'admin/login', loadChildren: () => import('./login/login.module').then(m => m.LoginModule) },
    { path: 'admin/signup', loadChildren: () => import('./signup/signup.module').then(m => m.SignupModule) },
    { path: 'error', loadChildren: () => import('./server-error/server-error.module').then(m => m.ServerErrorModule) },
    { path: 'access-denied', loadChildren: () => import('./access-denied/access-denied.module').then(m => m.AccessDeniedModule) },
    { path: 'not-found', loadChildren: () => import('./not-found/not-found.module').then(m => m.NotFoundModule) },
    { path: '**', redirectTo: 'not-found' }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {}
