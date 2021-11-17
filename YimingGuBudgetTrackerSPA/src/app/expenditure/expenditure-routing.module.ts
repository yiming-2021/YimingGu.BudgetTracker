import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddExpenditureComponent } from './add-expenditure/add-expenditure.component';
import { AllExpenditureComponent } from './all-expenditure/all-expenditure.component';
import { ExpenditureComponent } from './expenditure.component';

const routes: Routes = [    
  // localhost:4200/expenditure
  {
    path: '', component: ExpenditureComponent,
    children: [
      {path: '', component: AllExpenditureComponent },
      {path: 'addexp', component: AddExpenditureComponent},
    ]
  }
];


@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ExpenditureRoutingModule { }
