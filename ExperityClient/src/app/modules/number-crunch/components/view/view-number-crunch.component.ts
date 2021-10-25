import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NumberCrunchService } from 'src/app/shared/data-services/number-crunch.service';
import { NumberCrunchVm } from 'src/app/shared/ViewModels/numberCrunchVm';
import { ViewNumberCrunchModel } from './view-number-crunchModel';

@Component({
  selector: 'view-number-crunch',
  templateUrl: './view-number-crunch.component.html',
  styleUrls: ['./view-number-crunch.component.css']
})
export class ViewNumberCrunchComponent implements OnInit {
  constructor(private ncService: NumberCrunchService, private route: ActivatedRoute){}
  model: ViewNumberCrunchModel;
  ngOnInit(): void {
    this.model = new ViewNumberCrunchModel();
    this.model.test = "Narouz0";
    this.loadNumberCrunchDetails();
  }

  loadNumberCrunchDetails(){
    this.route.params.subscribe(params =>{
      let id = params['id'];
      console.log(id);
      this.ncService.getNumberCrunchList(id).subscribe(resp =>{
        debugger;
        if (resp.isSuccess) {
          this.model.numberCrunchList = resp.result;
          console.log(this.model.numberCrunchList);
        }
      });
    });
  }

}
