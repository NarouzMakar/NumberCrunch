import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DataServiceBaseService } from './shared/base/dataServiceBase.service';
import { FirstService } from './shared/data-services/firstService.service';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { NumberCrunchService } from './shared/data-services/number-crunch.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [
    DataServiceBaseService,
    FirstService,
    NumberCrunchService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
