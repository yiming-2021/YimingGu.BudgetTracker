import { Component, OnInit } from '@angular/core';
import { ExpenditureService } from 'src/app/core/services/expenditure.service';
import { Expenditure } from 'src/app/shared/models/expenditure';

@Component({
  selector: 'app-all-expenditure',
  templateUrl: './all-expenditure.component.html',
  styleUrls: ['./all-expenditure.component.css']
})
export class AllExpenditureComponent implements OnInit {

  expenditures!:Expenditure[]

  constructor(private expenditureService: ExpenditureService) { }

  ngOnInit(): void {
    this.expenditureService.getAllExpenditures().subscribe(e => this.expenditures = e)
  }

}
