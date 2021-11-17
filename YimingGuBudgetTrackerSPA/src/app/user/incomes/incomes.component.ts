import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { Income } from 'src/app/shared/models/income';

@Component({
  selector: 'app-incomes',
  templateUrl: './incomes.component.html',
  styleUrls: ['./incomes.component.css']
})
export class IncomesComponent implements OnInit {

  income!:Income[];
  id: number = 0;

  constructor(private userService: UserService, private activeRoute: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.activeRoute.paramMap.subscribe
      (
        p => {
          this.id = Number(p.get('id'));
          console.log('User Id= ' + this.id);
          // call the api
          this.userService.getUserIncomeById(this.id)
            .subscribe(
              m => {
                this.income = m;
                console.log(this.income);
              }
            );
        }
      )
      
    console.log('inside income details component');
  }

}    