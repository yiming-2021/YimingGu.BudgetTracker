import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AddUserComponent } from './add-user/add-user.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { UpdateUserComponent } from './update-user/update-user.component';
import { UserComponent } from './user.component';
import { UserRoutingModule } from './user-routing.module';
import { FormsModule } from '@angular/forms';
import { IncomesComponent } from './incomes/incomes.component';




@NgModule({
  declarations: [
    UserComponent,
    AddUserComponent,
    UserDetailsComponent,
    UpdateUserComponent,
    IncomesComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule,
    FormsModule,

  ]
})

export class UserModule { }

