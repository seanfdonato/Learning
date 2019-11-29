import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './pages/Auth/login/login.component';
import { ConfigComponent } from './pages/config/config.component';
import { ConsultComponent } from './pages/consult/consult/consult.component';
import { ConsultDetailsComponent } from './pages/consult/consult-details/consult-details.component';
import { AppComponent } from './app.component';


const routes: Routes = [
  // { path: '', component: AppComponent },
  { path: 'login', component: LoginComponent },
  { path: '', component: ConfigComponent },
  { path: 'consult', component: ConsultComponent },
  { path: 'consult/:id', component: ConsultDetailsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
