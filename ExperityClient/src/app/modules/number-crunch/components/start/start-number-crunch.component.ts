import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NumberCrunchService } from 'src/app/shared/data-services/number-crunch.service';
import { StartNumberCrunchModel } from './start-number-crunchModel';

@Component({
  selector: 'start-number-crunch',
  templateUrl: './start-number-crunch.component.html',
  styleUrls: ['./start-number-crunch.component.css']
})
export class StartNumberCrunchComponent implements OnInit {
  constructor(private ncService: NumberCrunchService, private router: Router, private formBuilder: FormBuilder){}
  model: StartNumberCrunchModel;
  crunchForm: FormGroup;

  ngOnInit(): void {
    this.model = new StartNumberCrunchModel();
    this.crunchForm = this.formBuilder.group({
      maxCount: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
      patientScore: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
      doctorScore: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
    });
  }

  submit(){
    console.log('sssss');
    console.log(this.crunchForm.valid);

    if(this.crunchForm.valid){
      this.model = this.crunchForm.getRawValue();
      console.log(this.model);
      this.ncService.submit(this.model).subscribe(resp =>{
        if (resp.isSuccess) {
          let id = resp.result;
          this.router.navigateByUrl(`numberCrunch/v1/view/${id}`);
        }
      });
    } else {
     console.log(this.crunchForm.errors);

    }

  }
}
