import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { AuthService } from './services/auth.service';



@NgModule({
  declarations: [
    LoginComponent,
    AuthService],
  imports: [
    CommonModule
  ]
})
export class LoginModule { }
