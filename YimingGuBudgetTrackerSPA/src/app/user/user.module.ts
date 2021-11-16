import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AddUserComponent } from './add-user/add-user.component';
import { UserDetailsComponent } from './user-details/user-details.component';
import { UpdateUserComponent } from './update-user/update-user.component';
import { UserComponent } from './user.component';
import { UserRoutingModule } from './user-routing.module';



@NgModule({
  declarations: [
    UserComponent,
    AddUserComponent,
    UserDetailsComponent,
    UpdateUserComponent
  ],
  imports: [
    CommonModule,
    UserRoutingModule
  ]
})
export class UserModule { }
