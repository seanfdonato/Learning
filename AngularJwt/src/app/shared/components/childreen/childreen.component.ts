

import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

@Component({
  selector: 'app-childreen',
  templateUrl: './childreen.component.html',
  styleUrls: ['./childreen.component.css']
})
export class ChildreenComponent implements OnInit {
  @Input() fatherToChild: string
  @Output() childToFather = new EventEmitter();

  
  constructor() { }

  ngOnInit() {
    console.log(this.fatherToChild);
    this.callFromFather()
  }

  callFromFather(){
    this.childToFather.emit("Childreen To father!")
  }

}
