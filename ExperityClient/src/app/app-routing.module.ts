import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path:'',
    pathMatch: 'full',
    redirectTo:'numberCrunch/v1/start'
  },
  {
    path: 'numberCrunch',
    children: [
      {
        path: 'v1',
        loadChildren: () => import('../app/modules/number-crunch/number-crunch.module').then(m => m.NumberCrunchModule)
      }
    ]
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
