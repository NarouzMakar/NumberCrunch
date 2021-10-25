import { Component, OnInit } from '@angular/core';
import { FirstService } from './shared/data-services/firstService.service';
import { NumberCrunchService } from './shared/data-services/number-crunch.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(){}
  ngOnInit(): void {
  }


}
