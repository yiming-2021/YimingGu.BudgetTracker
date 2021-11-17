import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { IncomeRoutingModule } from './income-routing.module';


import { AllIncomeComponent } from './all-income/all-income.component';
import { AddIncomeComponent } from './add-income/add-income.component';
import { IncomeComponent } from './income.component';


@NgModule({
  declarations: [
    IncomeComponent,
    AllIncomeComponent,
    AddIncomeComponent
  ],
  imports: [
    CommonModule,
    IncomeRoutingModule
  ]
})

export class IncomeModule { }
