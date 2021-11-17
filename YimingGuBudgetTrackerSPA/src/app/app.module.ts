import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { HeaderComponent } from './core/layout/header/header.component';
import { FormsModule } from '@angular/forms';
import { ExpenditureComponent } from './expenditure/expenditure.component';
import { IncomeComponent } from './income/income.component';
import { IncomeModule } from './income/income.module';
import { ExpenditureModule } from './expenditure/expenditure.module';



@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    HeaderComponent,
    IncomeComponent,
    ExpenditureComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    FormsModule,
    IncomeModule,
    ExpenditureModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
