import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { ConfigComponent } from './pages/config/config.component';
import { ConsultComponent } from './pages/consult/consult/consult.component';
import { LoginModule } from './pages/Auth/login.module';
import { HttpClientModule } from '@angular/common/http';
import { ConsultDetailsComponent } from './pages/consult/consult-details/consult-details.component';
import { SharedModule } from './shared/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    ConfigComponent,
    ConsultComponent,
    ConsultDetailsComponent,
    
  ],
  imports: [
    BrowserModule,
    LoginModule,
    SharedModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
