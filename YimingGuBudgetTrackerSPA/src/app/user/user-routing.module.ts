import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddUserComponent } from './add-user/add-user.component';
import { ExpenditureComponent } from './expenditure/expenditure.component';
import { IncomesComponent } from './incomes/incomes.component';
import { UpdateUserComponent } from './update-user/update-user.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { UserComponent } from './user.component';

const routes: Routes = [

  // localhost:4200/user
  {
    path: '', component: UserComponent,
    children: [
      {path: 'adduser', component: AddUserComponent },
      {path: ':id', component: UserDetailsComponent},
      {path: 'update', component: UpdateUserComponent},
      {path: 'income/:id', component: IncomesComponent},
      {path: 'expenditure/:id', component: ExpenditureComponent}
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class UserRoutingModule { }