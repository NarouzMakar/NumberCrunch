import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { NumberCrunchService } from 'src/app/shared/data-services/number-crunch.service';
import { ViewNumberCrunchModel } from './view-number-crunchModel';

@Component({
  selector: 'view-number-crunch',
  templateUrl: './view-number-crunch.component.html',
  styleUrls: ['./view-number-crunch.component.css']
})
export class ViewNumberCrunchComponent implements OnInit {
  constructor(private ncService: NumberCrunchService,
     private route: ActivatedRoute,
     private router: Router){}
  model: ViewNumberCrunchModel;
  ngOnInit(): void {
    this.model = new ViewNumberCrunchModel();
    this.loadNumberCrunchDetails();
  }

  loadNumberCrunchDetails(){
    this.route.params.subscribe(params =>{
      let id = params['id'];
      this.ncService.getNumberCrunchList(id).subscribe(resp =>{
        if (resp.isSuccess) {
          this.model.numberCrunchList = resp.result;
        }
      });
    });
  }

  goBack(){
    this.router.navigateByUrl('numberCrunch/v1/start');
  }

}
