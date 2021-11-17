import { Component, OnInit } from '@angular/core';
import { IncomeService } from 'src/app/core/services/income.service';
import { Income } from 'src/app/shared/models/income';

@Component({
  selector: 'app-all-income',
  templateUrl: './all-income.component.html',
  styleUrls: ['./all-income.component.css']
})
export class AllIncomeComponent implements OnInit {

  incomes!:Income[]

  constructor(private incomeService: IncomeService) { }

  ngOnInit(): void {
    this.incomeService.getAllIncomes().subscribe(i => this.incomes = i)
  }

}
