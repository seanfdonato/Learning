import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { ChildreenComponent } from './components/childreen/childreen.component';

@NgModule({
    declarations: [
        ChildreenComponent
    ],
    imports: [
        BrowserModule,

    ],
    exports: [ChildreenComponent],
    providers: [],
    bootstrap: []
})
export class SharedModule { }
