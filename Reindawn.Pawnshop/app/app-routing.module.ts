import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

//import { DashboardComponent }   from './dashboard/dashboard.component';
import { DashboardRoutes } from './dashboard/index';

import { HeroesComponent }      from './heroes.component';
import { HeroDetailComponent } from './hero-detail.component';

import { LoginRoutes } from './login/index';
import { LoginComponent } from './login/index';

//import { DashboardRoutes } from './dashboard/index';


const routes: Routes = [
    ...LoginRoutes,
    ...DashboardRoutes,
  //{ path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  //{ path: 'dashboard',  component: DashboardComponent },
  { path: 'detail/:id', component: HeroDetailComponent },
  { path: 'heroes', component: HeroesComponent },
  { path: '**', component: LoginComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}


/*
Copyright 2016 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/