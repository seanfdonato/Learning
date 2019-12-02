import { Component, OnInit, ViewChild } from '@angular/core';

@Component({
  selector: 'app-consult',
  templateUrl: './consult.component.html',
  styleUrls: ['./consult.component.css']
})
export class ConsultComponent implements OnInit {
  public someText: string;
  constructor() { }

  ngOnInit() {
    this.someText = "Hello World!";
  }

  fromChildreen(event: any) {
    console.log(event);


  }

}
