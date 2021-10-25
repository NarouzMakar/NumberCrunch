import { ModuleWithProviders, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { StartNumberCrunchComponent } from './components/start/start-number-crunch.component';
import { ViewNumberCrunchComponent } from './components/view/view-number-crunch.component';


const routes: Routes = [
    {
      path: '',
      children: [
        {
          path: 'start',
          component: StartNumberCrunchComponent,
        },
        {
          path: 'view/:id',
          component: ViewNumberCrunchComponent
        }
      ]
    }
];

@NgModule({
  imports: [
      RouterModule.forChild(routes)
  ]
})
export class NumberCrunchRoutingModule { }
