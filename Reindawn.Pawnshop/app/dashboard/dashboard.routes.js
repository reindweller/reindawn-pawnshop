"use strict";
var index_1 = require('./home/index');
//import { ChartRoutes } from './charts/index';
//import { BlankPageRoutes } from './blank-page/index';
//import { TableRoutes } from './tables/index';
//import { FormRoutes } from './forms/index';
//import { GridRoutes } from './grid/index';
//import { BSComponentRoutes } from './bs-component/index';
//import { BSElementRoutes } from './bs-element/index';
var index_2 = require('./index');
exports.DashboardRoutes = [
    {
        path: 'dashboard',
        component: index_2.DashboardComponent,
        children: index_1.HomeRoutes.slice()
    }
];
//# sourceMappingURL=dashboard.routes.js.map