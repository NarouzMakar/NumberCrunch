import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { NumberCrunchService } from 'src/app/shared/data-services/number-crunch.service';
import { StartNumberCrunchModel } from './start-number-crunchModel';

@Component({
  selector: 'start-number-crunch',
  templateUrl: './start-number-crunch.component.html',
  styleUrls: ['./start-number-crunch.component.css']
})
export class StartNumberCrunchComponent implements OnInit {
  constructor(private ncService: NumberCrunchService, private router: Router){}
  model: StartNumberCrunchModel;

  ngOnInit(): void {
    this.model = new StartNumberCrunchModel();
  }

  submit(data: any){
    if(this.model.isView){
      this.ncService.submit(data).subscribe(resp =>{
        if (resp.isSuccess) {
          let id = resp.result;
          this.router.navigateByUrl(`numberCrunch/v1/view/${id}`);
        }
      });
    } else {
        this.model.isView = true;
    }
  }
}
