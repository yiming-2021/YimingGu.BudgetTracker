import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddIncomeComponent } from './add-income/add-income.component';
import { AllIncomeComponent } from './all-income/all-income.component';
import { IncomeComponent } from './income.component';

const routes: Routes = [
    // localhost:4200/income
    {
      path: '', component: IncomeComponent,
      children: [
        {path: '', component: AllIncomeComponent },
        {path: 'addincome', component: AddIncomeComponent},
      ]
    }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class IncomeRoutingModule { }
