import { NumberCrunchVm } from "src/app/shared/ViewModels/numberCrunchVm";

export class ViewNumberCrunchModel {
  numberCrunchList: NumberCrunchVm[];
  selectedView: number;
  constructor() {
    this.numberCrunchList = [];
    this.selectedView = 1;
  }
}
