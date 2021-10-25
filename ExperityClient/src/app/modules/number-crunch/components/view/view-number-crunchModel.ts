import { NumberCrunchVm } from "src/app/shared/ViewModels/numberCrunchVm";

export class ViewNumberCrunchModel {
  numberCrunchList: NumberCrunchVm[];
test: string;
  constructor() {
    this.numberCrunchList = [];
  }
}
