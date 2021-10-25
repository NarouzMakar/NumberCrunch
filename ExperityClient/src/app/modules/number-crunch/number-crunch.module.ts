import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { StartNumberCrunchComponent } from './components/start/start-number-crunch.component';
import { ViewNumberCrunchComponent } from './components/view/view-number-crunch.component';
import { NumberCrunchRoutingModule } from './number-crunch-routing.module';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatTabsModule } from '@angular/material/tabs';

const materialModules = [MatInputModule, MatButtonModule, MatTabsModule];
@NgModule({
  imports: [
    NumberCrunchRoutingModule,
    FormsModule,
    CommonModule,
    ...materialModules,
    ReactiveFormsModule
  ],
  exports: [ReactiveFormsModule],
  declarations: [StartNumberCrunchComponent, ViewNumberCrunchComponent],
  providers: [],
  entryComponents: []
})
export class NumberCrunchModule {}
