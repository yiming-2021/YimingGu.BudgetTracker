import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ExpenditureRoutingModule } from './expenditure-routing.module';
import { AllExpenditureComponent } from './all-expenditure/all-expenditure.component';
import { AddExpenditureComponent } from './add-expenditure/add-expenditure.component';
import { ExpenditureComponent } from './expenditure.component';


@NgModule({
  declarations: [
    ExpenditureComponent,
    AllExpenditureComponent,
    AddExpenditureComponent
  ],
  imports: [
    CommonModule,
    ExpenditureRoutingModule
  ]
})
export class ExpenditureModule { }
