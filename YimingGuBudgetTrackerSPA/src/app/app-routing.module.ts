import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  // path/route for my home page http://localhost:4200/
  {path:"", component: HomeComponent},

  // lazily load the modules, define main route for lazy modules
  {
    path: "user", 
    loadChildren: () => 
    import("./user/user.module").then(mod => mod.UserModule)
  },

  {
    path: "income", 
    loadChildren: () => 
    import("./income/income.module").then(mod => mod.IncomeModule)
  },

  {
    path: "expenditure", 
    loadChildren: () => 
    import("./expenditure/expenditure.module").then(mod => mod.ExpenditureModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
