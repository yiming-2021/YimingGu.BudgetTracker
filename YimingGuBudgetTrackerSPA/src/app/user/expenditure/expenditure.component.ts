import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { Expenditure } from 'src/app/shared/models/expenditure';

@Component({
  selector: 'app-expenditure',
  templateUrl: './expenditure.component.html',
  styleUrls: ['./expenditure.component.css']
})
export class ExpenditureComponent implements OnInit {

  expenditure!:Expenditure[];
  id: number = 0;

  constructor(private userService: UserService, private activeRoute: ActivatedRoute, private router: Router) { }

  ngOnInit(): void {
    this.activeRoute.paramMap.subscribe
      (
        p => {
          this.id = Number(p.get('id'));
          console.log('User Id= ' + this.id);
          // call the api
          this.userService.getUserExpenditureById(this.id)
            .subscribe(
              m => {
                this.expenditure = m;
                console.log(this.expenditure);
              }
            );
        }
      )
      
    console.log('inside expenditure details component');
  }

}    