import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HousingLoanComponent } from './housing-loan/housing-loan.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    HousingLoanComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports: [HousingLoanComponent],
})
export class LoansModule { }
