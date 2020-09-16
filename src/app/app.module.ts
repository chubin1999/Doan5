import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { MainComponent } from './main/main.component';
import { Routes, RouterModule } from '@angular/router';
import { DanhmucComponent } from './danhmuc/danhmuc.component';
const routes: Routes = [
  // {
  //   path: 'chitiet',
  //   component: ChitietComponent,
  // },
  {
    path: 'danhmuc',
    component: DanhmucComponent,
  },
  {
    path: '',
    component: MainComponent,
  },
  {
    path: 'home',
    component: MainComponent,
  },
];
@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    MainComponent,
    DanhmucComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),//GỌi đến router
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
