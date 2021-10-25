import { Component, EventEmitter, Input, OnInit, Output, ViewEncapsulation } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NumberCrunchService } from 'src/app/shared/data-services/number-crunch.service';
import { StartNumberCrunchModel } from './manage-number-crunchModel';

@Component({
  selector: 'manage-number-crunch',
  templateUrl: './manage-number-crunch.component.html',
  styleUrls: ['./manage-number-crunch.component.css']
})
export class ManageNumberCrunchComponent implements OnInit {
  constructor(private ncService: NumberCrunchService, private router: Router, private formBuilder: FormBuilder){}
  model: StartNumberCrunchModel;
  crunchForm: FormGroup;
  private _isViewMode: boolean;
  @Input() set isView (value: boolean){
    if(value)
    {
      this.crunchForm.disable();
    }
    this._isViewMode =value;
  };

  @Output() sumbitData = new EventEmitter<StartNumberCrunchModel>();
  ngOnInit(): void {
    this.model = new StartNumberCrunchModel();
    this.crunchForm = this.formBuilder.group({
      maxCount: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
      patientScore: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
      doctorScore: ['', [Validators.required, Validators.min(1), Validators.pattern('^[1-9]+[0-9]*$')]],
    });
  }

  submit(){
    if(this.crunchForm.valid || this._isViewMode){
      this.model = this.crunchForm.getRawValue();
      this.sumbitData.emit(this.model);
      // this.ncService.submit(this.model).subscribe(resp =>{
      //   if (resp.isSuccess) {
      //     let id = resp.result;
      //     this.router.navigateByUrl(`numberCrunch/v1/view/${id}`);
      //   }
      // });
    }
  }
}
