import { ActivatedRouteSnapshot } from '@angular/router';
import { ActivatedRoute } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-consult-details',
  templateUrl: './consult-details.component.html',
  styleUrls: ['./consult-details.component.css']
})
export class ConsultDetailsComponent implements OnInit {
  id: string
  id2: string
  constructor(private route: ActivatedRoute) {
    console.log(this.route)
  }

  ngOnInit() {
    this.id = this.route.snapshot.params['id']
    this.route.params.subscribe(x => {
      this.id2 = x['id']
    })
  }

}
